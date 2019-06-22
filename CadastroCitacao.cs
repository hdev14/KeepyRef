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
    public partial class CadastroCitacao : Form
    {
        public CadastroCitacao()
        {
            InitializeComponent();


            List<obra> obras = Obra.listarObra();
            obraBindingSource.DataSource = obras;

        }

        private void LbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCriar_Click(object sender, EventArgs e)
        {
            var id_obra = Convert.ToInt32(cbObras.SelectedValue);

            if (!validarCampos(id_obra, txtCitacao.Text))
                return;
            
            if (Citacao.criarCitacao(id_obra, txtCitacao.Text))
            {
                Close();
                MessageBox.Show("A citação foi criada com sucesso.");    
            }
            else
            {
                MessageBox.Show("Não foi possível criar a citação. Por favor, tente novamente !");
            }
            
            
        }

        private bool validarCampos(int idObra, string citacao)
        {
            if (idObra == 0)
            {
                lbObraError.Text = "Por favor, selecione uma obra.";
                return false;
            }

            if (citacao.Trim() == "")
            {
                lbCitacaoError.Text = "Por favor, digite sua citação.";
                return false;
            }

           return true;
        }

        private void CbObras_Click(object sender, EventArgs e)
        {
            lbObraError.Text = "";
        }

        private void TxtCitacao_Click(object sender, EventArgs e)
        {
            lbCitacaoError.Text = "";
        }
    }
}
