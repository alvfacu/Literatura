using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autor au = new Autor();
            au.ShowDialog();
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Libro lib = new Libro();
            lib.ShowDialog();
        }

        private void fraseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frase fr = new Frase(0,Entidades.Entidades.States.New);
            fr.ShowDialog();
        }
        
        private void frasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formFrases fr = new formFrases();
            fr.ShowDialog();
        }

        private void librosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formLibros frLibros = new formLibros();
            frLibros.ShowDialog();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAutores frAutores = new formAutores();
            frAutores.ShowDialog();
        }
    }
}
