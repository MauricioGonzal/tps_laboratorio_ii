using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libreria:IExponerFicha
    {
        string nombre;
        public List<Libro> libros;
        public List<Cliente> clientes;
        int capacidadLibros;
        

        public int CapacidadLibros{ get => capacidadLibros; set => capacidadLibros = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        private Libreria()
        {
            libros = new List<Libro>();
            clientes = new List<Cliente>();
        }
        public Libreria(string nombre) :this()
        {
            this.nombre = nombre;
           
        }

        string IExponerFicha.MostrarFicha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Nombre);
            sb.AppendLine($"Cantidad de clientes activos: {this.clientes.Count}");
            sb.AppendLine($"Cantidad de libros en stock: {this.libros.Count}");
            return sb.ToString();
        }

        public bool VerificarReplicaDeLibro(Libro libro)
        {
            if (libro != null)
            {
                foreach(Libro item in this.libros)
                {
                    if(item.Nombre == libro.Nombre)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        

        public static bool operator +(Libreria libreria, Cliente cliente)
        {
            if(cliente is not null && libreria is not null)
            {
                libreria.clientes.Add(cliente);
                return true;

            }
            return false;   

        }

        public static bool operator ==(Libreria libreria, Cliente c)
        {
            
            if(libreria is not null && c is not null)
            {
                foreach (Cliente item in libreria.clientes)
                {
                    if (c.Nombre == item.Nombre)
                    {
                        return true;
                    }
                }
            }
            



            return false;
        }

        public static bool operator !=(Libreria libreria, Cliente c)
        {
            return !(libreria==c);
        }

        public static bool operator ==(Libreria libreria, Libro libro)
        {
           
                    
            if (libro is not null)
            {
                foreach (Libro item in libreria.libros)
                {
                    if (libro.Nombre == item.Nombre)
                    {
                        return true;

                    }
                }
            }
                    
                    
                
            
            return false;
        }

        public static bool operator !=(Libreria libreria, Libro libro)
        {
            return !(libreria==libro);
        } 

        public static bool operator +(Libreria libreria, Libro libro)
        {

            if(libreria is not null && libro is not null)
            {
                foreach (Libro item in libreria.libros)
                {
                    if (libro.Nombre == item.Nombre)
                    {
                        item.Stock++;
                        return true;

                    }
                }

            }     
            else
            {
                return false;
            }

           

            libreria.libros.Add(libro);
            return true;
        }

        public static Libreria operator - (Libreria libreria, Libro libro)
        {
            if (libreria is not null && libro is not null)
            {
               foreach(Libro item in libreria.libros)
                {
                    if(item.Nombre == libro.Nombre)
                    {
                        libreria.libros.Remove(item);
                    }
                    
                    
                }
                
                
            }
            return libreria;
        }

        public static Libreria operator -(Libreria libreria, Cliente c)
        {
            if(libreria is not null && c is not null)
            {
                foreach (Cliente item in libreria.clientes)
                {
                    if (c.Nombre == item.Nombre)
                    {
                        libreria.clientes.Remove(item);
                        break;
                       
                    }
                }
            }
            return libreria;
        }
    }
}
