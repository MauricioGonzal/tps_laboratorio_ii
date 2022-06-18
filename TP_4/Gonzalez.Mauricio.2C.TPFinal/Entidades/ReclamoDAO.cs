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
                foreach (Reclamo reclamo in lista)
                {
                    command.CommandText = "INSERT INTO Reclamos (tipo, libro, cliente) VALUES (@tipo, @libro, @cliente)";
                    command.Parameters.AddWithValue("@tipo", reclamo.Tipo1.ToString());
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
    }
}
