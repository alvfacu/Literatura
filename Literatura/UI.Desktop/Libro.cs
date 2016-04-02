using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace UI.Desktop
{
    public partial class Libro : Form
    {
        private Libros _libroActual;

        public Libros LibroActual
        {
            get { return _libroActual; }
            set { _libroActual = value; }
        }

        public Libro()
        {
            InitializeComponent();
            CargarLista();
        }

        private void CargarLista()
        {
            this.cmbAutores.DataSource = new AutorLogic().GetAll();
            this.cmbAutores.DisplayMember = "completo";
            this.cmbAutores.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            LibroActual = new Libros();
            LibroActual.Libro = this.txtLibro.Text;
            LibroActual.IdAutor = ((Entidades.Autores)this.cmbAutores.SelectedValue).IdAutor;
            LibroActual.State = Entidades.Entidades.States.New;
            new LibroLogic().Save(LibroActual);
            this.Close();
        }
    }
}
