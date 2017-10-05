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
    public partial class formLogin : ApplicationForm
    {
        public formLogin()
        {
            InitializeComponent();
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Entidades.Usuarios usrActual = new Negocio.UsuarioLogic().ObtenerUsuario(txtUsr.Text, txtPass.Text);
                if (usrActual != null)
                {
                    MessageBox.Show("¡Bienvenido " + usrActual.Usuario + "!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Program.IdUsuario = usrActual.IdUsuario;
                    Program.NomUsuario = usrActual.Usuario;
                    this.Hide();
                    formPrincipal ppal = new formPrincipal();
                    ppal.ShowDialog();
                    ppal.Close();
                    this.Dispose();
                    this.Close();
                }
                else
                    MessageBox.Show("¡Datos incorrectos!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(txtUsr.Text))
            {
                MessageBox.Show("¡Falta Usuario!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("¡Falta Contraseña!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

    }
}
