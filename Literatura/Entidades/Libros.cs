using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Libros : Entidades
    {
        private int _idLibro;
        private string _titulo;
        private int _idUsuario;
        private int _idAutor;

        public int IdLibro
        {
            get { return _idLibro; }
            set { _idLibro = value; }
        }

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }
        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public int IdAutor
        {
            get { return _idAutor; }
            set { _idAutor = value; }
        }
    }
}
