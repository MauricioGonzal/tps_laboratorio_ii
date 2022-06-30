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
        public List<Libro> proximosIngresos;
        public List<Reclamo> reclamos;
        public delegate void ReclamoDelegate(Reclamo r);
        public event ReclamoDelegate EventoReclamo;
        int capacidadLibros;
        

        public int CapacidadLibros{ get => capacidadLibros; set => capacidadLibros = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        private Libreria()
        {
            libros = new List<Libro>();
            clientes = new List<Cliente>();
            proximosIngresos = new List<Libro>();
            reclamos = new List<Reclamo>();
        }
        public Libreria(string nombre, List<Libro> proxIngresos) :this()
        {
            this.nombre = nombre;
            proximosIngresos= proxIngresos;
        }

        string IExponerFicha.MostrarFicha()
        {
            int stock = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Nombre);
            sb.AppendLine($"Cantidad de clientes activos: {this.clientes.Count}");
            foreach(Libro libro in this.libros)
            {
                stock += libro.Stock;
            }
            sb.AppendLine($"Cantidad de libros en stock: {stock}");
            return sb.ToString();
        }

        public static int OrdenarLibros(Libro l1, Libro l2)
        {
            return string.Compare(l1.Nombre, l2.Nombre);
        }

        public static int OrdenarClientes(Cliente l1, Cliente l2)
        {
            int retorno= string.Compare(l1.Nombre, l2.Nombre);
            if(retorno != 0)
            {
                return retorno;
            }
            else 
            {
                return string.Compare(l1.Apellido, l2.Apellido);    
            }
        }

        /// <summary>
        /// Verifica si el libro que se quiere registrar ya existe en la libreria
        /// </summary>
        /// <param name="libro"></param>
        /// <returns>true si ya existe, false si no</returns>
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

        public void MostrarListaReclamos()
        {
            if (EventoReclamo != null)
            {
                foreach(Reclamo item in this.reclamos)
                {
                    EventoReclamo(item);
                }
            }

        }

        
        /// <summary>
        /// agrega un cliente a la libreria
        /// </summary>
        /// <param name="libreria"></param>
        /// <param name="cliente"></param>
        /// <returns>true si la operacion se concreto, false si algun parametro es null</returns>
        public static bool operator +(Libreria libreria, Cliente cliente)
        {
            if(cliente is not null && libreria is not null && libreria!=cliente)
            {
                
                libreria.clientes.Add(cliente);
                return true;

            }
            return false;   

        }

        /// <summary>
        /// verifica si un cliente ya se encuentra en la libreria
        /// </summary>
        /// <param name="libreria"></param>
        /// <param name="c"></param>
        /// <returns>true si ya existe, false si no</returns>
        public static bool operator ==(Libreria libreria, Cliente c)
        {
            
            if(libreria is not null && c is not null)
            {
                foreach (Cliente item in libreria.clientes)
                {
                    if (c.Nombre == item.Nombre && c.Apellido==item.Apellido)
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

        /// <summary>
        /// verifica si un libro ya existe en la libreria
        /// </summary>
        /// <param name="libreria"></param>
        /// <param name="libro"></param>
        /// <returns>true si ya existe, false si no</returns>
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

        /// <summary>
        /// agrega un libro a la libreria si no existe
        /// </summary>
        /// <param name="libreria"></param>
        /// <param name="libro"></param>
        /// <returns></returns>
        public static bool operator +(Libreria libreria, Libro libro)
        {

            if(libreria is not null && libro is not null && !libreria.VerificarReplicaDeLibro(libro))
            {
                libreria.libros.Add(libro);
                return true;
            }     
            
                return false;
  
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
                        break;
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
