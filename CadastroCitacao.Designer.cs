namespace Citador
{
    partial class CadastroCitacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCitacao));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCitacao = new System.Windows.Forms.RichTextBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbClose = new System.Windows.Forms.Label();
            this.lbObraError = new System.Windows.Forms.Label();
            this.lbCitacaoError = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbObras = new System.Windows.Forms.ComboBox();
            this.obraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(119, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Crie sua Citação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.label2.Location = new System.Drawing.Point(31, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Escreva sua citação aqui:";
            // 
            // txtCitacao
            // 
            this.txtCitacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCitacao.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCitacao.Location = new System.Drawing.Point(31, 196);
            this.txtCitacao.Name = "txtCitacao";
            this.txtCitacao.Size = new System.Drawing.Size(295, 154);
            this.txtCitacao.TabIndex = 2;
            this.txtCitacao.Text = "";
            this.txtCitacao.Click += new System.EventHandler(this.TxtCitacao_Click);
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.btnCriar.FlatAppearance.BorderSize = 0;
            this.btnCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriar.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnCriar.ForeColor = System.Drawing.Color.White;
            this.btnCriar.Location = new System.Drawing.Point(34, 381);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(96, 29);
            this.btnCriar.TabIndex = 23;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.BtnCriar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(272, 407);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 62);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 73);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // lbClose
            // 
            this.lbClose.AutoSize = true;
            this.lbClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lbClose.ForeColor = System.Drawing.Color.DimGray;
            this.lbClose.Location = new System.Drawing.Point(331, 0);
            this.lbClose.Name = "lbClose";
            this.lbClose.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.lbClose.Size = new System.Drawing.Size(42, 40);
            this.lbClose.TabIndex = 29;
            this.lbClose.Text = "X";
            this.lbClose.Click += new System.EventHandler(this.LbClose_Click);
            // 
            // lbObraError
            // 
            this.lbObraError.AutoSize = true;
            this.lbObraError.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObraError.ForeColor = System.Drawing.Color.IndianRed;
            this.lbObraError.Location = new System.Drawing.Point(38, 160);
            this.lbObraError.Name = "lbObraError";
            this.lbObraError.Size = new System.Drawing.Size(0, 12);
            this.lbObraError.TabIndex = 31;
            // 
            // lbCitacaoError
            // 
            this.lbCitacaoError.AutoSize = true;
            this.lbCitacaoError.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCitacaoError.ForeColor = System.Drawing.Color.IndianRed;
            this.lbCitacaoError.Location = new System.Drawing.Point(38, 353);
            this.lbCitacaoError.Name = "lbCitacaoError";
            this.lbCitacaoError.Size = new System.Drawing.Size(0, 12);
            this.lbCitacaoError.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.label6.Location = new System.Drawing.Point(34, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Escolha a obra:";
            // 
            // cbObras
            // 
            this.cbObras.DataSource = this.obraBindingSource;
            this.cbObras.DisplayMember = "titulo";
            this.cbObras.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbObras.FormattingEnabled = true;
            this.cbObras.Location = new System.Drawing.Point(34, 134);
            this.cbObras.Name = "cbObras";
            this.cbObras.Size = new System.Drawing.Size(208, 23);
            this.cbObras.TabIndex = 1;
            this.cbObras.ValueMember = "id";
            this.cbObras.Click += new System.EventHandler(this.CbObras_Click);
            // 
            // obraBindingSource
            // 
            this.obraBindingSource.DataSource = typeof(Citador.modelo.obra);
            // 
            // CadastroCitacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 467);
            this.Controls.Add(this.lbCitacaoError);
            this.Controls.Add(this.lbObraError);
            this.Controls.Add(this.lbClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.txtCitacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbObras);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroCitacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarCitacao";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtCitacao;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.Label lbObraError;
        private System.Windows.Forms.Label lbCitacaoError;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbObras;
        private System.Windows.Forms.BindingSource obraBindingSource;
    }
}