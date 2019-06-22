namespace Citador
{
    partial class AutoresControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoresControl));
            this.label2 = new System.Windows.Forms.Label();
            this.lvAutor = new System.Windows.Forms.ListView();
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sobrenome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAutorEdit = new System.Windows.Forms.Button();
            this.btnAutorAdd = new System.Windows.Forms.Button();
            this.btnAutorDel = new System.Windows.Forms.Button();
            this.lbAutorSelecionado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.label2.Location = new System.Drawing.Point(41, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Meus Autores";
            // 
            // lvAutor
            // 
            this.lvAutor.BackColor = System.Drawing.Color.White;
            this.lvAutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvAutor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nome,
            this.sobrenome});
            this.lvAutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvAutor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAutor.FullRowSelect = true;
            this.lvAutor.GridLines = true;
            this.lvAutor.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAutor.HideSelection = false;
            this.lvAutor.HoverSelection = true;
            this.lvAutor.Location = new System.Drawing.Point(51, 163);
            this.lvAutor.Name = "lvAutor";
            this.lvAutor.Size = new System.Drawing.Size(600, 400);
            this.lvAutor.TabIndex = 2;
            this.lvAutor.UseCompatibleStateImageBehavior = false;
            this.lvAutor.View = System.Windows.Forms.View.Details;
            this.lvAutor.SelectedIndexChanged += new System.EventHandler(this.LvAutor_SelectedIndexChanged);
            // 
            // nome
            // 
            this.nome.Text = "NOME";
            this.nome.Width = 300;
            // 
            // sobrenome
            // 
            this.sobrenome.Text = "SOBRENOME";
            this.sobrenome.Width = 300;
            // 
            // btnAutorEdit
            // 
            this.btnAutorEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(202)))), ((int)(((byte)(85)))));
            this.btnAutorEdit.FlatAppearance.BorderSize = 0;
            this.btnAutorEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutorEdit.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutorEdit.ForeColor = System.Drawing.Color.White;
            this.btnAutorEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnAutorEdit.Image")));
            this.btnAutorEdit.Location = new System.Drawing.Point(581, 125);
            this.btnAutorEdit.Name = "btnAutorEdit";
            this.btnAutorEdit.Size = new System.Drawing.Size(32, 32);
            this.btnAutorEdit.TabIndex = 9;
            this.btnAutorEdit.UseVisualStyleBackColor = false;
            this.btnAutorEdit.Click += new System.EventHandler(this.BtnAutorEdit_Click);
            // 
            // btnAutorAdd
            // 
            this.btnAutorAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(193)))), ((int)(((byte)(108)))));
            this.btnAutorAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAutorAdd.FlatAppearance.BorderSize = 0;
            this.btnAutorAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutorAdd.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutorAdd.ForeColor = System.Drawing.Color.White;
            this.btnAutorAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAutorAdd.Image")));
            this.btnAutorAdd.Location = new System.Drawing.Point(543, 125);
            this.btnAutorAdd.Name = "btnAutorAdd";
            this.btnAutorAdd.Size = new System.Drawing.Size(32, 32);
            this.btnAutorAdd.TabIndex = 10;
            this.btnAutorAdd.UseVisualStyleBackColor = false;
            this.btnAutorAdd.Click += new System.EventHandler(this.BtnAutorAdd_Click);
            // 
            // btnAutorDel
            // 
            this.btnAutorDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.btnAutorDel.FlatAppearance.BorderSize = 0;
            this.btnAutorDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutorDel.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutorDel.ForeColor = System.Drawing.Color.White;
            this.btnAutorDel.Image = ((System.Drawing.Image)(resources.GetObject("btnAutorDel.Image")));
            this.btnAutorDel.Location = new System.Drawing.Point(619, 125);
            this.btnAutorDel.Name = "btnAutorDel";
            this.btnAutorDel.Size = new System.Drawing.Size(32, 32);
            this.btnAutorDel.TabIndex = 11;
            this.btnAutorDel.UseVisualStyleBackColor = false;
            this.btnAutorDel.Click += new System.EventHandler(this.BtnAutorDel_Click);
            // 
            // lbAutorSelecionado
            // 
            this.lbAutorSelecionado.AutoSize = true;
            this.lbAutorSelecionado.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutorSelecionado.ForeColor = System.Drawing.Color.IndianRed;
            this.lbAutorSelecionado.Location = new System.Drawing.Point(59, 142);
            this.lbAutorSelecionado.Name = "lbAutorSelecionado";
            this.lbAutorSelecionado.Size = new System.Drawing.Size(0, 15);
            this.lbAutorSelecionado.TabIndex = 12;
            // 
            // AutoresControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbAutorSelecionado);
            this.Controls.Add(this.btnAutorEdit);
            this.Controls.Add(this.btnAutorAdd);
            this.Controls.Add(this.btnAutorDel);
            this.Controls.Add(this.lvAutor);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AutoresControl";
            this.Size = new System.Drawing.Size(700, 554);
            this.Load += new System.EventHandler(this.AutoresControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvAutor;
        private System.Windows.Forms.Button btnAutorEdit;
        private System.Windows.Forms.Button btnAutorAdd;
        private System.Windows.Forms.Button btnAutorDel;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader sobrenome;
        private System.Windows.Forms.Label lbAutorSelecionado;
    }
}
