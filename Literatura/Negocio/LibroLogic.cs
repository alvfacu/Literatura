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

        public List<Libros> GetAll()
        {
            return LibroData.GetAll();
        }

        public Libros GetOne(int ID)
        {
            return LibroData.GetOne(ID);
        }

        public void Delete(int ID)
        {
           
        }

        public void Save(Libros libro)
        {
            LibroData.Save(libro);
        }
        
        public List<Libros> GetAllXAutor(int idAutor)
        {
            return LibroData.GetAllXAutor(idAutor);
        }

        public int DameIndex(int idLibro)
        {
            List<Libros> libros = LibroData.GetAll();
            int i = 0;
            int ind = 0;
            foreach (Libros lib in libros)
            {
                if (lib.IdLibro == idLibro)
                {
                    ind = i;
                }
                ++i;
            }
            return ind;
        }
    }
}
