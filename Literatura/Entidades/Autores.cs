using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Autores:Entidades
    {
        private int _idAutor;
        private string _nombre;
        private string _apellido;
        private string _completo;
        //List<Libro> libros = new List<Libro>();
        
        public int IdAutor
        {
            get { return _idAutor; }
            set { _idAutor = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        /*public void agregarLibro(Libro lib)
        {
            libros.Add(lib);
        }*/

        public string devolverNombreApellido()
        {
            return (this.Nombre + " " + this.Apellido);
        }

        public string Completo
        {
            get { return _completo; }
            set { _completo = value; }
        }
    }
}
