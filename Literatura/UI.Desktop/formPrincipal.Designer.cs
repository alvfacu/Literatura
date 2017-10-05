namespace UI.Desktop
{
    partial class formPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.tpsArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fraseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.frasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.libroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fraseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frasesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpsArchivo
            // 
            this.tpsArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNuevo,
            this.tsmSalir});
            this.tpsArchivo.Name = "tpsArchivo";
            this.tpsArchivo.Size = new System.Drawing.Size(60, 20);
            this.tpsArchivo.Text = "Archivo";
            // 
            // tsmNuevo
            // 
            this.tsmNuevo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorToolStripMenuItem,
            this.libroToolStripMenuItem,
            this.fraseToolStripMenuItem});
            this.tsmNuevo.Name = "tsmNuevo";
            this.tsmNuevo.Size = new System.Drawing.Size(109, 22);
            this.tsmNuevo.Text = "Nuevo";
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.autorToolStripMenuItem.Text = "Autor...";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // libroToolStripMenuItem
            // 
            this.libroToolStripMenuItem.Name = "libroToolStripMenuItem";
            this.libroToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.libroToolStripMenuItem.Text = "Libro...";
            this.libroToolStripMenuItem.Click += new System.EventHandler(this.libroToolStripMenuItem_Click);
            // 
            // fraseToolStripMenuItem
            // 
            this.fraseToolStripMenuItem.Name = "fraseToolStripMenuItem";
            this.fraseToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.fraseToolStripMenuItem.Text = "Frase...";
            this.fraseToolStripMenuItem.Click += new System.EventHandler(this.fraseToolStripMenuItem_Click);
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(109, 22);
            this.tsmSalir.Text = "Salir";
            this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoresToolStripMenuItem,
            this.librosToolStripMenuItem1,
            this.frasesToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.verToolStripMenuItem.Text = "Consultar";
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.autoresToolStripMenuItem.Text = "Autores";
            this.autoresToolStripMenuItem.Click += new System.EventHandler(this.autoresToolStripMenuItem_Click);
            // 
            // librosToolStripMenuItem1
            // 
            this.librosToolStripMenuItem1.Name = "librosToolStripMenuItem1";
            this.librosToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.librosToolStripMenuItem1.Text = "Libros";
            this.librosToolStripMenuItem1.Click += new System.EventHandler(this.librosToolStripMenuItem1_Click);
            // 
            // frasesToolStripMenuItem
            // 
            this.frasesToolStripMenuItem.Name = "frasesToolStripMenuItem";
            this.frasesToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.frasesToolStripMenuItem.Text = "Frases";
            this.frasesToolStripMenuItem.Click += new System.EventHandler(this.frasesToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.usuarioToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorToolStripMenuItem1,
            this.libroToolStripMenuItem1,
            this.fraseToolStripMenuItem1});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // autorToolStripMenuItem1
            // 
            this.autorToolStripMenuItem1.Name = "autorToolStripMenuItem1";
            this.autorToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.autorToolStripMenuItem1.Text = "Autor...";
            this.autorToolStripMenuItem1.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // libroToolStripMenuItem1
            // 
            this.libroToolStripMenuItem1.Name = "libroToolStripMenuItem1";
            this.libroToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.libroToolStripMenuItem1.Text = "Libro...";
            this.libroToolStripMenuItem1.Click += new System.EventHandler(this.libroToolStripMenuItem_Click);
            // 
            // fraseToolStripMenuItem1
            // 
            this.fraseToolStripMenuItem1.Name = "fraseToolStripMenuItem1";
            this.fraseToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.fraseToolStripMenuItem1.Text = "Frase...";
            this.fraseToolStripMenuItem1.Click += new System.EventHandler(this.fraseToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.tsmSalir_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoresToolStripMenuItem1,
            this.librosToolStripMenuItem,
            this.frasesToolStripMenuItem1});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // autoresToolStripMenuItem1
            // 
            this.autoresToolStripMenuItem1.Name = "autoresToolStripMenuItem1";
            this.autoresToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.autoresToolStripMenuItem1.Text = "Autores";
            this.autoresToolStripMenuItem1.Click += new System.EventHandler(this.autoresToolStripMenuItem_Click);
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.librosToolStripMenuItem.Text = "Libros";
            this.librosToolStripMenuItem.Click += new System.EventHandler(this.librosToolStripMenuItem1_Click);
            // 
            // frasesToolStripMenuItem1
            // 
            this.frasesToolStripMenuItem1.Name = "frasesToolStripMenuItem1";
            this.frasesToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.frasesToolStripMenuItem1.Text = "Frases";
            this.frasesToolStripMenuItem1.Click += new System.EventHandler(this.frasesToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem1
            // 
            this.usuarioToolStripMenuItem1.Name = "usuarioToolStripMenuItem1";
            this.usuarioToolStripMenuItem1.Size = new System.Drawing.Size(65, 21);
            this.usuarioToolStripMenuItem1.Text = "Usuario";
            this.usuarioToolStripMenuItem1.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::UI.Desktop.Properties.Resources._636086969783216903_1953168930_Books_ss_1920;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(674, 327);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Literatura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem tpsArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmNuevo;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.ToolStripMenuItem libroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fraseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem frasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem libroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fraseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frasesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem1;
    }
}

