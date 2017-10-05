using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Autores:Entidades
    {
        private int _idAutor;
        private string _apynom;
        private int _idUsuario;
        //List<Libro> libros = new List<Libro>();

        public int IdAutor
        {
            get { return _idAutor; }
            set { _idAutor = value; }
        }

        public string ApyNom
        {
            get { return _apynom; }
            set { _apynom = value; }
        }

        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
    }
}
