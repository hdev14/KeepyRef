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

namespace Citador
{
    public partial class CitacoesControl : UserControl
    {
        private citacao citacao_selecionada = null;
        public CitacoesControl()
        {
            InitializeComponent();
        }

        private void BtnCitacaoAdd_Click(object sender, EventArgs e)
        {
            CadastroCitacao frm = new CadastroCitacao();
            frm.Show();
            frm.FormClosed += CitacoesControl_Load;
        }

        private void CitacoesControl_Load(object sender, EventArgs e) => LoadControl();

        private void LoadControl()
        {
            List<citacao> citacoes = Citacao.listarCitacao();

            lvCitacao.Items.Clear();

            if (citacoes == null)
                return;

            foreach (var citacao in citacoes)
            {

                var linha_citacao = new string[] { citacao.conteudo };
                var lvItem = new ListViewItem(linha_citacao);

                lvItem.Tag = citacao;

                lvCitacao.Items.Add(lvItem);

            }
        }

        private void LvCitacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.citacao_selecionada = (citacao)lvCitacao.SelectedItems[0].Tag;
            }
            catch (Exception ex)
            {
                return;
            }

        }

        private void btnCitacaoEdit_Click(object sender, EventArgs e)
        {
            if (this.citacao_selecionada == null)
            {
                lbCitacaoSelecionado.Text = "Por favor, selecione uma citação para a edição.";
                return;
            }

            var id = this.citacao_selecionada.id;
            var conteudo = this.citacao_selecionada.conteudo;

            EditarCitacao frm = new EditarCitacao(id, conteudo);
            frm.Show();
            frm.FormClosed += CitacoesControl_Load;

            ClearCitacao();

        }

        private void btnCitacaoDel_Click(object sender, EventArgs e)
        {
            if (this.citacao_selecionada == null)
            {
                lbCitacaoSelecionado.Text = "Por favor, selecione uma citação para a remoção.";
                return;
            }

            if (Citacao.excluirCitacao(this.citacao_selecionada.id))
            {
                MessageBox.Show("Citação excluída com sucesso.");
                LoadControl();
            }
            else
                MessageBox.Show("Não foi possível exclui a citação. Por favor, tente novamente.");


            ClearCitacao();

        }

        private void ClearCitacao()
        {
            this.citacao_selecionada = null;
        }
    }
}
