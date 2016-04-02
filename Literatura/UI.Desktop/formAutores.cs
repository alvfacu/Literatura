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
            this.dgv_Autores.DataSource = new AutorLogic().GetAll();
        }
    }
}
