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
    public partial class AutoresControl : UserControl
    {
        private autor autor_selecionado = null;

        public AutoresControl()
        {
            InitializeComponent();

        }

        private void BtnAutorAdd_Click(object sender, EventArgs e)
        {
            CadastroAutor frm = new CadastroAutor();
            frm.Show();
            frm.FormClosed += AutoresControl_Load;
        }

        private void AutoresControl_Load(object sender, EventArgs e) => LoadControl();

        private void LoadControl()
        {

            List<autor> autores = Autor.listarAutores();

            lvAutor.Items.Clear();

            if (autores == null)
                return;

            foreach (var autor in autores)
            {
                var autor_linha = new string[] { autor.nome, autor.sobrenome };
                var lvItem = new ListViewItem(autor_linha);

                lvItem.Tag = autor;

                lvAutor.Items.Add(lvItem);
            }

        }

        private void LvAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbAutorSelecionado.Text = "";
                this.autor_selecionado = (autor)lvAutor.SelectedItems[0].Tag;
            }
            catch (Exception ex)
            {
                this.autor_selecionado = null;
                return;
            }

        }

        private void BtnAutorEdit_Click(object sender, EventArgs e)
        {

            if (this.autor_selecionado == null)
            {
                lbAutorSelecionado.Text = "Por favor, selecione um autor para a edição.";
                return;
            }

            var id = this.autor_selecionado.id;
            var nome = this.autor_selecionado.nome;
            var sobrenome = this.autor_selecionado.sobrenome;

            EditarAutor frm = new EditarAutor(id, nome, sobrenome);
            frm.Show();
            frm.FormClosed += AutoresControl_Load;

            ClearAutor();

        }



        private void BtnAutorDel_Click(object sender, EventArgs e)
        {

            if (this.autor_selecionado == null)
            {
                lbAutorSelecionado.Text =
                    "Por favor, selecione um autor para a remoção.";
                return;
            }
            

            //Excluir
            if (Autor.excluirAutor(this.autor_selecionado.id))
            {
                MessageBox.Show("Autor excluído com sucesso.");
                LoadControl();
            }
            else
                MessageBox.Show("Não foi possível exclui o autor. Por favor, tente novamente.");


            
            // Limpa o usuário selecionado.
            ClearAutor();

        }

        private void ClearAutor()
        {
            this.autor_selecionado = null;
        }
    }
}
