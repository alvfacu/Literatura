using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Database;
using Util;
using Entidades;

namespace Negocio
{
    public class UsuarioLogic: EntidadesLogic
    {
        private UsuarioAdapter _UsuarioData;

        public UsuarioLogic()
        {
            UsuarioData = new UsuarioAdapter();
        }

        public UsuarioAdapter UsuarioData
        {
            get { return _UsuarioData; }
            set { _UsuarioData = value; }
        }

        public Usuarios ObtenerUsuario(string usr, string pass)
        {
            return new Data.Database.UsuarioAdapter().ObtenerUsuario(usr, Seguridad.MD5Hash(pass));
        }

        public List<Usuarios> GetAll()
        {
            return new Data.Database.UsuarioAdapter().GetAll();
        }

        public void ReiniciarPass(int idUsr, string usr)
        {
            new Data.Database.UsuarioAdapter().ReiniciarPass(idUsr, usr);
        }

        public void CambiarPass(int idUsr, string usr, string pass)
        {
            new Data.Database.UsuarioAdapter().CambiarPass(idUsr, usr, pass);
        }

        public bool ExisteUsr(string usr)
        {
            return new Data.Database.UsuarioAdapter().ExisteUsr(usr);
        }

        public void AgregarUsuario(string usr, string pass)
        {
            new Data.Database.UsuarioAdapter().Insert(usr, pass);
        }
    }
}
