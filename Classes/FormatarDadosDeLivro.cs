using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citador.Classes
{
    class FormatarDadosDeLivro
    {
        public static string capitalizar(string valor)
        {
            return System.Threading.Thread.CurrentThread.
                    CurrentCulture.TextInfo.ToTitleCase(valor.ToLower());
        }

        public static string tornarCaixaAlta(string valor)
        {
            return valor.ToUpper();
        }

        public static string tornarCaixaBaixa(string valor)
        {
            return valor.ToLower();
        }
    }
}
