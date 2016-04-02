using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace UI.Desktop
{
    public partial class Autor : Form
    {
        private Autores _autorActual;
        private Libros _libroActual;

        public Autores AutorActual
        {
            get { return _autorActual; }
            set { _autorActual = value; }
        }

        public Libros LibroActual
        {
            get { return _libroActual; }
            set { _libroActual = value; }
        }

        public Autor()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            AutorActual = new Autores();
            LibroActual = new Libros();

            AutorActual.Completo = this.txtNomApe.Text;
            AutorActual.State = Entidades.Entidades.States.New;
            LibroActual.Libro = this.txtTitulo.Text;
            LibroActual.State = Entidades.Entidades.States.New;
            new AutorLogic().Save(AutorActual);
            LibroActual.IdAutor = AutorActual.IdAutor;
            LibroActual.State = Entidades.Entidades.States.New;
            new LibroLogic().Save(LibroActual);

            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
