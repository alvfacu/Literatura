using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Data.Database
{
    public class FraseAdapter : Adapter
    {
        public List<Frases> GetAll()
        {
            List<Frases> frases = new List<Frases>();

            try
            {
                this.OpenConnection();                              

                SqlCommand cmdFrases = new SqlCommand("SELECT au.nombreApellido as nombre, au.idAutor as idAutor, lib.titulo as titulo, lib.idLibro as idLibro, fr.idFrase as idFrase, fr.texto as frase"
                    + " FROM [Frases] fr INNER JOIN [Libros] lib ON fr.idLibro = lib.idLibro INNER JOIN [Autores] au ON lib.idAutor = au.idAutor ORDER BY 1 , 3", sqlConn);
                cmdFrases.CommandType = CommandType.Text;

                SqlDataReader drFrases = cmdFrases.ExecuteReader();
                             
                while (drFrases.Read())
                {
                    Frases fr = new Frases();
                    fr.IdFrase = (int)drFrases["idFrase"];
                    fr.IdAutor = (int)drFrases["idAutor"];
                    fr.IdLibro = (int)drFrases["idLibro"];
                    fr.Libro = (string)drFrases["titulo"];
                    fr.Autor = (string)drFrases["nombre"];
                    fr.Fragmento = (string)drFrases["frase"];

                    frases.Add(fr);
                }

                drFrases.Close();
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

            return frases;
        }

        public List<Frases> GetAllXLibro(int idLibro)
        {
            List<Frases> frases = new List<Frases>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdFrases = new SqlCommand("SELECT au.nombreApellido as nombre, au.idAutor as idAutor, lib.titulo as titulo, lib.idLibro as idLibro, fr.idFrase as idFrase, fr.texto as frase"
                    + " FROM [Frases] fr INNER JOIN [Libros] lib ON fr.idLibro = lib.idLibro INNER JOIN [Autores] au ON lib.idAutor = au.idAutor WHERE lib.idLibro = @id", sqlConn);
                cmdFrases.Parameters.Add("@id", SqlDbType.Int).Value = idLibro;

                cmdFrases.CommandType = CommandType.Text;

                SqlDataReader drFrases = cmdFrases.ExecuteReader();

                while (drFrases.Read())
                {
                    Frases fr = new Frases();
                    fr.IdFrase = (int)drFrases["idFrase"];
                    fr.IdAutor = (int)drFrases["idAutor"];
                    fr.IdLibro = (int)drFrases["idLibro"];
                    fr.Libro = (string)drFrases["titulo"];
                    fr.Autor = (string)drFrases["nombre"];
                    fr.Fragmento = (string)drFrases["frase"];

                    frases.Add(fr);
                }

                drFrases.Close();
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

            return frases;
        }

        public List<Frases> GetAllXAutor(int idAutor)
        {
            List<Frases> frases = new List<Frases>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdFrases = new SqlCommand("SELECT au.nombreApellido as nombre, au.idAutor as idAutor, lib.titulo as titulo, lib.idLibro as idLibro, fr.idFrase as idFrase, fr.texto as frase"
                    + " FROM [Frases] fr INNER JOIN [Libros] lib ON fr.idLibro = lib.idLibro INNER JOIN [Autores] au ON lib.idAutor = au.idAutor WHERE au.idAutor = @id ORDER BY 1,3", sqlConn);
                cmdFrases.Parameters.Add("@id", SqlDbType.Int).Value = idAutor;

                cmdFrases.CommandType = CommandType.Text;

                SqlDataReader drFrases = cmdFrases.ExecuteReader();

                while (drFrases.Read())
                {
                    Frases fr = new Frases();
                    fr.IdFrase = (int)drFrases["idFrase"];
                    fr.IdAutor = (int)drFrases["idAutor"];
                    fr.IdLibro = (int)drFrases["idLibro"];
                    fr.Libro = (string)drFrases["titulo"];
                    fr.Autor = (string)drFrases["nombre"];
                    fr.Fragmento = (string)drFrases["frase"];

                    frases.Add(fr);
                }

                drFrases.Close();
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

            return frases;
        }

        public Frases GetOne(int ID)
        {
            Frases frase = new Frases();

            try
            {
                this.OpenConnection();

                SqlCommand cmdFrase = new SqlCommand("SELECT au.nombreApellido as nombre, au.idAutor as idAutor, lib.titulo as titulo, lib.idLibro as idLibro, fr.idFrase as idFrase, fr.texto as frase"
                    + " FROM [Frases] fr INNER JOIN [Libros] lib ON fr.idLibro = lib.idLibro INNER JOIN [Autores] au ON lib.idAutor = au.idAutor WHERE fr.idFrase = @id", sqlConn);
                cmdFrase.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                SqlDataReader drFrase = cmdFrase.ExecuteReader();

                if (drFrase.Read())
                {
                    frase.IdFrase = (int)drFrase["idFrase"];
                    frase.IdAutor = (int)drFrase["idAutor"];
                    frase.IdLibro = (int)drFrase["idLibro"];
                    frase.Libro = (string)drFrase["titulo"];
                    frase.Autor = (string)drFrase["nombre"];
                    frase.Fragmento = (string)drFrase["frase"];
                }

                drFrase.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar datos de la frase", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return frase;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdDelete = new SqlCommand("DELETE cursos WHERE id_curso=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteReader();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al eliminar frase", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Frases fr)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand("INSERT INTO [Frases](idLibro,texto) " +
                    "VALUES(@idLibro,@texto) " +
                    "SELECT @@identity", //esta linea es para recuperar el ID que asignó el SQL automaticamente
                    sqlConn);
                cmdSave.Parameters.Add("@idLibro", SqlDbType.Int).Value = fr.IdLibro;
                cmdSave.Parameters.Add("@texto", SqlDbType.VarChar, 1000).Value = fr.Fragmento;
                fr.IdFrase = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar()); 
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                Exception ExcepcionManejada = new Exception("Error al crear frase", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Frases frase)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand("UPDATE [Frases] SET idLibro=@idLibro, texto=@texto WHERE idFrase=@idFrase", sqlConn);
                cmdSave.Parameters.Add("@idFrase", SqlDbType.Int).Value = frase.IdFrase;
                cmdSave.Parameters.Add("@idLibro", SqlDbType.Int).Value = frase.IdLibro;
                cmdSave.Parameters.Add("@texto", SqlDbType.VarChar, 1000).Value = frase.Fragmento;

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

        public void Save(Frases frase)
        {
            if (frase.State == Entidades.Entidades.States.Deleted)
            {
                this.Delete(frase.IdFrase);
            }
            else if (frase.State == Entidades.Entidades.States.New)
            {
                this.Insert(frase);
            }
            else if (frase.State == Entidades.Entidades.States.Modified)
            {
                this.Update(frase);
            }
            frase.State = Entidades.Entidades.States.Unmodified;
        }
    }
}
