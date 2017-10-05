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
        public List<Frases> GetAll(int idUsr)
        {
            List<Frases> frases = new List<Frases>();

            try
            {
                this.OpenConnection();                              

                SqlCommand cmdFrases = new SqlCommand("SELECT * FROM [dbo].[frases] WHERE idUsuario=@idUsr", sqlConn);
                cmdFrases.Parameters.AddWithValue("@idUsr", idUsr);
                cmdFrases.CommandType = CommandType.Text;

                SqlDataReader drFrases = cmdFrases.ExecuteReader();
                             
                while (drFrases.Read())
                {
                    Frases fr = new Frases();
                    fr.IdFrase = (int)drFrases["idFrase"];
                    fr.IdLibro = (int)drFrases["idLibro"];
                    fr.Frase = (string)drFrases["frase"];
                    fr.IdUsuario = (int)drFrases["idUsuario"];
                    fr.Pag = (int)drFrases["pagina"];
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

        public List<Frases> GetAllXLibro(int idLibro, int idUsr)
        {
            List<Frases> frases = new List<Frases>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdFrases = new SqlCommand("SELECT * FROM [dbo].[frases] WHERE idLibro=@idLib AND idUsuario=@idUsr", sqlConn);
                cmdFrases.Parameters.AddWithValue("@idLib", idLibro);
                cmdFrases.Parameters.AddWithValue("@idUsr", idUsr);

                cmdFrases.CommandType = CommandType.Text;

                SqlDataReader drFrases = cmdFrases.ExecuteReader();

                while (drFrases.Read())
                {
                    Frases fr = new Frases();
                    fr.IdFrase = (int)drFrases["idFrase"];
                    fr.IdLibro = (int)drFrases["idLibro"];
                    fr.Frase = (string)drFrases["frase"];
                    fr.IdUsuario = (int)drFrases["idUsuario"];
                    fr.Pag = (int)drFrases["pagina"];
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

        public List<Frases> GetAllXAutor(int idAutor, int idUsr)
        {
            List<Frases> frases = new List<Frases>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdFrases = new SqlCommand("SELECT fr.* FROM [dbo].[frases] as fr"+
                    " INNER JOIN [dbo].[libros] as lib ON fr.idLibro=lib.idLibro"+
                    " INNER JOIN [dbo].[autores] as au ON au.idAutor=lib.idAutor"+
                    " WHERE au.idAutor=@idAu AND lib.idUsuario=@idUsr", sqlConn);
                cmdFrases.Parameters.AddWithValue("@idAu", idAutor);
                cmdFrases.Parameters.AddWithValue("@idUsr", idUsr);

                cmdFrases.CommandType = CommandType.Text;

                SqlDataReader drFrases = cmdFrases.ExecuteReader();

                while (drFrases.Read())
                {
                    Frases fr = new Frases();
                    fr.IdFrase = (int)drFrases["idFrase"];
                    fr.IdLibro = (int)drFrases["idLibro"];
                    fr.Frase = (string)drFrases["frase"];
                    fr.IdUsuario = (int)drFrases["idUsuario"];
                    fr.Pag = (int)drFrases["pagina"];
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

        public Frases GetOne(int ID, int idUsr)
        {
            Frases frase = new Frases();

            try
            {
                this.OpenConnection();

                SqlCommand cmdFrase = new SqlCommand("SELECT * FROM [dbo].[frases] WHERE idFrase=@idFrase AND idUsuario=@idUsuario", sqlConn);
                cmdFrase.Parameters.AddWithValue("@idFrase", ID);
                cmdFrase.Parameters.AddWithValue("@idUsuario", idUsr);

                SqlDataReader drFrase = cmdFrase.ExecuteReader();

                if (drFrase.Read())
                {
                    frase.IdFrase = (int)drFrase["idFrase"];
                    frase.IdLibro = (int)drFrase["idLibro"];
                    frase.Frase = (string)drFrase["frase"];
                    frase.IdUsuario = (int)drFrase["idUsuario"];
                    frase.Pag = (int)drFrase["pagina"];
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

        public void Insert(Frases fr)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand("INSERT INTO [dbo].[frases](idLibro,frase,idUsuario,pagina) " +
                    "VALUES(@idLibro,@texto,@idUsr,@pagina) " +
                    "SELECT @@identity", //esta linea es para recuperar el ID que asignó el SQL automaticamente
                    sqlConn);
                cmdSave.Parameters.AddWithValue("@idLibro", fr.IdLibro);
                cmdSave.Parameters.AddWithValue("@idUsr", fr.IdUsuario);
                cmdSave.Parameters.AddWithValue("@texto", fr.Frase);
                cmdSave.Parameters.AddWithValue("@pagina", fr.Pag);
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

        public void Update(Frases frase)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand("UPDATE [dbo].[frases] SET idLibro=@idLibro, frase=@texto, pagina=@pag WHERE idFrase=@idFrase AND idUsuario=@idUsuario", sqlConn);
                cmdSave.Parameters.AddWithValue("@idLibro", frase.IdLibro);
                cmdSave.Parameters.AddWithValue("@texto", frase.Frase);
                cmdSave.Parameters.AddWithValue("@idFrase", frase.IdFrase);
                cmdSave.Parameters.AddWithValue("@idUsuario", frase.IdUsuario);
                cmdSave.Parameters.AddWithValue("@pag", frase.Pag);

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

        
    }
}
