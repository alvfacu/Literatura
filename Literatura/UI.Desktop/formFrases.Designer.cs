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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFrases));
            this.dgv_Frases = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNO = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbLibros = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cmbAutores = new System.Windows.Forms.ComboBox();
            this.chk_libro = new System.Windows.Forms.CheckBox();
            this.chk_autor = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Frases)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Frases
            // 
            this.dgv_Frases.AllowUserToAddRows = false;
            this.dgv_Frases.AllowUserToDeleteRows = false;
            this.dgv_Frases.AllowUserToResizeRows = false;
            this.dgv_Frases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Frases.Location = new System.Drawing.Point(13, 96);
            this.dgv_Frases.Name = "dgv_Frases";
            this.dgv_Frases.ReadOnly = true;
            this.dgv_Frases.RowHeadersVisible = false;
            this.dgv_Frases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Frases.Size = new System.Drawing.Size(716, 253);
            this.dgv_Frases.TabIndex = 1;
            this.dgv_Frases.DoubleClick += new System.EventHandler(this.dgv_Frases_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNO);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.cmbLibros);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.cmbAutores);
            this.groupBox1.Controls.Add(this.chk_libro);
            this.groupBox1.Controls.Add(this.chk_autor);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 78);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros";
            // 
            // btnNO
            // 
            this.btnNO.Image = global::UI.Desktop.Properties.Resources.Actions_edit_delete_icon;
            this.btnNO.Location = new System.Drawing.Point(626, 23);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(40, 35);
            this.btnNO.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnNO, "Salir");
            this.btnNO.UseVisualStyleBackColor = true;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::UI.Desktop.Properties.Resources.Zoom_icon2;
            this.btnBuscar.Location = new System.Drawing.Point(534, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 35);
            this.btnBuscar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbLibros
            // 
            this.cmbLibros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLibros.FormattingEnabled = true;
            this.cmbLibros.Location = new System.Drawing.Point(97, 46);
            this.cmbLibros.Name = "cmbLibros";
            this.cmbLibros.Size = new System.Drawing.Size(360, 21);
            this.cmbLibros.TabIndex = 3;
            this.cmbLibros.SelectionChangeCommitted += new System.EventHandler(this.cmbLibros_SelectionChangeCommitted);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::UI.Desktop.Properties.Resources.edit_icon1;
            this.btnEditar.Location = new System.Drawing.Point(580, 23);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(40, 35);
            this.btnEditar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnEditar, "Ver más/Modificar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btn_Ver_Click);
            // 
            // cmbAutores
            // 
            this.cmbAutores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutores.FormattingEnabled = true;
            this.cmbAutores.Location = new System.Drawing.Point(97, 19);
            this.cmbAutores.Name = "cmbAutores";
            this.cmbAutores.Size = new System.Drawing.Size(360, 21);
            this.cmbAutores.TabIndex = 2;
            this.cmbAutores.SelectionChangeCommitted += new System.EventHandler(this.cmbAutores_SelectionChangeCommitted);
            // 
            // chk_libro
            // 
            this.chk_libro.AutoSize = true;
            this.chk_libro.Location = new System.Drawing.Point(22, 48);
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
            this.chk_autor.Location = new System.Drawing.Point(22, 23);
            this.chk_autor.Name = "chk_autor";
            this.chk_autor.Size = new System.Drawing.Size(69, 17);
            this.chk_autor.TabIndex = 0;
            this.chk_autor.Text = "Por autor";
            this.chk_autor.UseVisualStyleBackColor = true;
            this.chk_autor.CheckedChanged += new System.EventHandler(this.chk_autor_CheckedChanged);
            // 
            // formFrases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(741, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_Frases);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.DataGridView dgv_Frases;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbLibros;
        private System.Windows.Forms.ComboBox cmbAutores;
        private System.Windows.Forms.CheckBox chk_libro;
        private System.Windows.Forms.CheckBox chk_autor;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNO;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}