using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class LibroDAO
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static LibroDAO()
        {

            connectionString = @"Data Source=.;Initial Catalog=TP4_DB;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static void Guardar(List<Libro> listaLibros)
        {
            try
            {
                connection.Open();
                foreach (Libro libro in listaLibros)
                {
                    command.CommandText = "INSERT INTO LIBROS (nombre, autor, categoria, stock, precio) VALUES (@nombre, @autor, @categoria, @stock, @precio)";
                    command.Parameters.AddWithValue("@nombre", libro.Nombre);
                    command.Parameters.AddWithValue("@autor", libro.Autor);
                    command.Parameters.AddWithValue("@categoria", libro.Categoria.ToString());
                    command.Parameters.AddWithValue("@stock", libro.Stock);
                    command.Parameters.AddWithValue("@precio", libro.Precio);

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
