using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Data.Database
{
    public class AutorAdapter : Adapter
    {
        public List<Autores> GetAll(int idUsr)
        {
            List<Autores> autores = new List<Autores>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdAutores = new SqlCommand("SELECT * FROM dbo.autores WHERE idUsuario=@idUsr ORDER BY apynom", sqlConn);
                cmdAutores.Parameters.AddWithValue("@idUsr", idUsr);
                cmdAutores.CommandType = CommandType.Text;

                SqlDataReader drAutores = cmdAutores.ExecuteReader();

                while (drAutores.Read())
                {
                    Autores au = new Autores();
                    au.ApyNom = (string)drAutores["apynom"];
                    au.IdAutor = (int)drAutores["idAutor"];
                    au.IdUsuario = (int)drAutores["idUsuario"];
                    autores.Add(au);
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

            return autores;
        }

        public Autores GetOne(int ID, int idUsr)
        {
            Autores au = null;

            try
            {
                this.OpenConnection();

                SqlCommand cmdLibros = new SqlCommand("SELECT * FROM [dbo].[autores] WHERE idAutor = @idAu AND idUsuario=@idUsr", sqlConn);
                cmdLibros.Parameters.AddWithValue("@idAu", ID);
                cmdLibros.Parameters.AddWithValue("@idUsr", idUsr);

                cmdLibros.CommandType = CommandType.Text;

                SqlDataReader drAutor = cmdLibros.ExecuteReader();

                if(drAutor.Read())
                {
                    au = new Autores();
                    au.ApyNom = (string)drAutor["apynom"];
                    au.IdAutor = (int)drAutor["idAutor"];
                }

                drAutor.Close();
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

            return au;
        }

        public void Delete(Autores autor)
        {
            
        }

        public void Insert(Autores autor)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand("INSERT INTO dbo.Autores (apynom,idUsuario) " +
                    "VALUES (@apnombre,@idusr) " +
                    "SELECT @@identity", //esta linea es para recuperar el ID que asignó el SQL automaticamente
                    sqlConn);
                cmdSave.Parameters.AddWithValue("@apnombre", autor.ApyNom);
                cmdSave.Parameters.AddWithValue("@idUsr", autor.IdUsuario);
                autor.IdAutor = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
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

        public void Update(Autores autor)
        {

        }
        
    }
}
