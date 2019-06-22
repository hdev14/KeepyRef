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
using Citador.modelo;

namespace Citador
{
    public partial class CadastroObra : Form
    {
        public CadastroObra()
        {
            InitializeComponent();

            List<autor> autores = Autor.listarAutores();

            autorBindingSource.DataSource = autores;
            
        }

        private void LbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            // Fazer uma a lógica para o id do autor.


            if (txtVolume.Text.Trim() == "" || txtEdicao.Text.Trim() == "" || txtPag.Text.Trim() == "")
            {
                lbNumeros.Text = "Os campos 'Volume', 'Número da Edição' e 'Números de Página' não podem ser nulos.";
                return;
            }

            var id_autor = Convert.ToInt32(cbAutores.SelectedValue);

            if ( !validarCampos(id_autor, txtTitulo.Text, txtLocal.Text, txtEditora.Text, 
                                    Convert.ToInt32(txtVolume.Text), Convert.ToInt32(txtEdicao.Text), Convert.ToInt32(txtPag.Text)) )
                return;

            if (Obra.criarObra(id_autor, txtTitulo.Text, txtEditora.Text, txtLocal.Text, dtpAno.Value, 
                                    Convert.ToInt32(txtVolume.Text), Convert.ToInt32(txtEdicao.Text), Convert.ToInt32(txtPag.Text)) )
            {
                Close();
                MessageBox.Show("Obra adicionada com sucesso na lista !");
            }
            else
            {
                MessageBox.Show("Não foi possível adicionar a obra. Por favor, tente novamente !");
            }
        }

        private bool validarCampos(int idAutor, string titulo, string local, string editora, 
                                                int volume = 0, int edicao = 0, int pag = 0)
        {
            if (idAutor == 0)
            {
                lbAutorError.Text = "Por favor, selecione um autor.";
                return false;
            }

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

            if (edicao == 0)
            {
                lbErrorPag.Text = "Preencha o número da páginas da obra.";
                return false;
            }

            return true;
        }

        private void CbAutores_Click(object sender, EventArgs e)
        {
            lbAutorError.Text = "";
        }

        private void TxtTitulo_Click(object sender, EventArgs e)
        {
            lbObraError.Text = "";
        }

        private void TxtLocal_Click(object sender, EventArgs e)
        {
            lbLocalError.Text = "";
        }

        private void TxtEditora_Click(object sender, EventArgs e)
        {
            lbEditoraError.Text = "";
        }


    }
}
