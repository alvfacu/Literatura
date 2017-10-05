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

        public List<Autores> GetAll(int idUsr)
        {
            return AutorData.GetAll(idUsr);
        }

        public Autores GetOne(int ID,int idUsr)
        {
            return AutorData.GetOne(ID,idUsr);
        }
        
        public void Save(Autores autor)
        {
            AutorData.Insert(autor);
        }
    }
}
