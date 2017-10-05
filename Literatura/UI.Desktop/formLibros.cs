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
    public partial class formLibros : Form
    {
        List<Libros> libros;
        List<Autores> autores;
        DataTable TablaLibros = new DataTable();

        public formLibros()
        {
            InitializeComponent();
            ValorInicial();
            this.dgv_Libros.AutoGenerateColumns = false;
            libros = new LibroLogic().GetAll(Program.IdUsuario);
            if(libros.Count>0)
                CargarGrilla();
            else
                MessageBox.Show("¡No se han cargado libros!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public formLibros(List<Libros> libs)
        {
            InitializeComponent();
            ValorInicial();
            this.dgv_Libros.AutoGenerateColumns = false;
            libros = libs;
            CargarGrilla();                
        }

        public void ValorInicial()
        {
            autores = new AutorLogic().GetAll(Program.IdUsuario);

            if (!TablaLibros.Columns.Contains("idLibro"))
                TablaLibros.Columns.Add("idLibro", Type.GetType("System.Int32"));
            if (!TablaLibros.Columns.Contains("titulo"))
                TablaLibros.Columns.Add("titulo", Type.GetType("System.String"));
            if (!TablaLibros.Columns.Contains("idAutor"))
                TablaLibros.Columns.Add("idAutor", Type.GetType("System.Int32"));
            if (!TablaLibros.Columns.Contains("autor"))
                TablaLibros.Columns.Add("autor", Type.GetType("System.String"));

            dgv_Libros.DataSource = TablaLibros.DefaultView;
            
            dgv_Libros.Columns["titulo"].HeaderText = "Libro";
            dgv_Libros.Columns["titulo"].ReadOnly = true;
            dgv_Libros.Columns["titulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Libros.Columns["autor"].HeaderText = "Autor";
            dgv_Libros.Columns["autor"].ReadOnly = true;
            dgv_Libros.Columns["autor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv_Libros.Columns["idLibro"].Visible = false;
            dgv_Libros.Columns["idAutor"].Visible = false;
        }

        public void CargarGrilla()
        {
            TablaLibros.Rows.Clear();
            foreach (Libros lib in libros)
            {
                DataRow FilaNueva = TablaLibros.NewRow();
                FilaNueva["idLibro"] = lib.IdLibro;
                FilaNueva["titulo"] = lib.Titulo;
                FilaNueva["idAutor"] = lib.IdAutor;
                FilaNueva["autor"] = "";
                foreach (Autores au in autores)
                {
                    if(au.IdAutor==lib.IdAutor)
                        FilaNueva["autor"] = au.ApyNom;
                }
                TablaLibros.Rows.Add(FilaNueva);
            }

            dgv_Libros.DataSource = TablaLibros;
            dgv_Libros.Columns["idLibro"].Visible = false;
            dgv_Libros.Columns["idAutor"].Visible = false;
            dgv_Libros.CurrentCell = null;
        }

        private void dvg_Libros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Libros.CurrentRow != null && e.RowIndex != -1)
            {
                List<Frases> frases = new FraseLogic().GetAllXLibro(Convert.ToInt32(dgv_Libros.Rows[e.RowIndex].Cells["idLibro"].Value), Program.IdUsuario);
                if(frases.Count!=0)
                {
                    formFrases fr = new formFrases(Convert.ToInt32(dgv_Libros.Rows[e.RowIndex].Cells["idAutor"].Value), Convert.ToInt32(dgv_Libros.Rows[e.RowIndex].Cells["idLibro"].Value));
                    fr.ShowDialog();
                    fr.Close();
                }
                else
                    MessageBox.Show("¡No existen frases cargadas para el libro seleccionado libro!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnVerFrases_Click(object sender, EventArgs e)
        {
            if (dgv_Libros.CurrentRow != null && dgv_Libros.CurrentRow.Index != -1)
            {
                List<Frases> frases = new FraseLogic().GetAllXLibro(Convert.ToInt32(dgv_Libros.Rows[dgv_Libros.CurrentRow.Index].Cells["idLibro"].Value), Program.IdUsuario);
                if (frases.Count != 0)
                {
                    formFrases fr = new formFrases(Convert.ToInt32(dgv_Libros.Rows[dgv_Libros.CurrentRow.Index].Cells["idAutor"].Value), Convert.ToInt32(dgv_Libros.Rows[dgv_Libros.CurrentRow.Index].Cells["idLibro"].Value));
                    fr.ShowDialog();
                    fr.Close();
                }
                else
                    MessageBox.Show("¡No existen frases cargadas para el libro seleccionado libro!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
