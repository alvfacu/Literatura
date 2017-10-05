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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frase));
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.txtPag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.cmbLibros = new System.Windows.Forms.ComboBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.cmbAutores = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(16, 24);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(35, 13);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(16, 52);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Libro:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblContador);
            this.groupBox1.Controls.Add(this.txtPag);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFrase);
            this.groupBox1.Controls.Add(this.btn_Cancelar);
            this.groupBox1.Controls.Add(this.cmbLibros);
            this.groupBox1.Controls.Add(this.btn_Aceptar);
            this.groupBox1.Controls.Add(this.cmbAutores);
            this.groupBox1.Controls.Add(this.lblAutor);
            this.groupBox1.Controls.Add(this.lblTitulo);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 294);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Frase";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(413, 84);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(36, 13);
            this.lblContador.TabIndex = 13;
            this.lblContador.Text = "0/500";
            // 
            // txtPag
            // 
            this.txtPag.Location = new System.Drawing.Point(444, 261);
            this.txtPag.Name = "txtPag";
            this.txtPag.Size = new System.Drawing.Size(40, 20);
            this.txtPag.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pág.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Frase:";
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(57, 81);
            this.txtFrase.MaxLength = 500;
            this.txtFrase.Multiline = true;
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFrase.Size = new System.Drawing.Size(330, 200);
            this.txtFrase.TabIndex = 3;
            this.txtFrase.TextChanged += new System.EventHandler(this.txtFrase_TextChanged);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Image = global::UI.Desktop.Properties.Resources.Actions_edit_delete_icon;
            this.btn_Cancelar.Location = new System.Drawing.Point(455, 24);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(40, 35);
            this.btn_Cancelar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_Cancelar, "Cancelar");
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // cmbLibros
            // 
            this.cmbLibros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLibros.FormattingEnabled = true;
            this.cmbLibros.Location = new System.Drawing.Point(57, 49);
            this.cmbLibros.Name = "cmbLibros";
            this.cmbLibros.Size = new System.Drawing.Size(330, 21);
            this.cmbLibros.TabIndex = 2;
            this.cmbLibros.SelectionChangeCommitted += new System.EventHandler(this.cmbLibros_SelectionChangeCommitted);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Image = global::UI.Desktop.Properties.Resources.Actions_dialog_ok_apply_icon;
            this.btn_Aceptar.Location = new System.Drawing.Point(409, 24);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(40, 35);
            this.btn_Aceptar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_Aceptar, "Agregar");
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // cmbAutores
            // 
            this.cmbAutores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutores.FormattingEnabled = true;
            this.cmbAutores.Location = new System.Drawing.Point(57, 21);
            this.cmbAutores.Name = "cmbAutores";
            this.cmbAutores.Size = new System.Drawing.Size(330, 21);
            this.cmbAutores.TabIndex = 1;
            this.cmbAutores.SelectionChangeCommitted += new System.EventHandler(this.cmbAutores_SelectionChangeCommitted);
            // 
            // Frase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(537, 314);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Frase";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbLibros;
        private System.Windows.Forms.ComboBox cmbAutores;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.TextBox txtPag;
        private System.Windows.Forms.Label label4;
    }
}