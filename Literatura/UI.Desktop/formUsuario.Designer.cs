namespace UI.Desktop
{
    partial class formUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUsuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNO = new System.Windows.Forms.Button();
            this.chkModificarPass = new System.Windows.Forms.CheckBox();
            this.grContraseña = new System.Windows.Forms.GroupBox();
            this.btnRePass = new System.Windows.Forms.Button();
            this.btnVerPass = new System.Windows.Forms.Button();
            this.txtReContra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.grContraseña.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNO);
            this.groupBox1.Controls.Add(this.chkModificarPass);
            this.groupBox1.Controls.Add(this.grContraseña);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Usuario";
            // 
            // btnNO
            // 
            this.btnNO.Image = global::UI.Desktop.Properties.Resources.Actions_edit_delete_icon;
            this.btnNO.Location = new System.Drawing.Point(368, 17);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(40, 35);
            this.btnNO.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnNO, "Salir");
            this.btnNO.UseVisualStyleBackColor = true;
            this.btnNO.Visible = false;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // chkModificarPass
            // 
            this.chkModificarPass.AutoSize = true;
            this.chkModificarPass.Location = new System.Drawing.Point(27, 58);
            this.chkModificarPass.Name = "chkModificarPass";
            this.chkModificarPass.Size = new System.Drawing.Size(126, 17);
            this.chkModificarPass.TabIndex = 4;
            this.chkModificarPass.Text = "Modificar Contraseña";
            this.chkModificarPass.UseVisualStyleBackColor = true;
            this.chkModificarPass.CheckedChanged += new System.EventHandler(this.chkModificarPass_CheckedChanged);
            // 
            // grContraseña
            // 
            this.grContraseña.Controls.Add(this.btnRePass);
            this.grContraseña.Controls.Add(this.btnVerPass);
            this.grContraseña.Controls.Add(this.txtReContra);
            this.grContraseña.Controls.Add(this.label3);
            this.grContraseña.Controls.Add(this.txtContra);
            this.grContraseña.Controls.Add(this.label2);
            this.grContraseña.Enabled = false;
            this.grContraseña.Location = new System.Drawing.Point(26, 68);
            this.grContraseña.Name = "grContraseña";
            this.grContraseña.Size = new System.Drawing.Size(382, 85);
            this.grContraseña.TabIndex = 3;
            this.grContraseña.TabStop = false;
            // 
            // btnRePass
            // 
            this.btnRePass.Enabled = false;
            this.btnRePass.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnRePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRePass.Image = global::UI.Desktop.Properties.Resources.eye_icon;
            this.btnRePass.Location = new System.Drawing.Point(310, 46);
            this.btnRePass.Name = "btnRePass";
            this.btnRePass.Size = new System.Drawing.Size(23, 23);
            this.btnRePass.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnRePass, "Ver");
            this.btnRePass.UseVisualStyleBackColor = true;
            this.btnRePass.Click += new System.EventHandler(this.btnRePass_Click);
            // 
            // btnVerPass
            // 
            this.btnVerPass.Enabled = false;
            this.btnVerPass.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnVerPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPass.Image = global::UI.Desktop.Properties.Resources.eye_icon;
            this.btnVerPass.Location = new System.Drawing.Point(310, 20);
            this.btnVerPass.Name = "btnVerPass";
            this.btnVerPass.Size = new System.Drawing.Size(23, 23);
            this.btnVerPass.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnVerPass, "Ver");
            this.btnVerPass.UseVisualStyleBackColor = true;
            this.btnVerPass.Click += new System.EventHandler(this.btnVerPass_Click);
            // 
            // txtReContra
            // 
            this.txtReContra.Enabled = false;
            this.txtReContra.Location = new System.Drawing.Point(152, 48);
            this.txtReContra.Name = "txtReContra";
            this.txtReContra.Size = new System.Drawing.Size(152, 20);
            this.txtReContra.TabIndex = 4;
            this.txtReContra.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Repetir Contraseña:";
            // 
            // txtContra
            // 
            this.txtContra.Enabled = false;
            this.txtContra.Location = new System.Drawing.Point(152, 22);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(152, 20);
            this.txtContra.TabIndex = 1;
            this.txtContra.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nueva Contraseña:";
            // 
            // btnOK
            // 
            this.btnOK.Image = global::UI.Desktop.Properties.Resources.Actions_dialog_ok_apply_icon;
            this.btnOK.Location = new System.Drawing.Point(322, 17);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(40, 35);
            this.btnOK.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnOK, "Aceptar");
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(75, 25);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(170, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // formUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 190);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Usuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grContraseña.ResumeLayout(false);
            this.grContraseña.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkModificarPass;
        private System.Windows.Forms.GroupBox grContraseña;
        private System.Windows.Forms.TextBox txtReContra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNO;
        private System.Windows.Forms.Button btnRePass;
        private System.Windows.Forms.Button btnVerPass;
    }
}