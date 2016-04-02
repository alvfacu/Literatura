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
            FrActual = new FraseLogic().GetOne(ID);
            this.txtFrase.Text = FrActual.Fragmento;
        }

        public Frase(int ID, Entidades.Entidades.States estado)
        {
            InitializeComponent();
            CargarListas();
            Modo = estado;
            if (ID != 0)
            {
                FrActual = new FraseLogic().GetOne(ID);
            }
            this.cmbLibros.SelectedIndex = -1;
            switch (Modo)
            {
                case (Entidades.Entidades.States.New):
                    {
                        this.btn_Aceptar.Text = "Guardar";
                        break;
                    }
                case (Entidades.Entidades.States.Deleted):
                    {
                        this.btn_Aceptar.Text = "Eliminar";
                        break;
                    }
                case (Entidades.Entidades.States.Modified):
                    {
                        RellenarFormulario();
                        this.btn_Aceptar.Text = "Modificar";
                        break;
                    }
                default: break;
            }
        }

        private void RellenarFormulario()
        {
            this.cmbAutores.SelectedIndex = new AutorLogic().DameIndex(FrActual.IdAutor);
            CargarLibros();
            this.cmbLibros.SelectedIndex = new LibroLogic().DameIndex(FrActual.IdLibro);
            this.txtFrase.Text = FrActual.Fragmento;
        }

        private void CargarListas()
        {
            this.cmbAutores.DataSource = new AutorLogic().GetAll();
            this.cmbAutores.DisplayMember = "completo";
            CargarLibros();
        }

        private void CargarLibros()
        {
            this.cmbLibros.DataSource = new LibroLogic().GetAll();
            this.cmbLibros.DisplayMember = "libro";
        }

        private void cmbAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbLibros.DataSource = new LibroLogic().GetAllXAutor(((Entidades.Autores)this.cmbAutores.SelectedValue).IdAutor);
            this.cmbLibros.DisplayMember = "libro";
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            switch (Modo)
            {
                case (Entidades.Entidades.States.New):
                    {
                        FrActual = new Frases();
                        FrActual.IdLibro = ((Entidades.Libros)this.cmbLibros.SelectedValue).IdLibro;
                        FrActual.Fragmento = this.txtFrase.Text;
                        FrActual.State = Modo;
                        new FraseLogic().Save(FrActual);
                        break;
                    }
                case (Entidades.Entidades.States.Deleted):
                    {
                        this.btn_Aceptar.Text = "Eliminar";
                        break;
                    }
                case (Entidades.Entidades.States.Modified):
                    {
                        FrActual.IdLibro = ((Entidades.Libros)this.cmbLibros.SelectedValue).IdLibro;
                        FrActual.Fragmento = this.txtFrase.Text;
                        FrActual.State = Modo;
                        new FraseLogic().Save(FrActual);
                        break;
                    }
                default: break;
            }
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
