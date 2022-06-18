using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ReclamoDAO
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static ReclamoDAO()
        {

            connectionString = @"Data Source=.;Initial Catalog=TP4_DB;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static void Guardar(List<Reclamo> lista)
        {
            try
            {
                connection.Open();
                command.CommandText = "DELETE FROM Reclamos";
                command.ExecuteNonQuery();

                foreach (Reclamo reclamo in lista)
                {
                    command.CommandText = "INSERT INTO Reclamos (tipo, libro, cliente) VALUES (@tipo, @libro, @cliente)";
                    command.Parameters.AddWithValue("@tipo", reclamo.Tipo1);
                    command.Parameters.AddWithValue("@libro", reclamo.Libro.Nombre);
                    command.Parameters.AddWithValue("@cliente", reclamo.Cliente.Nombre);
                    
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Reclamo> Cargar(Libreria libreria)
        {
            List<Reclamo> reclamos = new List<Reclamo>();
            Cliente cliente=null;
            Libro libro=null;
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Reclamos";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {

                    string nombreCliente = dataReader["Cliente"].ToString();
                    string nombreLibro = dataReader["Libro"].ToString();
                    
                    foreach (Cliente c in libreria.clientes)
                    {
                        if (nombreCliente== c.Nombre)
                        {
                            cliente = c;
                                break;
                        }
                    }

                    foreach(Libro l in libreria.libros)
                    {
                        if(l.Nombre== nombreLibro)
                        {
                            libro = l;
                                break;
                        }
                    }


                        Reclamo.Tipo tipo = (Reclamo.Tipo)(Convert.ToInt32(dataReader["Tipo"]));
                        Reclamo reclamo= new Reclamo(tipo , cliente, libro);
                        reclamos.Add(reclamo);

                    }
                }

                return reclamos;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
