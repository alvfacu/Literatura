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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tpsArchivo,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(509, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            this.tsmNuevo.Size = new System.Drawing.Size(116, 22);
            this.tsmNuevo.Text = "Agregar";
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
            this.tsmSalir.Size = new System.Drawing.Size(116, 22);
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
            this.verToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.verToolStripMenuItem.Text = "Ver";
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
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(509, 266);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
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

        private System.Windows.Forms.MenuStrip menuStrip1;
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
    }
}

