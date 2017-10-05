using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Data.Database
{
    public class LibroAdapter: Adapter
    {
        public List<Libros> GetAll(int idUsr)
        {
            List<Libros> libros = new List<Libros>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdLibros = new SqlCommand("SELECT * FROM [dbo].[libros] WHERE idUsuario=@idUsr ORDER BY titulo", sqlConn);
                cmdLibros.Parameters.AddWithValue("@idUsr", idUsr);
                cmdLibros.CommandType = CommandType.Text;

                SqlDataReader drLibros = cmdLibros.ExecuteReader();

                while (drLibros.Read())
                {
                    Libros lib = new Libros();
                    lib.IdAutor = (int)drLibros["idAutor"];
                    lib.IdLibro = (int)drLibros["idLibro"];
                    lib.Titulo = (string)drLibros["titulo"];
                    lib.IdUsuario = (int)drLibros["idUsuario"];

                    libros.Add(lib);
                }

                drLibros.Close();
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

            return libros;
        }

        public List<Libros> GetAllXAutor(int idAutor,int idUsr)
        {
            List<Libros> libros = new List<Libros>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdLibros = new SqlCommand("SELECT * FROM [dbo].[libros] WHERE idAutor=@idAu AND idUsuario=@idUsr ORDER BY titulo", sqlConn);
                cmdLibros.Parameters.AddWithValue("@idAu", idAutor);
                cmdLibros.Parameters.AddWithValue("@idUsr", idUsr);

                cmdLibros.CommandType = CommandType.Text;

                SqlDataReader drLibros = cmdLibros.ExecuteReader();

                while (drLibros.Read())
                {
                    Libros lib = new Libros();
                    lib.IdAutor = (int)drLibros["idAutor"];
                    lib.IdLibro = (int)drLibros["idLibro"];
                    lib.Titulo = (string)drLibros["titulo"];
                    lib.IdUsuario = (int)drLibros["idUsuario"];
                    libros.Add(lib);
                }

                drLibros.Close();
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

            return libros;
        }

        public Libros GetOne(int iD, int idUsr)
        {
            Libros lib = null;

            try
            {
                this.OpenConnection();

                SqlCommand cmdLibros = new SqlCommand("SELECT * FROM [dbo].[libros] WHERE idLibro = @idLib AND idUsuario=@idUsr", sqlConn);
                cmdLibros.Parameters.AddWithValue("@idLib", iD);
                cmdLibros.Parameters.AddWithValue("@idUsr", idUsr);

                cmdLibros.CommandType = CommandType.Text;

                SqlDataReader drLibro = cmdLibros.ExecuteReader();

                if (drLibro.Read())
                {
                    lib = new Libros();
                    lib.Titulo = (string)drLibro["titulo"];
                    lib.IdLibro = (int)drLibro["idLibro"];
                    lib.IdAutor = (int)drLibro["idAutor"];
                }

                drLibro.Close();
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

            return lib;
        }

        public void Insert(Libros libro)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand("INSERT INTO [dbo].[libros](titulo,idAutor,idUsuario) " +
                    "VALUES(@titulo,@idAutor,@idUser) " +
                    "SELECT @@identity", //esta linea es para recuperar el ID que asignó el SQL automaticamente
                    sqlConn);
                cmdSave.Parameters.AddWithValue("@titulo", libro.Titulo);
                cmdSave.Parameters.AddWithValue("@idAutor", libro.IdAutor);
                cmdSave.Parameters.AddWithValue("@idUser", libro.IdUsuario);
                libro.IdLibro = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                Exception ExcepcionManejada = new Exception("Error al crear Libro", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Libros libro)
        {

        }

        public void Delete(Libros libro)
        {
            
        }
                
    }
}
