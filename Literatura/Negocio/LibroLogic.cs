using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Data.Database;

namespace Negocio
{
    public class LibroLogic : EntidadesLogic
    {
        private LibroAdapter _LibroData;

        public LibroLogic()
        {
            LibroData = new LibroAdapter();
        }

        public LibroAdapter LibroData
        {
            get { return _LibroData; }
            set { _LibroData = value; }
        }

        public List<Libros> GetAll(int idUsr)
        {
            return LibroData.GetAll(idUsr);
        }

        public Libros GetOne(int ID, int idUsr)
        {
            return LibroData.GetOne(ID, idUsr);
        }

        public void Delete(int ID)
        {
           
        }

        public void Save(Libros libro)
        {
            LibroData.Insert(libro);
        }
        
        public List<Libros> GetAllXAutor(int idAutor, int idUsr)
        {
            return LibroData.GetAllXAutor(idAutor,idUsr);
        }

    }
}
