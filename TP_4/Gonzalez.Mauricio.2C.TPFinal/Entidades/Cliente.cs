using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente:IExponerFicha
    {
        string nombre;
        string apellido;
        string dni;
        FormaDePago formaDePago;
        string email;
        string numeroDeTelefono;
        private List<Libro> librosCliente;
        public delegate void DelegadoLibroVendido();
        public DelegadoLibroVendido dvl;

        public enum FormaDePago
        {
            Efectivo,
            Debito,
            Credito
        }

        public Cliente()
        {
            this.LibrosCliente = new List<Libro>();
        }
        public Cliente(string nombre, string apellido, string dni, FormaDePago formaDePago, string email, string numeroDeTelefono):this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.FormaDePago1 = formaDePago;
            this.Email = email;
            this.NumeroDeTelefono = numeroDeTelefono;      
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
        
        public string Email { get => email; set => email = value; }
        public string NumeroDeTelefono { get => numeroDeTelefono; set => numeroDeTelefono = value; }
        public List<Libro> LibrosCliente { get => librosCliente; set => librosCliente = value; }
        public FormaDePago FormaDePago1 { get => formaDePago; set => formaDePago = value; }
    
        
        /// <summary>
        /// agrega el libro comprado por el cliente a su lista
        /// </summary>
        /// <param name="libro"></param>
        /// <returns>falso si se vende la ultima unidad del libro, sino true</returns>
        public bool ComprarLibro(Libro libro)
        {
            this.librosCliente.Add(libro);
            
            libro.Stock--;
            if(libro.Stock == 0)
            {

                return false;
            }
            return true;
        }

        

        /// <summary>
        /// Muestra ficha completa del cliente
        /// </summary>
        /// <returns>Retorna el string con todos los datos</returns>
        string IExponerFicha.MostrarFicha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.ToString());
            sb.AppendLine($"EMAIL: {this.Email}");
            sb.AppendLine($"TELEFONO: {this.NumeroDeTelefono}");
            sb.AppendLine($"FORMA DE PAGO: {this.FormaDePago1}");
            
            
            if (this.LibrosCliente.Count > 0)
            {
                sb.AppendLine($"Lista de libros comprados por {this.Nombre}");

                foreach (Libro libro in this.LibrosCliente)
                {
                    sb.AppendLine(libro.ToString());
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// llama al delegado para lograr cambiar el contenido del label del formulario inicial
        /// </summary>
        /// <param name="libro"></param>
        /// <returns>true si la venta se da de forma exitosa</returns>
        public bool AvisarVentaDeLibro(Libro libro)
        {
            dvl();
            if (ComprarLibro(libro))
            {
                
                
                
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(String.Format("NOMBRE: {0,-10} APELLIDO: {1,-10} DNI: {2,-8}", this.Nombre, this.Apellido, this.Dni));
            return builder.ToString();
        }

    }
}
