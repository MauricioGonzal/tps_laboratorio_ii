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
                command.CommandText = "DELETE FROM LIBROS";
                command.ExecuteNonQuery();

                foreach (Libro libro in listaLibros)
                {
                    command.CommandText = "INSERT INTO LIBROS (nombre, autor, categoria, stock, precio) VALUES (@nombre, @autor, @categoria, @stock, @precio)";
                    command.Parameters.AddWithValue("@nombre", libro.Nombre);
                    command.Parameters.AddWithValue("@autor", libro.Autor);
                    command.Parameters.AddWithValue("@categoria", libro.Categoria);
                    command.Parameters.AddWithValue("@stock", libro.Stock);
                    command.Parameters.AddWithValue("@precio", Math.Round(libro.Precio,2));

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

        public static List<Libro> Cargar()
        {
            List<Libro> libros = new List<Libro>();
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM libros";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        libros.Add(new Libro(dataReader["nombre"].ToString(), dataReader["autor"].ToString(), (Libro.Categorias)(Convert.ToInt32(dataReader["categoria"])), 
                        Convert.ToInt32(dataReader["stock"].ToString()), float.Parse(dataReader["precio"].ToString())));

                    }
                }

                return libros;
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
