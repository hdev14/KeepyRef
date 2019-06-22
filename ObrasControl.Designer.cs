namespace Citador
{
    partial class ObrasControl
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObrasControl));
            this.lvObra = new System.Windows.Forms.ListView();
            this.titulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.local = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ano_pub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.btnObraEdit = new System.Windows.Forms.Button();
            this.btnObraAdd = new System.Windows.Forms.Button();
            this.btnObraDel = new System.Windows.Forms.Button();
            this.lbObraSelecionado = new System.Windows.Forms.Label();
            this.volume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.edicao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvObra
            // 
            this.lvObra.BackColor = System.Drawing.Color.White;
            this.lvObra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvObra.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titulo,
            this.editora,
            this.local,
            this.ano_pub,
            this.volume,
            this.edicao});
            this.lvObra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvObra.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvObra.FullRowSelect = true;
            this.lvObra.GridLines = true;
            this.lvObra.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvObra.HideSelection = false;
            this.lvObra.HoverSelection = true;
            this.lvObra.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvObra.Location = new System.Drawing.Point(52, 150);
            this.lvObra.Name = "lvObra";
            this.lvObra.Size = new System.Drawing.Size(600, 369);
            this.lvObra.TabIndex = 5;
            this.lvObra.UseCompatibleStateImageBehavior = false;
            this.lvObra.View = System.Windows.Forms.View.Details;
            this.lvObra.SelectedIndexChanged += new System.EventHandler(this.LvObra_SelectedIndexChanged);
            // 
            // titulo
            // 
            this.titulo.Text = "TITULO";
            this.titulo.Width = 200;
            // 
            // editora
            // 
            this.editora.Text = "EDITORA";
            this.editora.Width = 120;
            // 
            // local
            // 
            this.local.Text = "LOCAL PUB.";
            this.local.Width = 100;
            // 
            // ano_pub
            // 
            this.ano_pub.Text = "ANO PUB.";
            this.ano_pub.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.label2.Location = new System.Drawing.Point(41, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Obras dos Autores";
            // 
            // btnObraEdit
            // 
            this.btnObraEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(202)))), ((int)(((byte)(85)))));
            this.btnObraEdit.FlatAppearance.BorderSize = 0;
            this.btnObraEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObraEdit.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObraEdit.ForeColor = System.Drawing.Color.White;
            this.btnObraEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnObraEdit.Image")));
            this.btnObraEdit.Location = new System.Drawing.Point(581, 115);
            this.btnObraEdit.Name = "btnObraEdit";
            this.btnObraEdit.Size = new System.Drawing.Size(32, 30);
            this.btnObraEdit.TabIndex = 9;
            this.btnObraEdit.UseVisualStyleBackColor = false;
            this.btnObraEdit.Click += new System.EventHandler(this.BtnObraEdit_Click);
            // 
            // btnObraAdd
            // 
            this.btnObraAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(193)))), ((int)(((byte)(108)))));
            this.btnObraAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnObraAdd.FlatAppearance.BorderSize = 0;
            this.btnObraAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObraAdd.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObraAdd.ForeColor = System.Drawing.Color.White;
            this.btnObraAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnObraAdd.Image")));
            this.btnObraAdd.Location = new System.Drawing.Point(543, 115);
            this.btnObraAdd.Name = "btnObraAdd";
            this.btnObraAdd.Size = new System.Drawing.Size(32, 30);
            this.btnObraAdd.TabIndex = 10;
            this.btnObraAdd.UseVisualStyleBackColor = false;
            this.btnObraAdd.Click += new System.EventHandler(this.BtnObraAdd_Click);
            // 
            // btnObraDel
            // 
            this.btnObraDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.btnObraDel.FlatAppearance.BorderSize = 0;
            this.btnObraDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObraDel.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObraDel.ForeColor = System.Drawing.Color.White;
            this.btnObraDel.Image = ((System.Drawing.Image)(resources.GetObject("btnObraDel.Image")));
            this.btnObraDel.Location = new System.Drawing.Point(619, 115);
            this.btnObraDel.Name = "btnObraDel";
            this.btnObraDel.Size = new System.Drawing.Size(32, 30);
            this.btnObraDel.TabIndex = 11;
            this.btnObraDel.UseVisualStyleBackColor = false;
            this.btnObraDel.Click += new System.EventHandler(this.BtnObraDel_Click);
            // 
            // lbObraSelecionado
            // 
            this.lbObraSelecionado.AutoSize = true;
            this.lbObraSelecionado.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObraSelecionado.ForeColor = System.Drawing.Color.IndianRed;
            this.lbObraSelecionado.Location = new System.Drawing.Point(62, 124);
            this.lbObraSelecionado.Name = "lbObraSelecionado";
            this.lbObraSelecionado.Size = new System.Drawing.Size(0, 15);
            this.lbObraSelecionado.TabIndex = 13;
            // 
            // volume
            // 
            this.volume.Text = "Vol.";
            this.volume.Width = 50;
            // 
            // edicao
            // 
            this.edicao.Text = "Ed.";
            this.edicao.Width = 50;
            // 
            // ObrasControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbObraSelecionado);
            this.Controls.Add(this.btnObraEdit);
            this.Controls.Add(this.btnObraAdd);
            this.Controls.Add(this.btnObraDel);
            this.Controls.Add(this.lvObra);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ObrasControl";
            this.Size = new System.Drawing.Size(700, 554);
            this.Load += new System.EventHandler(this.ObrasControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvObra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnObraEdit;
        private System.Windows.Forms.Button btnObraAdd;
        private System.Windows.Forms.Button btnObraDel;
        private System.Windows.Forms.ColumnHeader titulo;
        private System.Windows.Forms.ColumnHeader editora;
        private System.Windows.Forms.ColumnHeader local;
        private System.Windows.Forms.ColumnHeader ano_pub;
        private System.Windows.Forms.Label lbObraSelecionado;
        private System.Windows.Forms.ColumnHeader volume;
        private System.Windows.Forms.ColumnHeader edicao;
    }
}
