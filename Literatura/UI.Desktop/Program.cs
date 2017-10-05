using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UI.Desktop
{
    static class Program
    {
        private static int _idUsuario;
        private static string _nomUsuario;

        public static int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public static string NomUsuario
        {
            get { return _nomUsuario; }
            set { _nomUsuario = value; }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formLogin());
        }
    }
}
