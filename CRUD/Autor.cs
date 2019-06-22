using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Citador.modelo;

namespace Citador.CRUD
{
    class Autor
    {
        public static bool criarAutor(string nome, string sobrenome) {
            using (var db = new citadorDoisEntities()) {

                autor a = new autor();
                a.nome = nome;
                a.sobrenome = sobrenome;
                db.autor.Add(a);

                if (db.SaveChanges() == 1)
                    return true;
            }
            return false;
        }

        public static bool editarAutor(int id, string nome, string sobrenome) {
            using (var db = new citadorDoisEntities()) {

                var autor = (from a in db.autor
                             where a.id == id
                             select a).FirstOrDefault();

                if (autor == null)
                    return false;

                autor.nome = nome;
                autor.sobrenome = sobrenome;
                

                if (db.SaveChanges() == 1)
                    return true;
            }

            return false;
        }

        public static bool excluirAutor(int id) {

            using (var db = new citadorDoisEntities()) {

                var autor = (from a in db.autor
                             where a.id == id
                             select a).FirstOrDefault();


                if (autor == null)
                    return false;

                var autor_obra = db.autor.Include("obra")
                                    .Where(at => at.id.Equals(autor.id))
                                    .FirstOrDefault();

                autor_obra.obra.Clear();
                db.autor.Remove(autor_obra);
                db.SaveChanges();

                return true;
            }
        }

        public static List<autor> listarAutores() {

            List<autor> listAutor = new List<autor>();

            using (var db = new citadorDoisEntities()) {
                var autores = (from a in db.autor
                               select a);

                foreach (var autor in autores) {
                    listAutor.Add(autor);
                }

                if (listAutor.Count() > 0)
                    return listAutor;
            }

            return null;
        }


    }
}
