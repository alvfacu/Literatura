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
    public partial class Usuarios : Form
    {
        DataTable TablaUsuarios = new DataTable();

        public Usuarios()
        {
            InitializeComponent();
            ValorInicial();
            if (Program.IdUsuario == 1)
            {
                CargarGrilla();
            }
            else
                this.Close();
        }
        public void CargarGrilla()
        {
            List<Entidades.Usuarios> usuarios = new List<Entidades.Usuarios>();
            usuarios = new UsuarioLogic().GetAll();

            foreach (Entidades.Usuarios usr in usuarios)
                TablaUsuarios.Rows.Add(usr.Usuario, usr.IdUsuario);

            dgvUsuarios.DataSource = TablaUsuarios;
        }

        public void ValorInicial()
        {
            if (!TablaUsuarios.Columns.Contains("usuario"))
                TablaUsuarios.Columns.Add("usuario", Type.GetType("System.String"));
            if (!TablaUsuarios.Columns.Contains("idUsuario"))
                TablaUsuarios.Columns.Add("idUsuario", Type.GetType("System.Int32"));

            dgvUsuarios.DataSource = TablaUsuarios;
            dgvUsuarios.Columns["usuario"].HeaderText = "Usuario";
            dgvUsuarios.Columns["usuario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUsuarios.Columns["idUsuario"].Visible = false;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            if(dgvUsuarios.CurrentRow != null && dgvUsuarios.CurrentRow.Index>=0)
            {
                DialogResult rta = MessageBox.Show("¿Reiniciar la contraseña de " + dgvUsuarios.CurrentRow.Cells["usuario"].Value + "?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rta == DialogResult.Yes)
                {
                    new UsuarioLogic().ReiniciarPass(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["idUsuario"].Value), dgvUsuarios.CurrentRow.Cells["usuario"].Value.ToString());
                    MessageBox.Show("¡Se ha reiniciado la contraseña de "+ dgvUsuarios.CurrentRow.Cells["usuario"].Value+ "!","Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("¡Seleccione algún usuario!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvUsuarios_DoubleClick(object sender, EventArgs e)
        {
            if(dgvUsuarios.CurrentRow != null && dgvUsuarios.CurrentRow.Index>-1)
            {
                formUsuario form = new formUsuario(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["idUsuario"].Value), dgvUsuarios.CurrentRow.Cells["usuario"].Value.ToString());
                form.ShowDialog();
                form.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null && dgvUsuarios.CurrentRow.Index > -1)
            {
                formUsuario form = new formUsuario(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["idUsuario"].Value), dgvUsuarios.CurrentRow.Cells["usuario"].Value.ToString());
                form.ShowDialog();
                form.Close();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            formUsuario form = new formUsuario(0,"");
            form.ShowDialog();
            form.Close();
            CargarGrilla();
        }
    }

}
