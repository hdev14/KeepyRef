using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Citador.CRUD;

namespace Citador
{
    public partial class EditarObra : Form
    {
        private int id_obra = 0;
        public EditarObra(int id_obra, string titulo, 
            string local, string editora, DateTime ano, int volume, int edicao)
        {
            InitializeComponent();
            this.id_obra = id_obra;
            txtTitulo.Text = titulo;
            txtLocal.Text = local;
            txtEditora.Text = editora;
            dtpAno.Text = ano.ToString();
            txtVolume.Text = volume.ToString();
            txtEdicao.Text = edicao.ToString();

        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (this.id_obra == 0)
                return;

            if (txtVolume.Text.Trim() == "" || txtEdicao.Text.Trim() == "" || txtPag.Text.Trim() == "")
            {
                lbNumeros.Text = "Os campos 'Volume' e 'Número da Edição' não podem ser nulos.";
                return;
            }

            if (!validarCampos(txtTitulo.Text, txtLocal.Text, txtEditora.Text,
                    Convert.ToInt32(txtVolume.Text), Convert.ToInt32(txtEdicao.Text), Convert.ToInt32(txtPag.Text)))
                return;

           

            if ( Obra.editarObra(this.id_obra, txtTitulo.Text, txtLocal.Text, txtEditora.Text, dtpAno.Value, 
                                Convert.ToInt32(txtVolume.Text), Convert.ToInt32(txtEdicao.Text), Convert.ToInt32(txtPag.Text)) )
            {
                Close();
                MessageBox.Show("Obra modificada com sucesso.");
            }
            else
                MessageBox.Show("Não foi possível editar a obra. Por favor, tente novamente.");

        }



        private bool validarCampos(string titulo, string local, string editora, 
                                            int volume = 0, int edicao = 0, int pag = 0)
        {

            if (titulo.Trim() == "")
            {
                lbObraError.Text = "Preencha o nome da obra.";
                return false;
            }

            if (local.Trim() == "")
            {
                lbLocalError.Text = "Preencha o local de publicação do obra.";
                return false;
            }

            if (editora.Trim() == "")
            {
                lbEditoraError.Text = "Preencha o nome da editora.";
                return false;
            }

            if (volume == 0)
            {
                lbErrorVolume.Text = "Preencha o volume da obra.";
                return false;
            }

            if (edicao == 0)
            {
                lbErrorEdicao.Text = "Preencha o número da edição da obra.";
                return false;
            }

            if (pag == 0)
            {
                lbErrorPag.Text = "Preencha o número da páginas da obra.";
                return false;
            }

            return true;
        }

    
    }
}
