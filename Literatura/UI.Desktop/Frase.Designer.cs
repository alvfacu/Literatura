namespace UI.Desktop
{
    partial class Frase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frase));
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbLibros = new System.Windows.Forms.ComboBox();
            this.cmbAutores = new System.Windows.Forms.ComboBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(20, 26);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(20, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(30, 13);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Libro";
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(19, 28);
            this.txtFrase.MaxLength = 1000;
            this.txtFrase.Multiline = true;
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFrase.Size = new System.Drawing.Size(376, 185);
            this.txtFrase.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbLibros);
            this.groupBox1.Controls.Add(this.cmbAutores);
            this.groupBox1.Controls.Add(this.lblAutor);
            this.groupBox1.Controls.Add(this.lblTitulo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 85);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // cmbLibros
            // 
            this.cmbLibros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLibros.FormattingEnabled = true;
            this.cmbLibros.Location = new System.Drawing.Point(59, 51);
            this.cmbLibros.Name = "cmbLibros";
            this.cmbLibros.Size = new System.Drawing.Size(246, 21);
            this.cmbLibros.TabIndex = 4;
            // 
            // cmbAutores
            // 
            this.cmbAutores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutores.FormattingEnabled = true;
            this.cmbAutores.Location = new System.Drawing.Point(59, 23);
            this.cmbAutores.Name = "cmbAutores";
            this.cmbAutores.Size = new System.Drawing.Size(169, 21);
            this.cmbAutores.TabIndex = 3;
            this.cmbAutores.SelectedIndexChanged += new System.EventHandler(this.cmbAutores_SelectedIndexChanged);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(348, 28);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 5;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFrase);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 232);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Frase";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(348, 55);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 8;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Frase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(435, 347);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frase";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbLibros;
        private System.Windows.Forms.ComboBox cmbAutores;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}