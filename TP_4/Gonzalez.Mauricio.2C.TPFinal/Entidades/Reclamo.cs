using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reclamo
    {
        public enum Tipo
        {
            Incompleto,
            Manchado,
            Borrado
            

        }

        Tipo tipo;
        Cliente cliente;
        Libro libro;

        public Tipo Tipo1 { get => tipo; set => tipo = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Libro Libro { get => libro; set => libro = value; }

        public Reclamo(Tipo t, Cliente c, Libro l)
        {
            this.tipo = t;
            this.cliente = c;
            this.libro = l;

        }

        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tipo de reclamo: " + this.tipo.ToString());
            sb.AppendLine("Libro: " + this.libro);
            sb.AppendLine("Cliente: " + this.cliente.ToString());
            return sb.ToString();
        }

    }
}
