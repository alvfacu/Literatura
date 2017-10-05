namespace UI.Desktop
{
    partial class formAutores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAutores));
            this.dgv_Autores = new System.Windows.Forms.DataGridView();
            this.apynom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnLibros = new System.Windows.Forms.Button();
            this.btnNO = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Autores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Autores
            // 
            this.dgv_Autores.AllowUserToAddRows = false;
            this.dgv_Autores.AllowUserToDeleteRows = false;
            this.dgv_Autores.AllowUserToOrderColumns = true;
            this.dgv_Autores.AllowUserToResizeRows = false;
            this.dgv_Autores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Autores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apynom,
            this.idAutor});
            this.dgv_Autores.Location = new System.Drawing.Point(13, 13);
            this.dgv_Autores.MultiSelect = false;
            this.dgv_Autores.Name = "dgv_Autores";
            this.dgv_Autores.ReadOnly = true;
            this.dgv_Autores.RowHeadersVisible = false;
            this.dgv_Autores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Autores.Size = new System.Drawing.Size(468, 270);
            this.dgv_Autores.TabIndex = 0;
            this.dgv_Autores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Autores_CellDoubleClick);
            // 
            // apynom
            // 
            this.apynom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apynom.DataPropertyName = "ApyNom";
            this.apynom.HeaderText = "Apellido y Nombre";
            this.apynom.Name = "apynom";
            this.apynom.ReadOnly = true;
            this.apynom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // idAutor
            // 
            this.idAutor.DataPropertyName = "IdAutor";
            this.idAutor.HeaderText = "";
            this.idAutor.Name = "idAutor";
            this.idAutor.ReadOnly = true;
            this.idAutor.Visible = false;
            // 
            // btnLibros
            // 
            this.btnLibros.Image = global::UI.Desktop.Properties.Resources.books_icon;
            this.btnLibros.Location = new System.Drawing.Point(487, 13);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(40, 35);
            this.btnLibros.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnLibros, "Ver Libros");
            this.btnLibros.UseVisualStyleBackColor = true;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // btnNO
            // 
            this.btnNO.Image = global::UI.Desktop.Properties.Resources.Actions_edit_delete_icon;
            this.btnNO.Location = new System.Drawing.Point(487, 55);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(40, 35);
            this.btnNO.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnNO, "Cerrar");
            this.btnNO.UseVisualStyleBackColor = true;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // formAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(535, 295);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.btnLibros);
            this.Controls.Add(this.dgv_Autores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autores cargados";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Autores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Autores;
        private System.Windows.Forms.DataGridViewTextBoxColumn apynom;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAutor;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnLibros;
        private System.Windows.Forms.Button btnNO;
    }
}