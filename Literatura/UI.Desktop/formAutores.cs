using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio;

namespace UI.Desktop
{
    public partial class formAutores : Form
    {
        public formAutores()
        {
            InitializeComponent();
            this.dgv_Autores.AutoGenerateColumns = false;
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            List<Entidades.Autores> autores = new AutorLogic().GetAll(Program.IdUsuario);
            if (autores.Count > 0)
                this.dgv_Autores.DataSource = autores;
            else
            {
                MessageBox.Show("¡No se han cargado Autores!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            dgv_Autores.CurrentCell = null;
         
        }

        private void dgv_Autores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Autores.CurrentRow != null && e.RowIndex > -1)
            {
                List<Entidades.Libros> libros = new LibroLogic().GetAllXAutor(Convert.ToInt32(dgv_Autores.Rows[e.RowIndex].Cells["idAutor"].Value), Program.IdUsuario);
                if(libros.Count!=0)
                {
                    formLibros libs = new formLibros(libros);
                    libs.ShowDialog();
                    libs.Close();
                }
                else
                    MessageBox.Show("¡No se han cargado libros para este autor!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            if (dgv_Autores.CurrentRow != null && dgv_Autores.CurrentRow.Index > -1)
            {
                List<Entidades.Libros> libros = new LibroLogic().GetAllXAutor(Convert.ToInt32(dgv_Autores.Rows[dgv_Autores.CurrentRow.Index].Cells["idAutor"].Value), Program.IdUsuario);
                if (libros.Count != 0)
                {
                    formLibros libs = new formLibros(libros);
                    libs.ShowDialog();
                    libs.Close();
                }
                else
                    MessageBox.Show("¡No se han cargado libros para este autor!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
