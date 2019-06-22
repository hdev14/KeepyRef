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
    public partial class ObrasControl : UserControl
    {
        private obra obra_selecionada = null;

        public ObrasControl()
        {
            InitializeComponent();
        }

        private void BtnObraAdd_Click(object sender, EventArgs e)
        {
            CadastroObra frm = new CadastroObra();
            frm.Show();
            frm.FormClosed += ObrasControl_Load;

        }

        private void ObrasControl_Load(object sender, EventArgs e) => LoadControl();

        private void LoadControl()
        {

            List<obra> obras = Obra.listarObra();

            lvObra.Items.Clear();

            if (obras == null)
                return;

            foreach (var obra in obras)
            {
                var linha_obra = new string[] {
                    obra.titulo,
                    obra.editora,
                    obra.local_pub,
                    ((DateTime)obra.ano_pub).Year.ToString(),
                    obra.volume.ToString(),
                    obra.edicao.ToString()

                };

                var lvItem = new ListViewItem(linha_obra);

                lvItem.Tag = obra;

                lvObra.Items.Add(lvItem);
            }
        }

        private void LvObra_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                lbObraSelecionado.Text = "";
                this.obra_selecionada = (obra)lvObra.SelectedItems[0].Tag;
            }
            catch (Exception ex)
            {
                return;
            }


        }

        private void BtnObraEdit_Click(object sender, EventArgs e)
        {

            if (this.obra_selecionada == null)
            {
                lbObraSelecionado.Text = "Por favor, selecione uma obra para a edição.";
                return;
            }

            var id = this.obra_selecionada.id;
            var titulo = this.obra_selecionada.titulo;
            var editora = this.obra_selecionada.editora;
            var local = this.obra_selecionada.local_pub;
            DateTime ano = (DateTime)this.obra_selecionada.ano_pub;
            int volume = Convert.ToInt32(this.obra_selecionada.volume);
            int edicao = Convert.ToInt32(this.obra_selecionada.edicao);

            EditarObra frm = new EditarObra(id, titulo, editora, local, ano, volume, edicao);
            frm.Show();
            frm.FormClosed += ObrasControl_Load;

            ClearObra();

        }



        private void BtnObraDel_Click(object sender, EventArgs e)
        {

            if (this.obra_selecionada == null)
            {
                lbObraSelecionado.Text =
                    "Por favor, selecione uma obra para a remoção.";
                return;
            }

            if (Obra.excluirObra(this.obra_selecionada.id))
            {
                MessageBox.Show("Obra excluída com sucesso.");
                LoadControl();
            }
            else
                MessageBox.Show("Não foi possível exclui a obra. Por favor, tente novamente.");

            ClearObra();

        }

        private void ClearObra()
        {
            this.obra_selecionada = null;
        }
    }
}
