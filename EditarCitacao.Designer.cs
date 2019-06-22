namespace Citador
{
    partial class EditarCitacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarCitacao));
            this.lbCitacaoError = new System.Windows.Forms.Label();
            this.lbObraError = new System.Windows.Forms.Label();
            this.lbClose = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtCitacao = new System.Windows.Forms.RichTextBox();
            this.lbCitacao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCitacaoError
            // 
            this.lbCitacaoError.AutoSize = true;
            this.lbCitacaoError.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCitacaoError.ForeColor = System.Drawing.Color.IndianRed;
            this.lbCitacaoError.Location = new System.Drawing.Point(42, 325);
            this.lbCitacaoError.Name = "lbCitacaoError";
            this.lbCitacaoError.Size = new System.Drawing.Size(0, 12);
            this.lbCitacaoError.TabIndex = 43;
            // 
            // lbObraError
            // 
            this.lbObraError.AutoSize = true;
            this.lbObraError.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObraError.ForeColor = System.Drawing.Color.IndianRed;
            this.lbObraError.Location = new System.Drawing.Point(42, 119);
            this.lbObraError.Name = "lbObraError";
            this.lbObraError.Size = new System.Drawing.Size(0, 12);
            this.lbObraError.TabIndex = 42;
            // 
            // lbClose
            // 
            this.lbClose.AutoSize = true;
            this.lbClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lbClose.ForeColor = System.Drawing.Color.DimGray;
            this.lbClose.Location = new System.Drawing.Point(331, -1);
            this.lbClose.Name = "lbClose";
            this.lbClose.Padding = new System.Windows.Forms.Padding(10);
            this.lbClose.Size = new System.Drawing.Size(42, 42);
            this.lbClose.TabIndex = 41;
            this.lbClose.Text = "X";
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 79);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(272, 440);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 67);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(35, 414);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(96, 31);
            this.btnEditar.TabIndex = 38;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // txtCitacao
            // 
            this.txtCitacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCitacao.Location = new System.Drawing.Point(35, 155);
            this.txtCitacao.Name = "txtCitacao";
            this.txtCitacao.Size = new System.Drawing.Size(295, 167);
            this.txtCitacao.TabIndex = 34;
            this.txtCitacao.Text = "";
            // 
            // lbCitacao
            // 
            this.lbCitacao.AutoSize = true;
            this.lbCitacao.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCitacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.lbCitacao.Location = new System.Drawing.Point(35, 136);
            this.lbCitacao.Name = "lbCitacao";
            this.lbCitacao.Size = new System.Drawing.Size(158, 16);
            this.lbCitacao.TabIndex = 37;
            this.lbCitacao.Text = "Escreva sua citação aqui:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(115, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Edite sua Citação";
            // 
            // EditarCitacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 506);
            this.Controls.Add(this.lbCitacaoError);
            this.Controls.Add(this.lbObraError);
            this.Controls.Add(this.lbClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtCitacao);
            this.Controls.Add(this.lbCitacao);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarCitacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarCitacao";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCitacaoError;
        private System.Windows.Forms.Label lbObraError;
        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.RichTextBox txtCitacao;
        private System.Windows.Forms.Label lbCitacao;
        private System.Windows.Forms.Label label1;
    }
}