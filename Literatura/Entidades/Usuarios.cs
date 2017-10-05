using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Usuarios:Entidades
    {
        private int _idUsuario;
        private string _usuario;
        private string _contrasenia;

        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public string Contrasenia
        {
            get { return _contrasenia; }
            set { _contrasenia = value; }
        }
    }
}
