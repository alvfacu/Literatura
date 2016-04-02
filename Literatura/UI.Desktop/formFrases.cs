using Negocio;
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
    public partial class formFrases : Form
    {
        public formFrases()
        {
            InitializeComponent();
            this.cmbAutores.Enabled = this.cmbLibros.Enabled = false;
            this.btn_actualizar.Text = "Mostrar todas";
            this.dgv_Frases.AutoGenerateColumns = false;
            this.btn_Ver.Enabled = false;
        }
        
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            if (chk_autor.Checked)
            {
                this.btn_actualizar.Text = "Actualizar";
                this.dgv_Frases.DataSource = new FraseLogic().GetAllXAutor(((Entidades.Autores)this.cmbAutores.SelectedValue).IdAutor);
            }
            else if (chk_libro.Checked)
            {
                this.btn_actualizar.Text = "Actualizar";
                this.dgv_Frases.DataSource = new FraseLogic().GetAllXLibro(((Entidades.Libros)this.cmbLibros.SelectedValue).IdLibro);
            }
            else
            {
                this.dgv_Frases.DataSource = new FraseLogic().GetAll();
            }
        }
        
        private void chk_autor_CheckedChanged(object sender, EventArgs e)
        {      
            if (chk_autor.Checked == true)
            {
                btn_actualizar.Text = "Buscar";
                btn_actualizar.Enabled = true;
                this.cmbAutores.Enabled = true;
                this.cmbAutores.DataSource = new AutorLogic().GetAll();
                this.cmbAutores.DisplayMember = "completo";
                chk_libro.Checked = false;
            }
            else
            {
                this.cmbAutores.Enabled = false;
                this.cmbAutores.SelectedIndex = -1;
                if (chk_libro.Checked == false)
                {
                    btn_actualizar.Text = "Mostrar todas";
                    btn_actualizar.Enabled = true;
                }
            }
        }

        private void chk_libro_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_libro.Checked == true)
            {
                btn_actualizar.Text = "Buscar";
                btn_actualizar.Enabled = true;
                this.cmbLibros.Enabled = true;
                this.cmbLibros.DataSource = new LibroLogic().GetAll();
                this.cmbLibros.DisplayMember = "libro";
                chk_autor.Checked = false;
            }
            else
            {
                this.cmbLibros.Enabled = false;
                this.cmbLibros.SelectedIndex = -1;
                if(chk_autor.Checked == false)
                {
                    btn_actualizar.Text = "Mostrar todas";
                    btn_actualizar.Enabled = true;
                }
            }
        }

        private void btn_Ver_Click(object sender, EventArgs e)
        {
            int ID = ((Entidades.Frases)this.dgv_Frases.SelectedRows[0].DataBoundItem).IdFrase;
            Frase fr = new Frase(ID, Entidades.Entidades.States.Modified);
            fr.ShowDialog();
            CargarGrilla();
        }
        private void dgv_Frases_SelectionChanged(object sender, EventArgs e)
        {
            this.btn_Ver.Enabled = true;
        }

        private void dgv_Frases_DoubleClick(object sender, EventArgs e)
        {
            if (!(this.dgv_Frases.SelectedRows == null))
            {
                int ID = ((Entidades.Frases)this.dgv_Frases.SelectedRows[0].DataBoundItem).IdFrase;
                Frase fr = new Frase(ID, Entidades.Entidades.States.Modified);
                fr.ShowDialog();
                CargarGrilla();
            }
        }

        private void cmbAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btn_actualizar.Text = "Buscar";
            this.btn_Ver.Enabled = false;
        }

        private void cmbLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btn_actualizar.Text = "Buscar";
            this.btn_Ver.Enabled = false;
        }
    }
}
