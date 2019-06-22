namespace Citador
{
    partial class CadastroObra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroObra));
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAutores = new System.Windows.Forms.ComboBox();
            this.autorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dtpAno = new System.Windows.Forms.DateTimePicker();
            this.lbClose = new System.Windows.Forms.Label();
            this.lbAutorError = new System.Windows.Forms.Label();
            this.lbObraError = new System.Windows.Forms.Label();
            this.lbLocalError = new System.Windows.Forms.Label();
            this.lbEditoraError = new System.Windows.Forms.Label();
            this.lbVolume = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.lbEdicao = new System.Windows.Forms.Label();
            this.txtEdicao = new System.Windows.Forms.TextBox();
            this.lbErrorEdicao = new System.Windows.Forms.Label();
            this.lbErrorVolume = new System.Windows.Forms.Label();
            this.lbNumeros = new System.Windows.Forms.Label();
            this.lbErrorPag = new System.Windows.Forms.Label();
            this.lbPag = new System.Windows.Forms.Label();
            this.txtPag = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(24, 376);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(102, 29);
            this.btnAdicionar.TabIndex = 11;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.label3.Location = new System.Drawing.Point(299, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ano da publicação:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.label2.Location = new System.Drawing.Point(21, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Editora:";
            // 
            // txtEditora
            // 
            this.txtEditora.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditora.Location = new System.Drawing.Point(21, 322);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(261, 23);
            this.txtEditora.TabIndex = 4;
            this.txtEditora.Click += new System.EventHandler(this.TxtEditora_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(52, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adicione uma Nova Obra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.label4.Location = new System.Drawing.Point(18, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Local da Publicação:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.label5.Location = new System.Drawing.Point(21, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Título da obra:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(21, 201);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(261, 23);
            this.txtTitulo.TabIndex = 2;
            this.txtTitulo.Click += new System.EventHandler(this.TxtTitulo_Click);
            // 
            // txtLocal
            // 
            this.txtLocal.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocal.Location = new System.Drawing.Point(21, 264);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(261, 23);
            this.txtLocal.TabIndex = 3;
            this.txtLocal.Click += new System.EventHandler(this.TxtLocal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.label6.Location = new System.Drawing.Point(21, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Escolha o autor:";
            // 
            // cbAutores
            // 
            this.cbAutores.DataSource = this.autorBindingSource;
            this.cbAutores.DisplayMember = "nome";
            this.cbAutores.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAutores.FormattingEnabled = true;
            this.cbAutores.Location = new System.Drawing.Point(21, 133);
            this.cbAutores.Name = "cbAutores";
            this.cbAutores.Size = new System.Drawing.Size(261, 23);
            this.cbAutores.TabIndex = 1;
            this.cbAutores.ValueMember = "id";
            this.cbAutores.Click += new System.EventHandler(this.CbAutores_Click);
            // 
            // autorBindingSource
            // 
            this.autorBindingSource.DataSource = typeof(Citador.modelo.autor);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 61);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(498, 365);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 61);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // dtpAno
            // 
            this.dtpAno.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAno.Location = new System.Drawing.Point(299, 133);
            this.dtpAno.Name = "dtpAno";
            this.dtpAno.Size = new System.Drawing.Size(261, 23);
            this.dtpAno.TabIndex = 5;
            // 
            // lbClose
            // 
            this.lbClose.AutoSize = true;
            this.lbClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lbClose.ForeColor = System.Drawing.Color.DimGray;
            this.lbClose.Location = new System.Drawing.Point(557, 0);
            this.lbClose.Name = "lbClose";
            this.lbClose.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.lbClose.Size = new System.Drawing.Size(42, 40);
            this.lbClose.TabIndex = 30;
            this.lbClose.Text = "X";
            this.lbClose.Click += new System.EventHandler(this.LbClose_Click);
            // 
            // lbAutorError
            // 
            this.lbAutorError.AutoSize = true;
            this.lbAutorError.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutorError.ForeColor = System.Drawing.Color.IndianRed;
            this.lbAutorError.Location = new System.Drawing.Point(34, 160);
            this.lbAutorError.Name = "lbAutorError";
            this.lbAutorError.Size = new System.Drawing.Size(0, 12);
            this.lbAutorError.TabIndex = 31;
            // 
            // lbObraError
            // 
            this.lbObraError.AutoSize = true;
            this.lbObraError.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObraError.ForeColor = System.Drawing.Color.IndianRed;
            this.lbObraError.Location = new System.Drawing.Point(34, 228);
            this.lbObraError.Name = "lbObraError";
            this.lbObraError.Size = new System.Drawing.Size(0, 12);
            this.lbObraError.TabIndex = 32;
            // 
            // lbLocalError
            // 
            this.lbLocalError.AutoSize = true;
            this.lbLocalError.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalError.ForeColor = System.Drawing.Color.IndianRed;
            this.lbLocalError.Location = new System.Drawing.Point(31, 290);
            this.lbLocalError.Name = "lbLocalError";
            this.lbLocalError.Size = new System.Drawing.Size(0, 12);
            this.lbLocalError.TabIndex = 33;
            // 
            // lbEditoraError
            // 
            this.lbEditoraError.AutoSize = true;
            this.lbEditoraError.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditoraError.ForeColor = System.Drawing.Color.IndianRed;
            this.lbEditoraError.Location = new System.Drawing.Point(34, 348);
            this.lbEditoraError.Name = "lbEditoraError";
            this.lbEditoraError.Size = new System.Drawing.Size(0, 12);
            this.lbEditoraError.TabIndex = 34;
            // 
            // lbVolume
            // 
            this.lbVolume.AutoSize = true;
            this.lbVolume.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.lbVolume.Location = new System.Drawing.Point(296, 180);
            this.lbVolume.Name = "lbVolume";
            this.lbVolume.Size = new System.Drawing.Size(57, 16);
            this.lbVolume.TabIndex = 36;
            this.lbVolume.Text = "Volume:";
            // 
            // txtVolume
            // 
            this.txtVolume.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolume.Location = new System.Drawing.Point(296, 201);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(261, 23);
            this.txtVolume.TabIndex = 35;
            // 
            // lbEdicao
            // 
            this.lbEdicao.AutoSize = true;
            this.lbEdicao.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdicao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.lbEdicao.Location = new System.Drawing.Point(296, 243);
            this.lbEdicao.Name = "lbEdicao";
            this.lbEdicao.Size = new System.Drawing.Size(123, 16);
            this.lbEdicao.TabIndex = 38;
            this.lbEdicao.Text = "Número da Edição:";
            // 
            // txtEdicao
            // 
            this.txtEdicao.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdicao.Location = new System.Drawing.Point(296, 264);
            this.txtEdicao.Name = "txtEdicao";
            this.txtEdicao.Size = new System.Drawing.Size(261, 23);
            this.txtEdicao.TabIndex = 37;
            // 
            // lbErrorEdicao
            // 
            this.lbErrorEdicao.AutoSize = true;
            this.lbErrorEdicao.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorEdicao.ForeColor = System.Drawing.Color.IndianRed;
            this.lbErrorEdicao.Location = new System.Drawing.Point(304, 290);
            this.lbErrorEdicao.Name = "lbErrorEdicao";
            this.lbErrorEdicao.Size = new System.Drawing.Size(0, 12);
            this.lbErrorEdicao.TabIndex = 39;
            // 
            // lbErrorVolume
            // 
            this.lbErrorVolume.AutoSize = true;
            this.lbErrorVolume.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorVolume.ForeColor = System.Drawing.Color.IndianRed;
            this.lbErrorVolume.Location = new System.Drawing.Point(304, 228);
            this.lbErrorVolume.Name = "lbErrorVolume";
            this.lbErrorVolume.Size = new System.Drawing.Size(0, 12);
            this.lbErrorVolume.TabIndex = 40;
            // 
            // lbNumeros
            // 
            this.lbNumeros.AutoSize = true;
            this.lbNumeros.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeros.ForeColor = System.Drawing.Color.IndianRed;
            this.lbNumeros.Location = new System.Drawing.Point(315, 385);
            this.lbNumeros.MaximumSize = new System.Drawing.Size(261, 0);
            this.lbNumeros.Name = "lbNumeros";
            this.lbNumeros.Size = new System.Drawing.Size(0, 12);
            this.lbNumeros.TabIndex = 67;
            // 
            // lbErrorPag
            // 
            this.lbErrorPag.AutoSize = true;
            this.lbErrorPag.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorPag.ForeColor = System.Drawing.Color.IndianRed;
            this.lbErrorPag.Location = new System.Drawing.Point(307, 348);
            this.lbErrorPag.Name = "lbErrorPag";
            this.lbErrorPag.Size = new System.Drawing.Size(0, 12);
            this.lbErrorPag.TabIndex = 70;
            // 
            // lbPag
            // 
            this.lbPag.AutoSize = true;
            this.lbPag.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.lbPag.Location = new System.Drawing.Point(296, 301);
            this.lbPag.Name = "lbPag";
            this.lbPag.Size = new System.Drawing.Size(136, 16);
            this.lbPag.TabIndex = 69;
            this.lbPag.Text = "Números de Páginas:";
            // 
            // txtPag
            // 
            this.txtPag.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPag.Location = new System.Drawing.Point(296, 322);
            this.txtPag.Name = "txtPag";
            this.txtPag.Size = new System.Drawing.Size(261, 23);
            this.txtPag.TabIndex = 68;
            // 
            // CadastroObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 426);
            this.Controls.Add(this.lbErrorPag);
            this.Controls.Add(this.lbPag);
            this.Controls.Add(this.txtPag);
            this.Controls.Add(this.lbNumeros);
            this.Controls.Add(this.lbErrorVolume);
            this.Controls.Add(this.lbErrorEdicao);
            this.Controls.Add(this.lbEdicao);
            this.Controls.Add(this.txtEdicao);
            this.Controls.Add(this.lbVolume);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.lbEditoraError);
            this.Controls.Add(this.lbLocalError);
            this.Controls.Add(this.lbObraError);
            this.Controls.Add(this.lbAutorError);
            this.Controls.Add(this.lbClose);
            this.Controls.Add(this.dtpAno);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbAutores);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroObra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroObra";
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbAutores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dtpAno;
        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.Label lbAutorError;
        private System.Windows.Forms.Label lbObraError;
        private System.Windows.Forms.Label lbLocalError;
        private System.Windows.Forms.Label lbEditoraError;
        private System.Windows.Forms.Label lbVolume;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label lbEdicao;
        private System.Windows.Forms.TextBox txtEdicao;
        private System.Windows.Forms.Label lbErrorEdicao;
        private System.Windows.Forms.Label lbErrorVolume;
        private System.Windows.Forms.Label lbNumeros;
        private System.Windows.Forms.BindingSource autorBindingSource;
        private System.Windows.Forms.Label lbErrorPag;
        private System.Windows.Forms.Label lbPag;
        private System.Windows.Forms.TextBox txtPag;
    }
}