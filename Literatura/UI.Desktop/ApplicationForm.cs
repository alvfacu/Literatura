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
    public partial class ApplicationForm : Form
    {
        #region Variables

        public enum ModoForm { Alta, Baja, Modificacion, Consulta };
        private ModoForm _modo;
        private int _idUsr;
        #endregion

        #region Constructores
        
        public ApplicationForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Propiedades

        public ModoForm Modo
        {
            get { return _modo; }
            set { _modo = value; }
        }

        public int IdUsuario
        {
            get { return _idUsr; }
            set { _idUsr = value; }
        }

        #endregion

    }
}
