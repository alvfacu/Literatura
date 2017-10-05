using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Frases: Entidades
    {
        private int _idFrase;
        private string _frase;
        private int _idLibro;
        private int _idUsuario;
        private int _pag;

        public int IdFrase
        {
            get { return _idFrase; }
            set { _idFrase = value; }
        }

        public string Frase
        {
            get { return _frase; }
            set { _frase = value; }
        }
        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
        public int IdLibro
        {
            get { return _idLibro; }
            set { _idLibro = value; }
        }
        public int Pag
        {
            get { return _pag; }
            set { _pag = value; }
        }
    }
}
