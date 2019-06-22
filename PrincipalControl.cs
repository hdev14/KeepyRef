using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Citador.CRUD;
using Citador.modelo;
using Citador.Classes;

namespace Citador
{
    public partial class PrincipalControl : UserControl
    {
        public PrincipalControl()
        {
            InitializeComponent();
        }

        private void  PrincipalControl_Load(object sender, EventArgs e) => LoadControl();

        private void LoadControl()
        {
            List<AutorObra> autores_obras = listAutoresObras();

            flpReferencia.Controls.Clear();

            if (autores_obras == null) {

                Label lbNenhuma = new Label();
                lbNenhuma.AutoSize = true;
                lbNenhuma.Font = new Font("Times New Roman", 12F);
                lbNenhuma.Name = "nenhuma";
                lbNenhuma.Text = "Nenhuma Referência.";
               

                FlowLayoutPanel flpNenhuma = new FlowLayoutPanel();
                flpNenhuma.Name = "flwNenhum";
                flpNenhuma.AutoSize = true;
                flpNenhuma.Top = 20;
                flpNenhuma.Left = 20;
                flpNenhuma.Size = new Size(580, 50);

                flpNenhuma.Controls.Add(lbNenhuma);

                Panel p = new Panel();
                p.Name = "pNenhuma";
                p.Size = new Size(590, 80);
                p.BorderStyle = BorderStyle.FixedSingle;
                p.Controls.Add(flpNenhuma);

                flpReferencia.Controls.Add(p);
                return;
            }

            var tamanho = autores_obras.Count();

            for (var h = 0; h < tamanho; h++)
            {
                Label lbNome = new Label();
                lbNome.AutoSize = true;
                lbNome.Font = new Font("Times New Roman", 12F);
                lbNome.Name = autores_obras[h].Nome + h;
                lbNome.Text = ReferenciaLivro.nomeDoAutor(autores_obras[h].Nome, autores_obras[h].Sobrenome);

                Label lbTitulo = new Label();
                lbTitulo.AutoSize = true;
                lbTitulo.Font = new Font("Times New Roman", 12F, FontStyle.Bold);

                lbTitulo.Name = autores_obras[h].Titulo + h;
                lbTitulo.Text = ReferenciaLivro.titulo(autores_obras[h].Titulo);

                Label lbObra = new Label();
                lbObra.AutoSize = true;
                lbObra.Font = new Font("Times New Roman", 12F);
                lbObra.Name = "obra" + h;
                lbObra.Text = ReferenciaLivro.dadosDaObra(
                    autores_obras[h].Edicao, 
                    autores_obras[h].Local, 
                    autores_obras[h].Editora, 
                    autores_obras[h].Ano, 
                    autores_obras[h].Volume, 
                    autores_obras[h].Pag
                );

                FlowLayoutPanel flp = new FlowLayoutPanel();
                flp.Name = "flw" + h;
                flp.AutoSize = true;
                flp.Top = 20;
                flp.Left = 20;
                flp.Size = new Size(580, 50);

                flp.Controls.Add(lbNome);
                flp.Controls.Add(lbTitulo);
                flp.Controls.Add(lbObra);

                Panel p = new Panel();
                p.Name = "p" + h;
                p.Size = new Size(590, 80);
                p.BorderStyle = BorderStyle.FixedSingle;
                p.Controls.Add(flp);

                flpReferencia.Controls.Add(p);
            }
        }

        private static List<AutorObra> listAutoresObras()
        {
            List<AutorObra> autores_obras = new List<AutorObra>();

            using (var db = new citadorDoisEntities())
            {
                List<autor> autores = (from a in db.autor select a).ToList();

                if (autores.Count() == 0)
                    return null;

                foreach (var autor in autores)
                {
                    List<obra> obras = autor.obra.ToList();

                    if (obras.Count() == 0)
                        continue;

                    foreach (var obra in obras)
                    {
                        AutorObra autor_obra = new AutorObra();

                        autor_obra.Nome = autor.nome;
                        autor_obra.Sobrenome = autor.sobrenome;
                        autor_obra.Titulo = obra.titulo; 
                        autor_obra.Editora = obra.editora;
                        autor_obra.Local = obra.local_pub;
                        autor_obra.Ano = obra.ano_pub.Value.Year.ToString();
                        autor_obra.Volume = obra.volume.ToString();
                        autor_obra.Edicao = obra.edicao.ToString();
                        autor_obra.Pag = obra.pag.ToString();

                        autores_obras.Add(autor_obra);
                    }
                }
            }

            return autores_obras;
        }
    }
}
