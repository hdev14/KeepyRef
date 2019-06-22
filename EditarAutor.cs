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
    public partial class EditarAutor : Form
    {
        private int id_autor = 0;

        public EditarAutor(int id_autor, string nome, string sobrenome)
        {
            InitializeComponent();
            this.id_autor = id_autor;
            txtNome.Text = nome;
            txtSobrenome.Text = sobrenome;
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (this.id_autor == 0)
                return;

            if(!validarCampos(txtNome.Text, txtSobrenome.Text))
                return;
            

            if (Autor.editarAutor(this.id_autor, txtNome.Text, txtSobrenome.Text))
            {
                Close();
                MessageBox.Show("Autor modificado com successo.");
            }
            else
                MessageBox.Show("Não foi possivel editar o autor. Por favor tente novamente.");

        }

        private bool validarCampos(string nome, string sobrenome)
        {
            if (nome.Trim() == "")
            {
                lbErrorNome.Text = "Por favor preencha o nome do autor.";
                return false;
            }

            if (sobrenome.Trim() == "")
            {
                lbErrorSobrenome.Text = "Por favor preencha o sobrenome do autor.";
                return false;
            }

            return true;
        }

    }
}
