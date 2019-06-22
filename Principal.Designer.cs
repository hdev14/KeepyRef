namespace Citador
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.btnObras = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.btnCitacoes = new System.Windows.Forms.Button();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.plConteudo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pnl1);
            this.panel1.Controls.Add(this.btnObras);
            this.panel1.Controls.Add(this.btnAutores);
            this.panel1.Controls.Add(this.btnCitacoes);
            this.panel1.Controls.Add(this.btnPrincipal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 600);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(52, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.White;
            this.pnl1.Location = new System.Drawing.Point(0, 166);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(15, 61);
            this.pnl1.TabIndex = 2;
            // 
            // btnObras
            // 
            this.btnObras.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnObras.BackColor = System.Drawing.Color.Transparent;
            this.btnObras.FlatAppearance.BorderSize = 0;
            this.btnObras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnObras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObras.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObras.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnObras.Location = new System.Drawing.Point(12, 300);
            this.btnObras.Name = "btnObras";
            this.btnObras.Size = new System.Drawing.Size(197, 61);
            this.btnObras.TabIndex = 0;
            this.btnObras.Text = "OBRAS";
            this.btnObras.UseVisualStyleBackColor = false;
            this.btnObras.Click += new System.EventHandler(this.btnObras_Click);
            this.btnObras.MouseEnter += new System.EventHandler(this.btnObras_MouseEnter);
            this.btnObras.MouseLeave += new System.EventHandler(this.btnObras_MouseLeave);
            // 
            // btnAutores
            // 
            this.btnAutores.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnAutores.BackColor = System.Drawing.Color.Transparent;
            this.btnAutores.FlatAppearance.BorderSize = 0;
            this.btnAutores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutores.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutores.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAutores.Location = new System.Drawing.Point(12, 233);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(197, 61);
            this.btnAutores.TabIndex = 0;
            this.btnAutores.Text = "AUTORES";
            this.btnAutores.UseVisualStyleBackColor = false;
            this.btnAutores.Click += new System.EventHandler(this.btnAutores_Click);
            this.btnAutores.MouseEnter += new System.EventHandler(this.btnAutores_MouseEnter);
            this.btnAutores.MouseLeave += new System.EventHandler(this.btnAutores_MouseLeave);
            // 
            // btnCitacoes
            // 
            this.btnCitacoes.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCitacoes.BackColor = System.Drawing.Color.Transparent;
            this.btnCitacoes.FlatAppearance.BorderSize = 0;
            this.btnCitacoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCitacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitacoes.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitacoes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCitacoes.Location = new System.Drawing.Point(12, 367);
            this.btnCitacoes.Name = "btnCitacoes";
            this.btnCitacoes.Size = new System.Drawing.Size(197, 61);
            this.btnCitacoes.TabIndex = 0;
            this.btnCitacoes.Text = "CITAÇÕES";
            this.btnCitacoes.UseVisualStyleBackColor = false;
            this.btnCitacoes.Click += new System.EventHandler(this.btnCitacoes_Click);
            this.btnCitacoes.MouseEnter += new System.EventHandler(this.btnCitacoes_MouseEnter);
            this.btnCitacoes.MouseLeave += new System.EventHandler(this.btnCitacoes_MouseLeave);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btnPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipal.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrincipal.Location = new System.Drawing.Point(12, 166);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(197, 61);
            this.btnPrincipal.TabIndex = 0;
            this.btnPrincipal.Text = "PRINCIPAL";
            this.btnPrincipal.UseVisualStyleBackColor = false;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            this.btnPrincipal.MouseEnter += new System.EventHandler(this.btnPrincipal_MouseEnter);
            this.btnPrincipal.MouseLeave += new System.EventHandler(this.btnPrincipal_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(859, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(42, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // plConteudo
            // 
            this.plConteudo.Cursor = System.Windows.Forms.Cursors.Default;
            this.plConteudo.Location = new System.Drawing.Point(201, 27);
            this.plConteudo.Name = "plConteudo";
            this.plConteudo.Size = new System.Drawing.Size(700, 576);
            this.plConteudo.TabIndex = 3;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.plConteudo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnObras;
        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.Button btnCitacoes;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel plConteudo;
    }
}

