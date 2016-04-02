namespace UI.Desktop
{
    partial class formFrases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFrases));
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.dgv_Frases = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbLibros = new System.Windows.Forms.ComboBox();
            this.cmbAutores = new System.Windows.Forms.ComboBox();
            this.chk_libro = new System.Windows.Forms.CheckBox();
            this.chk_autor = new System.Windows.Forms.CheckBox();
            this.btn_Ver = new System.Windows.Forms.Button();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Frases)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(595, 32);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(94, 23);
            this.btn_actualizar.TabIndex = 0;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // dgv_Frases
            // 
            this.dgv_Frases.AllowUserToAddRows = false;
            this.dgv_Frases.AllowUserToDeleteRows = false;
            this.dgv_Frases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Frases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Autor,
            this.Libro,
            this.Frase});
            this.dgv_Frases.Location = new System.Drawing.Point(13, 83);
            this.dgv_Frases.Name = "dgv_Frases";
            this.dgv_Frases.ReadOnly = true;
            this.dgv_Frases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Frases.Size = new System.Drawing.Size(716, 266);
            this.dgv_Frases.TabIndex = 1;
            this.dgv_Frases.SelectionChanged += new System.EventHandler(this.dgv_Frases_SelectionChanged);
            this.dgv_Frases.DoubleClick += new System.EventHandler(this.dgv_Frases_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbLibros);
            this.groupBox1.Controls.Add(this.cmbAutores);
            this.groupBox1.Controls.Add(this.chk_libro);
            this.groupBox1.Controls.Add(this.chk_autor);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // cmbLibros
            // 
            this.cmbLibros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLibros.FormattingEnabled = true;
            this.cmbLibros.Location = new System.Drawing.Point(97, 40);
            this.cmbLibros.Name = "cmbLibros";
            this.cmbLibros.Size = new System.Drawing.Size(269, 21);
            this.cmbLibros.TabIndex = 3;
            this.cmbLibros.SelectedIndexChanged += new System.EventHandler(this.cmbLibros_SelectedIndexChanged);
            // 
            // cmbAutores
            // 
            this.cmbAutores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutores.FormattingEnabled = true;
            this.cmbAutores.Location = new System.Drawing.Point(97, 16);
            this.cmbAutores.Name = "cmbAutores";
            this.cmbAutores.Size = new System.Drawing.Size(205, 21);
            this.cmbAutores.TabIndex = 2;
            this.cmbAutores.SelectedIndexChanged += new System.EventHandler(this.cmbAutores_SelectedIndexChanged);
            // 
            // chk_libro
            // 
            this.chk_libro.AutoSize = true;
            this.chk_libro.Location = new System.Drawing.Point(22, 42);
            this.chk_libro.Name = "chk_libro";
            this.chk_libro.Size = new System.Drawing.Size(68, 17);
            this.chk_libro.TabIndex = 1;
            this.chk_libro.Text = "Por Libro";
            this.chk_libro.UseVisualStyleBackColor = true;
            this.chk_libro.CheckedChanged += new System.EventHandler(this.chk_libro_CheckedChanged);
            // 
            // chk_autor
            // 
            this.chk_autor.AutoSize = true;
            this.chk_autor.Location = new System.Drawing.Point(22, 20);
            this.chk_autor.Name = "chk_autor";
            this.chk_autor.Size = new System.Drawing.Size(69, 17);
            this.chk_autor.TabIndex = 0;
            this.chk_autor.Text = "Por autor";
            this.chk_autor.UseVisualStyleBackColor = true;
            this.chk_autor.CheckedChanged += new System.EventHandler(this.chk_autor_CheckedChanged);
            // 
            // btn_Ver
            // 
            this.btn_Ver.Location = new System.Drawing.Point(509, 32);
            this.btn_Ver.Name = "btn_Ver";
            this.btn_Ver.Size = new System.Drawing.Size(55, 23);
            this.btn_Ver.TabIndex = 3;
            this.btn_Ver.Text = "Editar";
            this.btn_Ver.UseVisualStyleBackColor = true;
            this.btn_Ver.Click += new System.EventHandler(this.btn_Ver_Click);
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "Autor";
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Libro
            // 
            this.Libro.DataPropertyName = "Libro";
            this.Libro.HeaderText = "Libro";
            this.Libro.Name = "Libro";
            this.Libro.ReadOnly = true;
            this.Libro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Frase
            // 
            this.Frase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Frase.DataPropertyName = "Fragmento";
            this.Frase.HeaderText = "Frase";
            this.Frase.Name = "Frase";
            this.Frase.ReadOnly = true;
            this.Frase.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // formFrases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(741, 361);
            this.Controls.Add(this.btn_Ver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_Frases);
            this.Controls.Add(this.btn_actualizar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formFrases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frases";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Frases)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.DataGridView dgv_Frases;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbLibros;
        private System.Windows.Forms.ComboBox cmbAutores;
        private System.Windows.Forms.CheckBox chk_libro;
        private System.Windows.Forms.CheckBox chk_autor;
        private System.Windows.Forms.Button btn_Ver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frase;
    }
}