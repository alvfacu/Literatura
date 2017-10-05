namespace UI.Desktop
{
    partial class Autor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.txtPag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkFrase = new System.Windows.Forms.CheckBox();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNO = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.chkTitulo = new System.Windows.Forms.CheckBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApeNom = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.btnNO);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.chkTitulo);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtApeNom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Autor";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(477, 80);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(36, 13);
            this.lblContador.TabIndex = 10;
            this.lblContador.Text = "0/500";
            // 
            // txtPag
            // 
            this.txtPag.Enabled = false;
            this.txtPag.Location = new System.Drawing.Point(508, 257);
            this.txtPag.Name = "txtPag";
            this.txtPag.Size = new System.Drawing.Size(40, 20);
            this.txtPag.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pág.:";
            // 
            // chkFrase
            // 
            this.chkFrase.AutoSize = true;
            this.chkFrase.Enabled = false;
            this.chkFrase.Location = new System.Drawing.Point(29, 81);
            this.chkFrase.Name = "chkFrase";
            this.chkFrase.Size = new System.Drawing.Size(15, 14);
            this.chkFrase.TabIndex = 6;
            this.chkFrase.UseVisualStyleBackColor = true;
            this.chkFrase.CheckedChanged += new System.EventHandler(this.chkFrase_CheckedChanged);
            // 
            // txtFrase
            // 
            this.txtFrase.Enabled = false;
            this.txtFrase.Location = new System.Drawing.Point(116, 77);
            this.txtFrase.MaxLength = 500;
            this.txtFrase.Multiline = true;
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFrase.Size = new System.Drawing.Size(330, 200);
            this.txtFrase.TabIndex = 7;
            this.txtFrase.TextChanged += new System.EventHandler(this.txtFrase_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Frase:";
            // 
            // btnNO
            // 
            this.btnNO.Image = global::UI.Desktop.Properties.Resources.Actions_edit_delete_icon;
            this.btnNO.Location = new System.Drawing.Point(519, 27);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(40, 35);
            this.btnNO.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnNO, "Cancelar");
            this.btnNO.UseVisualStyleBackColor = true;
            this.btnNO.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btnOK
            // 
            this.btnOK.Image = global::UI.Desktop.Properties.Resources.Actions_dialog_ok_apply_icon;
            this.btnOK.Location = new System.Drawing.Point(473, 27);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(40, 35);
            this.btnOK.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnOK, "Agregar");
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // chkTitulo
            // 
            this.chkTitulo.AutoSize = true;
            this.chkTitulo.Location = new System.Drawing.Point(29, 51);
            this.chkTitulo.Name = "chkTitulo";
            this.chkTitulo.Size = new System.Drawing.Size(15, 14);
            this.chkTitulo.TabIndex = 4;
            this.chkTitulo.UseVisualStyleBackColor = true;
            this.chkTitulo.CheckedChanged += new System.EventHandler(this.chkTitulo_CheckedChanged);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(116, 48);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(330, 20);
            this.txtTitulo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Título libro:";
            // 
            // txtApeNom
            // 
            this.txtApeNom.Location = new System.Drawing.Point(116, 22);
            this.txtApeNom.Name = "txtApeNom";
            this.txtApeNom.Size = new System.Drawing.Size(330, 20);
            this.txtApeNom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellido y Nombre:";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Guardar";
            // 
            // Autor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(605, 312);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Autor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Autor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApeNom;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnNO;
        private System.Windows.Forms.CheckBox chkTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkFrase;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtPag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblContador;
    }
}