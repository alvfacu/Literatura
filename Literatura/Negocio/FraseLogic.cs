using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Data.Database;

namespace Negocio
{
    public class FraseLogic:EntidadesLogic
    {
        private FraseAdapter _FraseData;

        public FraseLogic()
        {
            _FraseData = new FraseAdapter();
        }

        public FraseAdapter FraseData
        {
            get { return _FraseData; }
            set { _FraseData = value; }
        }

        public List<Frases> GetAll()
        {
            return FraseData.GetAll();
        }

        public Frases GetOne(int ID)
        {
            return FraseData.GetOne(ID);
        }

        public void Delete(int ID)
        {
            FraseData.Delete(ID);
        }

        public void Save(Frases frase)
        {
            FraseData.Save(frase);
        }

        public List<Frases> GetAllXAutor(int idAutor)
        {
            return FraseData.GetAllXAutor(idAutor);
        }

        public List<Frases> GetAllXLibro(int idLibro)
        {
            return FraseData.GetAllXLibro(idLibro);
        }
    }
}
