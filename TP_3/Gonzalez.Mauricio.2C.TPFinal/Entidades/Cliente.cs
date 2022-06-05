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

        public bool AgregarCliente(Libreria libreria)
        {
            foreach(Cliente cliente in libreria.clientes)
            {
                if(cliente.Nombre == this.Nombre)
                {
                    return false;
                }

            }
            return (libreria + this);
            
        }
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
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(String.Format("NOMBRE: {0,-10} APELLIDO: {1,-10} DNI: {2,-8}", this.Nombre, this.Apellido, this.Dni));
            return builder.ToString();
        }

    }
}
