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
            //.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Text = this.Text + " - " + Program.NomUsuario;
        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autor au = new Autor();
            au.ShowDialog();
            au.Close();
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Libro lib = new Libro();
            lib.ShowDialog();
            lib.Close();
        }

        private void fraseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frase fr = new Frase(0,Entidades.Entidades.States.New);
            fr.ShowDialog();
            fr.Close();
        }
        
        private void frasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formFrases fr = new formFrases();
            fr.ShowDialog();
            fr.Close();
        }

        private void librosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formLibros frLibros = new formLibros();
            frLibros.ShowDialog();
            frLibros.Close();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAutores frAutores = new formAutores();
            frAutores.ShowDialog();
            frAutores.Close();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.IdUsuario == 1)
            {
                Usuarios usr = new Usuarios();
                usr.ShowDialog();
                usr.Close();
            }
            else
            {
                formUsuario usr = new formUsuario(Program.IdUsuario,Program.NomUsuario);
                usr.ShowDialog();
                usr.Close();
            }
        }
        
    }
}
