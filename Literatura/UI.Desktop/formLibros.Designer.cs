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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLibros));
            this.dgv_Libros = new System.Windows.Forms.DataGridView();
            this.btnVerFrases = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Libros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Libros
            // 
            this.dgv_Libros.AllowUserToAddRows = false;
            this.dgv_Libros.AllowUserToDeleteRows = false;
            this.dgv_Libros.AllowUserToResizeRows = false;
            this.dgv_Libros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Libros.Location = new System.Drawing.Point(12, 12);
            this.dgv_Libros.Name = "dgv_Libros";
            this.dgv_Libros.ReadOnly = true;
            this.dgv_Libros.RowHeadersVisible = false;
            this.dgv_Libros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Libros.Size = new System.Drawing.Size(503, 288);
            this.dgv_Libros.TabIndex = 0;
            this.dgv_Libros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_Libros_CellDoubleClick);
            // 
            // btnVerFrases
            // 
            this.btnVerFrases.Image = ((System.Drawing.Image)(resources.GetObject("btnVerFrases.Image")));
            this.btnVerFrases.Location = new System.Drawing.Point(521, 12);
            this.btnVerFrases.Name = "btnVerFrases";
            this.btnVerFrases.Size = new System.Drawing.Size(40, 35);
            this.btnVerFrases.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnVerFrases, "Ver Frases");
            this.btnVerFrases.UseVisualStyleBackColor = true;
            this.btnVerFrases.Click += new System.EventHandler(this.btnVerFrases_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::UI.Desktop.Properties.Resources.Actions_edit_delete_icon;
            this.btnCerrar.Location = new System.Drawing.Point(522, 54);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 35);
            this.btnCerrar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnCerrar, "Cerrar");
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // formLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(571, 312);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnVerFrases);
            this.Controls.Add(this.dgv_Libros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libros cargados";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Libros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Libros;
        private System.Windows.Forms.Button btnVerFrases;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCerrar;
    }
}