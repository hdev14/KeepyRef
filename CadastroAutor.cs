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
    public partial class CadastroAutor : Form
    {
        public CadastroAutor()
        {
            InitializeComponent();
 
        }


        private void LbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (!validarCampos(txtNome.Text, txtSobrenome.Text))
                return;

            if (Autor.criarAutor(txtNome.Text, txtSobrenome.Text))
            {
                Close();
                MessageBox.Show("Autor cadastrado com successo !");
                
            }
            else
            {
                MessageBox.Show("Não foi possivel cadastrar o autor. Por favor, tente novamente !");
            }
        }

        private bool validarCampos(string nome, string sobrenome)
        {
            if (nome.Trim() == "")
            {
                lbNomeError.Text = "Por favor preencha o nome do autor.";
                return false;
            }

            if(sobrenome.Trim() == "")
            {
                lbSobrenomeError.Text = "Por favor preencha o sobrenome do autor.";
                return false;
            }

            return true;
        }

        private void TxtNome_Click(object sender, EventArgs e)
        {
            lbNomeError.Text = "";
        }

        private void TxtSobrenome_Click(object sender, EventArgs e)
        {
            lbSobrenomeError.Text = "";
        }
    }
}
