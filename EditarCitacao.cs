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
    public partial class EditarCitacao : Form
    {
        private int id_citacao = 0;
        public EditarCitacao(int id_citacao, string citacao)
        {
            InitializeComponent();
            this.id_citacao = id_citacao;
            txtCitacao.Text = citacao;
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (this.id_citacao == 0)
                return;

            if (!validarCampos(txtCitacao.Text))
                return;

            if (Citacao.editarCitacao(this.id_citacao, txtCitacao.Text))
            {
                Close();
                MessageBox.Show("Citação modificar com sucesso.");
            }
            else
                MessageBox.Show("Não foi possível editar a citação. Por favor, tente novamente.");

        }

        private bool validarCampos(string citacao)
        {
            if (citacao.Trim() == "")
            {
                lbCitacaoError.Text = "Por favor, digite sua citação.";
                return false;
            }

            return true;
        }

    
    }
}
