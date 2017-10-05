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
            this.cmbAutores.DataSource = new AutorLogic().GetAll(Program.IdUsuario);
            this.cmbAutores.ValueMember = "idAutor";
            this.cmbAutores.DisplayMember = "apynom";
            this.cmbAutores.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                try
                {
                    LibroActual = new Libros();
                    LibroActual.Titulo = this.txtLibro.Text;
                    LibroActual.IdAutor = Convert.ToInt32(this.cmbAutores.SelectedValue);
                    LibroActual.IdUsuario = Program.IdUsuario;
                    LibroActual.State = Entidades.Entidades.States.New;
                    new LibroLogic().Save(LibroActual);

                    string msj = "¡Libro creado con éxito!";

                    if (chkFrase.Checked)
                    {
                        Frases FraseActual = new Frases();
                        FraseActual.IdLibro = LibroActual.IdLibro;
                        //FraseActual.IdLibro = LibroActual.IdLibro;
                        FraseActual.IdUsuario = LibroActual.IdUsuario;
                        FraseActual.State = Entidades.Entidades.States.New;
                        FraseActual.Frase = txtFrase.Text;
                        FraseActual.Pag = 0;
                        if (!string.IsNullOrEmpty(txtPag.Text))
                            FraseActual.Pag = Convert.ToInt32(txtPag.Text);
                        new FraseLogic().Save(FraseActual);

                        msj = "¡Libro y Frase creados con éxito!";
                    }


                    MessageBox.Show(msj, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Dispose();
                    this.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(cmbAutores.Text))
            {
                MessageBox.Show("¡Falta Autor!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (string.IsNullOrEmpty(txtLibro.Text))
            {
                MessageBox.Show("¡Falta Título del libro!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (chkFrase.Checked)
            {
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
            }

            

            return true;
        }

        private void chkFrase_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFrase.Checked)
            {
                txtFrase.Enabled = true;
                txtPag.Enabled = true;
            }
            else
            {                
                txtFrase.Enabled = false;
                txtFrase.Text = "";
                txtPag.Enabled = false;
                txtPag.Text = "";
            }
        }

        private void txtFrase_TextChanged(object sender, EventArgs e)
        {
            lblContador.Text = txtFrase.Text.Length.ToString() + "/" + txtFrase.MaxLength;
            lblContador.Refresh();
        }
    }
}
