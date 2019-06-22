using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Citador.modelo;

namespace Citador.CRUD
{
    class Citacao
    {
        public static bool criarCitacao(int idObra, string conteudo) {

            using (var db = new citadorDoisEntities()) {

                obra obra = (from ob in db.obra
                           where ob.id == idObra
                           select ob).FirstOrDefault();

                if (obra == null)
                    return false;

                citacao cit = new citacao();
                cit.conteudo = conteudo;
                obra.citacao.Add(cit);

                if (db.SaveChanges() == 1)
                    return true;
            }

            return false;
        }

        public static bool editarCitacao(int id, string conteudo) {

            using (var db = new citadorDoisEntities()) {

                citacao cit = (from c in db.citacao
                               where c.id == id
                               select c).FirstOrDefault();

                if (cit == null)
                    return false;

                cit.conteudo = conteudo;

                db.SaveChanges();

                return true;
            }
        }

        public static bool excluirCitacao(int id) {

            using (var db = new citadorDoisEntities())
            {
                citacao cit = (from c in db.citacao
                               where c.id == id
                               select c).FirstOrDefault();

                if (cit == null)
                    return false;

                db.citacao.Remove(cit);
                db.SaveChanges();

                return true;
            }
        }

        public static List<citacao> listarCitacao() {

            List<citacao> listCitacao = new List<citacao>();

            using (var db = new citadorDoisEntities()) {
                var citacoes = (from c in db.citacao
                                select c);

                foreach (var citacao in citacoes) {
                    listCitacao.Add(citacao);
                }

                if (listCitacao.Count() > 0)
                    return listCitacao;
            }

            return null;
        }
        public static citacao getCitacao(int id) {

            using (var db = new citadorDoisEntities()) {
                citacao cit = (from c in db.citacao
                               select c).FirstOrDefault();
                return cit;
            }
        } 
    }
}
