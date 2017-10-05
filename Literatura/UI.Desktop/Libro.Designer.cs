namespace UI.Desktop
{
    partial class Libro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Libro));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.txtPag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkFrase = new System.Windows.Forms.CheckBox();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAutores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblContador);
            this.groupBox1.Controls.Add(this.txtPag);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkFrase);
            this.groupBox1.Controls.Add(this.txtFrase);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.txtLibro);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbAutores);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Libro";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(455, 80);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(36, 13);
            this.lblContador.TabIndex = 13;
            this.lblContador.Text = "0/500";
            // 
            // txtPag
            // 
            this.txtPag.Enabled = false;
            this.txtPag.Location = new System.Drawing.Point(493, 253);
            this.txtPag.Name = "txtPag";
            this.txtPag.Size = new System.Drawing.Size(40, 20);
            this.txtPag.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pág.:";
            // 
            // chkFrase
            // 
            this.chkFrase.AutoSize = true;
            this.chkFrase.Location = new System.Drawing.Point(23, 80);
            this.chkFrase.Name = "chkFrase";
            this.chkFrase.Size = new System.Drawing.Size(15, 14);
            this.chkFrase.TabIndex = 5;
            this.chkFrase.UseVisualStyleBackColor = true;
            this.chkFrase.CheckedChanged += new System.EventHandler(this.chkFrase_CheckedChanged);
            // 
            // txtFrase
            // 
            this.txtFrase.Enabled = false;
            this.txtFrase.Location = new System.Drawing.Point(84, 77);
            this.txtFrase.MaxLength = 500;
            this.txtFrase.Multiline = true;
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFrase.Size = new System.Drawing.Size(349, 200);
            this.txtFrase.TabIndex = 6;
            this.txtFrase.TextChanged += new System.EventHandler(this.txtFrase_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Frase:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::UI.Desktop.Properties.Resources.Actions_dialog_ok_apply_icon;
            this.btnAceptar.Location = new System.Drawing.Point(458, 23);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(40, 35);
            this.btnAceptar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnAceptar, "Agregar");
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtLibro
            // 
            this.txtLibro.Location = new System.Drawing.Point(84, 47);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(349, 20);
            this.txtLibro.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::UI.Desktop.Properties.Resources.Actions_edit_delete_icon;
            this.btnCancelar.Location = new System.Drawing.Point(504, 23);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 35);
            this.btnCancelar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Titulo libro:";
            // 
            // cmbAutores
            // 
            this.cmbAutores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutores.FormattingEnabled = true;
            this.cmbAutores.Location = new System.Drawing.Point(84, 20);
            this.cmbAutores.Name = "cmbAutores";
            this.cmbAutores.Size = new System.Drawing.Size(349, 21);
            this.cmbAutores.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autor:";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Agregar";
            // 
            // Libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(592, 316);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Libro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Libro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAutores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.CheckBox chkFrase;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.TextBox txtPag;
        private System.Windows.Forms.Label label4;
    }
}