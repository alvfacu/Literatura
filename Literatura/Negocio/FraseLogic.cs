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

        public List<Frases> GetAll(int idUsr)
        {
            return FraseData.GetAll(idUsr);
        }

        public Frases GetOne(int ID, int idUsr)
        {
            return FraseData.GetOne(ID, idUsr);
        }

        public void Delete(int ID)
        {
            FraseData.Delete(ID);
        }

        public void Save(Frases frase)
        {
            FraseData.Insert(frase);
        }

        public void Update(Frases frase)
        {
            FraseData.Update(frase);
        }
        
        public List<Frases> GetAllXLibro(int idLibro, int idUsr)
        {
            return FraseData.GetAllXLibro(idLibro,idUsr);
        }

        public List<Frases> GetAllXAutor(int idAutor, int idUsr)
        {
            return FraseData.GetAllXAutor(idAutor, idUsr);
        }
    }
}
