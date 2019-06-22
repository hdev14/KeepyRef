using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Citador.modelo;

namespace Citador.CRUD
{
    class Obra
    {
       
        public static bool criarObra(int idAutor, string titulo, string editora,
                                       string local_pub, DateTime ano_pub, int volume, int edicao, int pag)
        {
            using (var db = new citadorDoisEntities()) {

                autor autor = (from a in db.autor
                               where a.id == idAutor
                               select a).FirstOrDefault();

                if (autor == null)
                    return false;

                obra ob = new obra();
                ob.titulo = titulo;
                ob.editora = editora;
                ob.local_pub = local_pub;
                ob.ano_pub = ano_pub;
                ob.volume = volume;
                ob.edicao = edicao;
                ob.pag = pag;

                autor.obra.Add(ob);

                db.SaveChanges();
                    
                return true;

            }
        }


        public static bool editarObra(int id, string titulo, string editora, string local_pub, 
                                                DateTime ano_pub, int volume, int edicao, int pag) {

            using (var db = new citadorDoisEntities()) {
                var obra = (from ob in db.obra
                            where ob.id == id
                            select ob).FirstOrDefault();

                if (obra == null)
                    return false;

                obra.titulo = titulo;
                obra.editora = editora;
                obra.local_pub = local_pub;
                obra.ano_pub = ano_pub;
                obra.pag = pag;

                if (db.SaveChanges() == 1)
                    return true;

            }
            return false;
        }

        public static bool excluirObra(int id) {
            using (var db = new citadorDoisEntities()) {

                obra obra = (from ob in db.obra
                            where ob.id == id
                            select ob).FirstOrDefault();

                if (obra == null)
                    return false;

                var obra_autores = db.obra.Include("autor")
                                    .Where(o => o.id.Equals(obra.id))
                                    .FirstOrDefault();

                obra_autores.citacao.Clear();
                obra_autores.autor.Clear();
                db.obra.Remove(obra_autores);


                db.SaveChanges();

                return true;
            }
            
        }

        public static List<obra> listarObra() {

            List<obra> listObras = new List<obra>();

            using (var db = new citadorDoisEntities()) {
                var obras = (from ob in db.obra
                             select ob);

                foreach (var obra in obras) {
                    listObras.Add(obra);
                }

                if (listObras.Count() > 0)
                    return listObras;
            }
            return null;
        }
       
        
    }
}
