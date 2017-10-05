using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;
using Util;

namespace Data.Database
{
    public class UsuarioAdapter : Adapter
    {
        SqlCommand comando;
        SqlDataReader punteroLector;
                
        public Usuarios ObtenerUsuario(string usr, string pass)
        {
            List<Usuarios> usuarios = new List<Usuarios>();

            try
            {
                this.OpenConnection();

                comando = new SqlCommand("SELECT * FROM [dbo].[usuarios] WHERE usuario=@usr", sqlConn);
                comando.Parameters.AddWithValue("@usr", usr);

                comando.CommandType = CommandType.Text;

                punteroLector = comando.ExecuteReader();

                while (punteroLector.Read())
                {
                    if (pass.CompareTo((string)punteroLector["contrasenia"].ToString()) == 0)
                    {
                        Usuarios u = new Usuarios();
                        u.IdUsuario = (int)punteroLector["idUsuario"];
                        u.Usuario = (string)punteroLector["usuario"];
                        usuarios.Add(u);
                    }
                }

                punteroLector.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception(Ex.Message, Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            if (usuarios.Count == 0)
                return null;
            else
                return usuarios[0];
        }

        public List<Usuarios> GetAll()
        {
            List<Usuarios> usuarios = new List<Usuarios>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdAutores = new SqlCommand("SELECT * FROM dbo.usuarios WHERE idUsuario!=1 ORDER BY usuario", sqlConn);
                cmdAutores.CommandType = CommandType.Text;

                SqlDataReader drAutores = cmdAutores.ExecuteReader();

                while (drAutores.Read())
                {
                    Usuarios us = new Usuarios();
                    us.IdUsuario = (int)drAutores["idUsuario"];
                    us.Usuario = (string)drAutores["usuario"];
                    usuarios.Add(us);
                }

                drAutores.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception(Ex.Message, Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return usuarios;
        }

        public void ReiniciarPass(int id, string usr)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand("UPDATE [dbo].[usuarios] SET contrasenia=@reinicia WHERE idUsuario=@idUsr AND usuario=@usr", sqlConn);
                cmdSave.Parameters.AddWithValue("@reinicia", Seguridad.MD5Hash("1234"));
                cmdSave.Parameters.AddWithValue("@idUsr", id);
                cmdSave.Parameters.AddWithValue("@usr", usr);

                cmdSave.ExecuteReader();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar frase", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void CambiarPass(int id, string usr, string pass)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand("UPDATE [dbo].[usuarios] SET contrasenia=@pass WHERE idUsuario=@idUsr AND usuario=@usr", sqlConn);
                cmdSave.Parameters.AddWithValue("@pass", Seguridad.MD5Hash(pass));
                cmdSave.Parameters.AddWithValue("@idUsr", id);
                cmdSave.Parameters.AddWithValue("@usr", usr);

                cmdSave.ExecuteReader();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar frase", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public bool ExisteUsr(string usr)
        {
            bool existe = false;

            try
            {
                this.OpenConnection();

                comando = new SqlCommand("SELECT * FROM [dbo].[usuarios] WHERE usuario=@usr", sqlConn);
                comando.Parameters.AddWithValue("@usr", usr);

                comando.CommandType = CommandType.Text;

                punteroLector = comando.ExecuteReader();

                while (punteroLector.Read())
                {
                    existe = true;
                }

                punteroLector.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception(Ex.Message, Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return existe;
        }

        public void Insert(string usr, string pass)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand("INSERT INTO dbo.Usuarios (usuario,contrasenia) " +
                    "VALUES (@usuario,@pass) " +
                    "SELECT @@identity", //esta linea es para recuperar el ID que asignó el SQL automaticamente
                    sqlConn);
                cmdSave.Parameters.AddWithValue("@usuario", usr);
                cmdSave.Parameters.AddWithValue("@pass", Seguridad.MD5Hash(pass));
                int idUsr = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                //Exception ExcepcionManejada = new Exception("Error al crear Autor", Ex);
                //throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
