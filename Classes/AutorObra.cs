using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citador.Classes
{
    class AutorObra
    {
        private string nome;
        private string sobrenome;
        private string titulo;
        private string editora;
        private string local;
        private string ano;
        private string volume;
        private string edicao;
        private string pag;

        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Editora { get => editora; set => editora = value; }
        public string Local { get => local; set => local = value; }
        public string Ano { get => ano; set => ano = value; }
        public string Volume { get => volume; set => volume = value; }
        public string Edicao { get => edicao; set => edicao = value; }
        public string Pag { get => pag; set => pag = value; }
    }
}
