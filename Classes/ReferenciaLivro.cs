using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citador.Classes
{
    class ReferenciaLivro
    {
        public static string nomeDoAutor(string nome, string sobrenome)
        {
            sobrenome = FormatarDadosDeLivro.tornarCaixaAlta(sobrenome);
            nome = FormatarDadosDeLivro.tornarCaixaBaixa(nome);
            nome = FormatarDadosDeLivro.capitalizar(nome);
            string nomePadraoAbnt = String.Format("{0}, {1}. ", sobrenome, nome);

            return nomePadraoAbnt;
        }

        public static string titulo(string titulo)
        {

            titulo = FormatarDadosDeLivro.capitalizar(titulo);
            string tituloPadraoAbnt = String.Format("{0}, ", titulo);

            return tituloPadraoAbnt;
        }

        public static string dadosDaObra(string edicaoDoLivro, string localDePublicacao,
                                            string editora, string ano, string volume, string pag)
        {

            localDePublicacao = FormatarDadosDeLivro.capitalizar(localDePublicacao);
            editora = FormatarDadosDeLivro.capitalizar(editora);

            string dadosDaObraPadraoAbnt =
                String.Format("{0}. ed. {1}: {2}, {3}. v.{4}, {5}.p.", 
                            edicaoDoLivro, localDePublicacao, editora, ano, volume, pag);

            return dadosDaObraPadraoAbnt;
        }
    }
}
