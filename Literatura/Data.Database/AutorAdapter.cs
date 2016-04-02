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
        public List<Autores> GetAll()
        {
            List<Autores> autores = new List<Autores>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdAutores = new SqlCommand("SELECT au.idAutor as id, au.nombreApellido as completo FROM [Autores] au ORDER BY 2", sqlConn);
                cmdAutores.CommandType = CommandType.Text;

                SqlDataReader drAutores = cmdAutores.ExecuteReader();

                while (drAutores.Read())
                {
                    Autores au = new Autores();
                    au.Completo = (string)drAutores["completo"];
                    au.IdAutor = (int)drAutores["id"];
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

        public Autores GetOne(int ID)
        {
            return null;
        }

        public void Delete(Autores autor)
        {
            
        }

        public void Insert(Autores autor)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand("INSERT INTO [Autores](nombreApellido) " +
                    "VALUES(@nombreApellido) " +
                    "SELECT @@identity", //esta linea es para recuperar el ID que asignó el SQL automaticamente
                    sqlConn);
                cmdSave.Parameters.Add("@nombreApellido", SqlDbType.VarChar, 50).Value = autor.Completo;
                autor.IdAutor = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                Exception ExcepcionManejada = new Exception("Error al crear Autor", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Autores autor)
        {

        }

        public void Save(Autores autor)
        {
            if (autor.State == Entidades.Entidades.States.Deleted)
            {
                this.Delete(autor);
            }
            else if (autor.State == Entidades.Entidades.States.New)
            {
                this.Insert(autor);
            }
            else if (autor.State == Entidades.Entidades.States.Modified)
            {
                this.Update(autor);
            }
            autor.State = Entidades.Entidades.States.Unmodified;
        }
    }
}
