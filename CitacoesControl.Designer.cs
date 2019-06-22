namespace Citador
{
    partial class CitacoesControl
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CitacoesControl));
            this.btnCitacaoEdit = new System.Windows.Forms.Button();
            this.btnCitacaoAdd = new System.Windows.Forms.Button();
            this.btnCitacaoDel = new System.Windows.Forms.Button();
            this.lvCitacao = new System.Windows.Forms.ListView();
            this.citacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lbCitacaoSelecionado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCitacaoEdit
            // 
            this.btnCitacaoEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(202)))), ((int)(((byte)(85)))));
            this.btnCitacaoEdit.FlatAppearance.BorderSize = 0;
            this.btnCitacaoEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitacaoEdit.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitacaoEdit.ForeColor = System.Drawing.Color.White;
            this.btnCitacaoEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnCitacaoEdit.Image")));
            this.btnCitacaoEdit.Location = new System.Drawing.Point(581, 115);
            this.btnCitacaoEdit.Name = "btnCitacaoEdit";
            this.btnCitacaoEdit.Size = new System.Drawing.Size(32, 30);
            this.btnCitacaoEdit.TabIndex = 6;
            this.btnCitacaoEdit.UseVisualStyleBackColor = false;
            this.btnCitacaoEdit.Click += new System.EventHandler(this.btnCitacaoEdit_Click);
            // 
            // btnCitacaoAdd
            // 
            this.btnCitacaoAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(193)))), ((int)(((byte)(108)))));
            this.btnCitacaoAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCitacaoAdd.FlatAppearance.BorderSize = 0;
            this.btnCitacaoAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitacaoAdd.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitacaoAdd.ForeColor = System.Drawing.Color.White;
            this.btnCitacaoAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnCitacaoAdd.Image")));
            this.btnCitacaoAdd.Location = new System.Drawing.Point(543, 115);
            this.btnCitacaoAdd.Name = "btnCitacaoAdd";
            this.btnCitacaoAdd.Size = new System.Drawing.Size(32, 30);
            this.btnCitacaoAdd.TabIndex = 7;
            this.btnCitacaoAdd.UseVisualStyleBackColor = false;
            this.btnCitacaoAdd.Click += new System.EventHandler(this.BtnCitacaoAdd_Click);
            // 
            // btnCitacaoDel
            // 
            this.btnCitacaoDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.btnCitacaoDel.FlatAppearance.BorderSize = 0;
            this.btnCitacaoDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitacaoDel.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitacaoDel.ForeColor = System.Drawing.Color.White;
            this.btnCitacaoDel.Image = ((System.Drawing.Image)(resources.GetObject("btnCitacaoDel.Image")));
            this.btnCitacaoDel.Location = new System.Drawing.Point(619, 115);
            this.btnCitacaoDel.Name = "btnCitacaoDel";
            this.btnCitacaoDel.Size = new System.Drawing.Size(32, 30);
            this.btnCitacaoDel.TabIndex = 8;
            this.btnCitacaoDel.UseVisualStyleBackColor = false;
            this.btnCitacaoDel.Click += new System.EventHandler(this.btnCitacaoDel_Click);
            // 
            // lvCitacao
            // 
            this.lvCitacao.BackColor = System.Drawing.Color.White;
            this.lvCitacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvCitacao.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.citacao});
            this.lvCitacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvCitacao.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCitacao.FullRowSelect = true;
            this.lvCitacao.GridLines = true;
            this.lvCitacao.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCitacao.HideSelection = false;
            this.lvCitacao.HoverSelection = true;
            this.lvCitacao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvCitacao.Location = new System.Drawing.Point(50, 150);
            this.lvCitacao.Name = "lvCitacao";
            this.lvCitacao.Size = new System.Drawing.Size(600, 346);
            this.lvCitacao.TabIndex = 5;
            this.lvCitacao.UseCompatibleStateImageBehavior = false;
            this.lvCitacao.View = System.Windows.Forms.View.Details;
            this.lvCitacao.SelectedIndexChanged += new System.EventHandler(this.LvCitacao_SelectedIndexChanged);
            // 
            // citacao
            // 
            this.citacao.Text = "CITAÇÕES";
            this.citacao.Width = 600;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.label2.Location = new System.Drawing.Point(41, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minhas Citações";
            // 
            // lbCitacaoSelecionado
            // 
            this.lbCitacaoSelecionado.AutoSize = true;
            this.lbCitacaoSelecionado.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCitacaoSelecionado.ForeColor = System.Drawing.Color.IndianRed;
            this.lbCitacaoSelecionado.Location = new System.Drawing.Point(58, 124);
            this.lbCitacaoSelecionado.Name = "lbCitacaoSelecionado";
            this.lbCitacaoSelecionado.Size = new System.Drawing.Size(0, 15);
            this.lbCitacaoSelecionado.TabIndex = 14;
            // 
            // CitacoesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbCitacaoSelecionado);
            this.Controls.Add(this.btnCitacaoEdit);
            this.Controls.Add(this.btnCitacaoAdd);
            this.Controls.Add(this.btnCitacaoDel);
            this.Controls.Add(this.lvCitacao);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CitacoesControl";
            this.Size = new System.Drawing.Size(700, 554);
            this.Load += new System.EventHandler(this.CitacoesControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCitacaoEdit;
        private System.Windows.Forms.Button btnCitacaoAdd;
        private System.Windows.Forms.Button btnCitacaoDel;
        private System.Windows.Forms.ListView lvCitacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader citacao;
        private System.Windows.Forms.Label lbCitacaoSelecionado;
    }
}
