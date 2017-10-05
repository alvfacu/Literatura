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
            if (Validar())
            {
                try
                {
                    AutorActual = new Autores();
                    AutorActual.ApyNom = txtApeNom.Text;
                    AutorActual.IdUsuario = Program.IdUsuario;
                    AutorActual.State = Entidades.Entidades.States.New;
                    new AutorLogic().Save(AutorActual);

                    string msj = "¡Autor creado con éxito!";

                    if (chkTitulo.Checked)
                    {
                        LibroActual = new Libros();
                        LibroActual.IdUsuario = Program.IdUsuario;
                        LibroActual.Titulo = txtTitulo.Text;
                        LibroActual.IdAutor = AutorActual.IdAutor;
                        LibroActual.State = Entidades.Entidades.States.New;
                        new LibroLogic().Save(LibroActual);

                        msj = "¡Autor y Libro creados con éxito!";

                        if (chkFrase.Checked)
                        {
                            Frases FraseActual = new Frases();
                            FraseActual.IdLibro = LibroActual.IdLibro;
                            FraseActual.IdUsuario = LibroActual.IdUsuario;
                            FraseActual.State = Entidades.Entidades.States.New;
                            FraseActual.Frase = txtFrase.Text;
                            FraseActual.Pag = 0;
                            if (!string.IsNullOrEmpty(txtPag.Text))
                                FraseActual.Pag = Convert.ToInt32(txtPag.Text);

                            new FraseLogic().Save(FraseActual);

                            msj = "¡Autor, Libro y Frase creados con éxito!";
                        }
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
            if (string.IsNullOrEmpty(txtApeNom.Text))
            {
                MessageBox.Show("¡Falta Autor!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if(chkTitulo.Checked)
                if (string.IsNullOrEmpty(txtTitulo.Text))
                {
                    MessageBox.Show("¡Falta Título del libro!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

            if (chkFrase.Checked)
            {
                if (string.IsNullOrEmpty(txtFrase.Text))
                {
                    MessageBox.Show("¡Falta Frase del libro!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void chkTitulo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTitulo.Checked)
            {
                txtTitulo.Enabled = true;
                chkFrase.Enabled = true;
            }
            else
            {
                txtTitulo.Enabled = false;
                txtTitulo.Text = "";
                chkFrase.Enabled = false;
                txtFrase.Text = "";
            }
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
