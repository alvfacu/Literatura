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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAutores));
            this.dgv_Autores = new System.Windows.Forms.DataGridView();
            this.apenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Autores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Autores
            // 
            this.dgv_Autores.AllowUserToAddRows = false;
            this.dgv_Autores.AllowUserToDeleteRows = false;
            this.dgv_Autores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Autores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apenom});
            this.dgv_Autores.Location = new System.Drawing.Point(13, 13);
            this.dgv_Autores.Name = "dgv_Autores";
            this.dgv_Autores.ReadOnly = true;
            this.dgv_Autores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Autores.Size = new System.Drawing.Size(468, 270);
            this.dgv_Autores.TabIndex = 0;
            // 
            // apenom
            // 
            this.apenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apenom.DataPropertyName = "Completo";
            this.apenom.HeaderText = "Nombre y Apellido";
            this.apenom.Name = "apenom";
            this.apenom.ReadOnly = true;
            this.apenom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // formAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(493, 295);
            this.Controls.Add(this.dgv_Autores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autores";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Autores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Autores;
        private System.Windows.Forms.DataGridViewTextBoxColumn apenom;
    }
}