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
        public List<Libros> GetAll()
        {
            List<Libros> libros = new List<Libros>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdLibros = new SqlCommand("SELECT * FROM [Libros] lib INNER JOIN [Autores] au ON lib.idAutor = au.idAutor ORDER BY titulo", sqlConn);
                cmdLibros.CommandType = CommandType.Text;

                SqlDataReader drLibros = cmdLibros.ExecuteReader();

                while (drLibros.Read())
                {
                    Libros lib = new Libros();
                    lib.IdAutor = (int)drLibros["idAutor"];
                    lib.IdLibro = (int)drLibros["idLibro"];
                    lib.Libro = (string)drLibros["titulo"];
                    lib.Autor = (string)drLibros["nombreApellido"];

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

        public List<Libros> GetAllXAutor(int idAutor)
        {
            List<Libros> libros = new List<Libros>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdLibros = new SqlCommand("SELECT * FROM [Libros] lib WHERE lib.idAutor = @id ORDER BY titulo", sqlConn);
                cmdLibros.Parameters.Add("@id", SqlDbType.Int).Value = idAutor;

                cmdLibros.CommandType = CommandType.Text;

                SqlDataReader drLibros = cmdLibros.ExecuteReader();

                while (drLibros.Read())
                {
                    Libros lib = new Libros();
                    lib.IdAutor = (int)drLibros["idAutor"];
                    lib.IdLibro = (int)drLibros["idLibro"];
                    lib.Libro = (string)drLibros["titulo"];
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

        public Libros GetOne(int iD)
        {
            throw new NotImplementedException();
        }

        public void Insert(Libros libro)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand("INSERT INTO [Libros](titulo,idAutor) " +
                    "VALUES(@titulo,@idAutor) " +
                    "SELECT @@identity", //esta linea es para recuperar el ID que asignó el SQL automaticamente
                    sqlConn);
                cmdSave.Parameters.Add("@titulo", SqlDbType.VarChar, 50).Value = libro.Libro;
                cmdSave.Parameters.Add("@idAutor", SqlDbType.Int).Value = libro.IdAutor;
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

        public void Save(Libros libro)
        {
            if (libro.State == Entidades.Entidades.States.Deleted)
            {
                this.Delete(libro);
            }
            else if (libro.State == Entidades.Entidades.States.New)
            {
                this.Insert(libro);
            }
            else if (libro.State == Entidades.Entidades.States.Modified)
            {
                this.Update(libro);
            }
            libro.State = Entidades.Entidades.States.Unmodified;
        }
    }
}
