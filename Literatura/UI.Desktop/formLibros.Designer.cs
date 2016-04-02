namespace UI.Desktop
{
    partial class formLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLibros));
            this.dvg_Libros = new System.Windows.Forms.DataGridView();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Libros)).BeginInit();
            this.SuspendLayout();
            // 
            // dvg_Libros
            // 
            this.dvg_Libros.AllowUserToAddRows = false;
            this.dvg_Libros.AllowUserToDeleteRows = false;
            this.dvg_Libros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_Libros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titulo,
            this.autor});
            this.dvg_Libros.Location = new System.Drawing.Point(12, 12);
            this.dvg_Libros.Name = "dvg_Libros";
            this.dvg_Libros.ReadOnly = true;
            this.dvg_Libros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvg_Libros.Size = new System.Drawing.Size(557, 288);
            this.dvg_Libros.TabIndex = 0;
            // 
            // titulo
            // 
            this.titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titulo.DataPropertyName = "Libro";
            this.titulo.HeaderText = "Nombre del libro";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            this.titulo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // autor
            // 
            this.autor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.autor.DataPropertyName = "Autor";
            this.autor.HeaderText = "Autor";
            this.autor.Name = "autor";
            this.autor.ReadOnly = true;
            this.autor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // formLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(581, 312);
            this.Controls.Add(this.dvg_Libros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libros";
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Libros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvg_Libros;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
    }
}