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
    public partial class formLibros : Form
    {
        public formLibros()
        {
            InitializeComponent();
            this.dvg_Libros.AutoGenerateColumns = false;
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            this.dvg_Libros.DataSource = new LibroLogic().GetAll();
        }
    }
}
