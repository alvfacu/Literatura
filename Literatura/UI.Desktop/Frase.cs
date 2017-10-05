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
    public partial class Frase : Form
    {
        private Frases _frActual;
        private Entidades.Entidades.States _modo;
        private List<Autores> autores;
        private List<Libros> libros;
        private bool bnd = true;

        public Entidades.Entidades.States Modo
        {
            get { return _modo; }
            set { _modo = value; }
        }

        public Frases FrActual
        {
            get { return _frActual; }
            set { _frActual = value; }
        }

        public Frase()
        {

        }

        public Frase(int ID)
        {
            InitializeComponent();
            CargarListas();
            FrActual = new FraseLogic().GetOne(ID,Program.IdUsuario);
            this.txtFrase.Text = FrActual.Frase;
            this.cmbAutores.SelectedValue = new LibroLogic().GetOne(FrActual.IdLibro, FrActual.IdUsuario).IdAutor;
            this.cmbLibros.SelectedValue = FrActual.IdLibro;
        }

        public Frase(int ID, Entidades.Entidades.States estado)
        {
            InitializeComponent();
            CargarListas();
            Modo = estado;
            if (ID != 0)
            {
                FrActual = new FraseLogic().GetOne(ID,Program.IdUsuario);
            }
            switch (Modo)
            {
                case (Entidades.Entidades.States.Modified):
                    {
                        RellenarFormulario();
                        break;
                    }
                default: break;
            }
        }

        private void RellenarFormulario()
        {
            this.cmbAutores.SelectedValue = new LibroLogic().GetOne(FrActual.IdLibro, FrActual.IdUsuario).IdAutor;
            this.cmbLibros.SelectedValue = FrActual.IdLibro;
            this.txtFrase.Text = FrActual.Frase;
            this.txtPag.Text = FrActual.Pag.ToString();
        }

        private void CargarListas()
        {
            autores = new AutorLogic().GetAll(Program.IdUsuario);
            this.cmbAutores.DataSource = autores;
            this.cmbAutores.DisplayMember = "apynom";
            this.cmbAutores.ValueMember = "idAutor";
            this.cmbAutores.SelectedIndex = -1;

            libros = new LibroLogic().GetAll(Program.IdUsuario);
            this.cmbLibros.DataSource = libros;
            this.cmbLibros.DisplayMember = "titulo";
            this.cmbLibros.ValueMember = "idLibro";
            this.cmbLibros.SelectedIndex = -1;
        }
        
        private void btn_Aceptar_Click(object sender, EventArgs e)
        { 
            if (Validar())
            {
                switch (Modo)
                {
                    case (Entidades.Entidades.States.New):
                        {
                            FrActual = new Frases();
                            FrActual.IdLibro = Convert.ToInt32(cmbLibros.SelectedValue);
                            FrActual.Frase = txtFrase.Text;
                            FrActual.IdUsuario = Program.IdUsuario;
                            FrActual.State = Modo;
                            FrActual.Pag = 0;
                            if (!string.IsNullOrEmpty(txtPag.Text))
                                FrActual.Pag = Convert.ToInt32(txtPag.Text);
                            new FraseLogic().Save(FrActual);
                            break;
                        }
                    case (Entidades.Entidades.States.Modified):
                        {
                            FrActual.IdLibro = Convert.ToInt32(cmbLibros.SelectedValue);
                            FrActual.Frase = this.txtFrase.Text;
                            FrActual.State = Modo;
                            FrActual.Pag = 0;
                            if (!string.IsNullOrEmpty(txtPag.Text))
                                FrActual.Pag = Convert.ToInt32(txtPag.Text);
                            new FraseLogic().Update(FrActual);
                            break;
                        }
                    default: break;
                }
                this.Dispose();
                this.Close();
            }           
        }

        private bool Validar()
        {
            if (cmbAutores.SelectedIndex==-1)
            {
                MessageBox.Show("¡Seleccione Autor!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (cmbLibros.SelectedIndex == -1)
            {
                MessageBox.Show("¡Seleccione Libro!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if(string.IsNullOrEmpty(txtFrase.Text))
            {
                MessageBox.Show("¡Falta Frase!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            int nro;
            if (!string.IsNullOrEmpty(txtPag.Text) && !int.TryParse(txtPag.Text, out nro))
            {
                MessageBox.Show("¡El nro de página posee formato incorrecto!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbAutores_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (bnd)
            {
                this.cmbLibros.DataSource = new LibroLogic().GetAllXAutor(Convert.ToInt32(cmbAutores.SelectedValue), Program.IdUsuario);
                this.cmbLibros.ValueMember = "idLibro";
                this.cmbLibros.DisplayMember = "titulo";
                this.cmbLibros.SelectedIndex = -1;
            }
            else
            {
                bnd = true;
            }
        }

        private void cmbLibros_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (Libros lib in libros)
            {
                if (lib.IdLibro == Convert.ToInt32(cmbLibros.SelectedValue))
                {
                    bnd = false;
                    this.cmbAutores.SelectedValue = lib.IdAutor;
                }
            }
        }

        private void txtFrase_TextChanged(object sender, EventArgs e)
        {
            lblContador.Text = txtFrase.Text.Length.ToString() + "/" + txtFrase.MaxLength;
            lblContador.Refresh();
        }
    }
}