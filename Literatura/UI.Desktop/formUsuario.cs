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
    public partial class formUsuario : Form
    {
        private int idUsrConsulta;
        bool cambiaPass = false;

        public formUsuario()
        {
            InitializeComponent();
        }

        public formUsuario(int idUsr,string usr)
        {
            InitializeComponent();
            idUsrConsulta = idUsr;
            txtUsuario.Text = usr;
            if (Program.IdUsuario == 1)
            {
                if(idUsr==0)
                {
                    this.btnOK.Image = UI.Desktop.Properties.Resources.Actions_dialog_ok_apply_icon;
                    btnOK.Refresh();
                    toolTip1.SetToolTip(btnOK, "Agregar Usuario");

                    btnNO.Visible = true;
                    btnNO.Enabled = true;
                    btnOK.Visible = true;
                    btnOK.Enabled = true;

                    chkModificarPass.Visible = false;

                    txtUsuario.Enabled = true;
                    txtUsuario.ReadOnly = false;
                    grContraseña.Enabled = true;
                    txtContra.Enabled = true;
                    txtReContra.Enabled = true;
                    btnVerPass.Enabled = true;
                    btnRePass.Enabled = true;
                }
                else
                {
                    btnNO.Visible = true;
                    btnNO.Enabled = true;
                    btnOK.Visible = true;
                    btnOK.Enabled = true;

                    this.btnOK.Image = UI.Desktop.Properties.Resources.Reset_icon1;
                    btnOK.Refresh();
                    toolTip1.SetToolTip(btnOK, "Reiniciar Contraseña");
                }
                
            }
            else
            {
                btnNO.Visible = true;
                btnNO.Enabled = true;
                btnOK.Visible = true;
                btnOK.Enabled = true;

                this.btnOK.Image = UI.Desktop.Properties.Resources.Actions_dialog_ok_apply_icon;
                btnOK.Refresh();
                toolTip1.SetToolTip(btnOK, "Aceptar");
            }
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(Program.IdUsuario==1)
            {
                if(idUsrConsulta==0)
                {
                    if(Validar())
                    {
                        new UsuarioLogic().AgregarUsuario(txtUsuario.Text, txtContra.Text);
                        MessageBox.Show("¡Se ha agregado el usuario " + txtUsuario.Text + " correctamente!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                        this.Close();
                    }
                    
                }
                else
                {
                    if (!cambiaPass)
                    {
                        new UsuarioLogic().ReiniciarPass(idUsrConsulta, txtUsuario.Text);
                        MessageBox.Show("¡Se ha reiniciado la contraseña de " + txtUsuario.Text + "!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                        this.Close();
                    }
                    else
                    {
                        if (Validar())
                        {
                            new UsuarioLogic().CambiarPass(idUsrConsulta, txtUsuario.Text, txtContra.Text);
                            MessageBox.Show("¡Se ha modificado la contraseña de " + txtUsuario.Text + " correctamente!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }                                
            }
            else
            {
                if(Validar())
                {
                    new UsuarioLogic().CambiarPass(idUsrConsulta, txtUsuario.Text, txtContra.Text);
                    MessageBox.Show("¡Se ha modificado la contraseña de " + txtUsuario.Text + " correctamente!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public bool Validar()
        {
            if(idUsrConsulta==0)
            {
                if(string.IsNullOrEmpty(txtUsuario.Text))
                {
                    MessageBox.Show("¡Existen campos vacíos!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if(new UsuarioLogic().ExisteUsr(txtUsuario.Text))
                {
                    MessageBox.Show("¡El nombre de usuario se encuentra en uso!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            if(string.IsNullOrEmpty(txtReContra.Text) || string.IsNullOrEmpty(txtContra.Text))
            {
                MessageBox.Show("¡Existen campos vacíos!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if(txtContra.Text.CompareTo(txtReContra.Text)!=0)
            {
                MessageBox.Show("¡Las contraseñas no coinciden!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void chkModificarPass_CheckedChanged(object sender, EventArgs e)
        {
            if(chkModificarPass.Checked)
            {
                grContraseña.Enabled = true;
                txtContra.Enabled = true;
                txtReContra.Enabled = true;
                btnVerPass.Enabled = true;
                btnRePass.Enabled = true;
                cambiaPass = true;
                this.btnOK.Image = UI.Desktop.Properties.Resources.Actions_dialog_ok_apply_icon;
                btnOK.Refresh();
                toolTip1.SetToolTip(btnOK, "Aceptar");
            }
            else
            {
                grContraseña.Enabled = false;
                txtContra.Enabled = false;
                txtContra.Text = "";
                txtReContra.Enabled = false;
                txtReContra.Text = "";
                btnVerPass.Enabled = false;
                btnVerPass.Enabled = false;
                cambiaPass = false;

                if (Program.IdUsuario==0)
                {
                    this.btnOK.Image = UI.Desktop.Properties.Resources.Reset_icon1;
                    btnOK.Refresh();
                    toolTip1.SetToolTip(btnOK, "Reiniciar Contraseña");
                }
                else
                {
                    this.btnOK.Image = UI.Desktop.Properties.Resources.Actions_dialog_ok_apply_icon;
                    btnOK.Refresh();
                    toolTip1.SetToolTip(btnOK, "Aceptar");
                }
                
            }
        }

        private void btnVerPass_Click(object sender, EventArgs e)
        {
            if(txtContra.UseSystemPasswordChar)
                txtContra.UseSystemPasswordChar = false;
            else
                txtContra.UseSystemPasswordChar = true;
        }

        private void btnRePass_Click(object sender, EventArgs e)
        {
            if (txtReContra.UseSystemPasswordChar)
                txtReContra.UseSystemPasswordChar = false;
            else
                txtReContra.UseSystemPasswordChar = true;
        }
    }
}
