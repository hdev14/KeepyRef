using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citador
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            pnl1.Top = btnPrincipal.Top;
            PrincipalControl p = new PrincipalControl();
            plConteudo.Controls.Add(p);
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            pnl1.Top = btnPrincipal.Top;
            PrincipalControl p = new PrincipalControl();
            plConteudo.Controls.Clear();
            plConteudo.Controls.Add(p);
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            pnl1.Top = btnAutores.Top;
            AutoresControl a = new AutoresControl();
            plConteudo.Controls.Clear();
            plConteudo.Controls.Add(a);

        }

        private void btnObras_Click(object sender, EventArgs e)
        {
            pnl1.Top = btnObras.Top;
            ObrasControl o = new ObrasControl();
            plConteudo.Controls.Clear();
            plConteudo.Controls.Add(o);

        }

        private void btnCitacoes_Click(object sender, EventArgs e)
        {
            pnl1.Top = btnCitacoes.Top;
            CitacoesControl c = new CitacoesControl();
            plConteudo.Controls.Clear();
            plConteudo.Controls.Add(c);
        }

        private void btnPrincipal_MouseEnter(object sender, EventArgs e)
        {
            btnPrincipal.ForeColor = System.Drawing.Color.FromArgb(8, 103, 136);
        }

        private void btnAutores_MouseEnter(object sender, EventArgs e)
        {
            btnAutores.ForeColor = System.Drawing.Color.FromArgb(8, 103, 136);
        }

        private void btnObras_MouseEnter(object sender, EventArgs e)
        {
            btnObras.ForeColor = System.Drawing.Color.FromArgb(8, 103, 136);
        }

        private void btnCitacoes_MouseEnter(object sender, EventArgs e)
        {
            btnCitacoes.ForeColor = System.Drawing.Color.FromArgb(8, 103, 136);
        }

        private void btnPrincipal_MouseLeave(object sender, EventArgs e)
        {
            btnPrincipal.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
        }

        private void btnAutores_MouseLeave(object sender, EventArgs e)
        {
            btnAutores.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
        }

        private void btnObras_MouseLeave(object sender, EventArgs e)
        {
            btnObras.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
        }

        private void btnCitacoes_MouseLeave(object sender, EventArgs e)
        {
            btnCitacoes.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
