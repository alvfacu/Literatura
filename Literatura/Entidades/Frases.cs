using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Frases: Libros
    {
        private int _idFrase;
        private string _fragemto;

        public int IdFrase
        {
            get { return _idFrase; }
            set { _idFrase = value; }
        }

        public string Fragmento
        {
            get { return _fragemto; }
            set { _fragemto = value; }
        }
    }
}
