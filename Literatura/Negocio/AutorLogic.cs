using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Data.Database;

namespace Negocio
{
    public class AutorLogic:EntidadesLogic
    {
        private AutorAdapter _AutorData;

        public AutorLogic()
        {
            AutorData = new AutorAdapter();
        }

        public AutorAdapter AutorData
        {
            get { return _AutorData; }
            set { _AutorData = value; }
        }

        public List<Autores> GetAll()
        {
            return AutorData.GetAll();
        }

        public Autores GetOne(int ID)
        {
            return AutorData.GetOne(ID);
        }
        
        public void Save(Autores autor)
        {
            AutorData.Save(autor);
        }

        public int DameIndex(int idAutor)
        {
            List<Autores> autores = AutorData.GetAll();
            int i = 0;
            int ind = 0;
            foreach (Autores au in autores)
            {
                if(au.IdAutor == idAutor)
                {
                    ind = i;
                }
                ++i;
            }
            return ind;
        }
    }
}
