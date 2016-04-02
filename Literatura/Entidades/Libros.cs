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
        private int _idAutor;
        private string _apeNomAutor;
        
        public int IdLibro
        {
            get { return _idLibro; }
            set { _idLibro = value; }
        }

        public string Libro
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public int IdAutor
        {
            get { return _idAutor; }
            set { _idAutor = value; }
        }

        public string Autor
        {
            get { return _apeNomAutor; }
            set { _apeNomAutor = value; }
        }
    }
}
