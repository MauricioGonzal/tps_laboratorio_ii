using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClaseSerializadora<T>
    {
        static string ruta;

        static ClaseSerializadora()
        {
            ruta = AppDomain.CurrentDomain.BaseDirectory;
        }

        /// <summary>
        /// lee un archivo determinado y lo deserializa  al tipo de dato definido al momento de la invocacion
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>devuelve el tipo de dato obtenido de la deserializacion</returns>
        /// <exception cref="Exception"></exception>
        public static T Leer(string nombre)
        {
            string archivo = string.Empty;

            T datos = default;

            try
            {
                if (Directory.Exists(ruta))
                {
                    string[] archivosEnRuta = Directory.GetFiles(ruta);

                    foreach (string archivoEnRuta in archivosEnRuta)
                    {
                        if (archivoEnRuta.Contains(nombre))
                        {
                            archivo = archivoEnRuta;
                            break;
                        }
                    }

                    if (archivo != null)
                    {
                        string archivoJson = File.ReadAllText(archivo);
                        datos = JsonSerializer.Deserialize<T>(archivoJson);
                    }
                }



                return datos;
            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {archivo}");
            }
        }


        /// <summary>
        /// escribe en un archivo determinado resultado de serializar los datos recibidos como parametro
        /// </summary>
        /// <param name="datos"></param>
        /// <param name="archivo"></param>
        /// <exception cref="Exception"></exception>
        public static void Escribir(T datos, string archivo)
        {
            string completa = ruta + @"datos" + archivo + ".json";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    //lo crea si no existe
                    Directory.CreateDirectory(ruta);
                }

                string objetoJson = JsonSerializer.Serialize(datos);

                File.WriteAllText(completa, objetoJson);
            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {completa}");
            }

        }
}
    }
