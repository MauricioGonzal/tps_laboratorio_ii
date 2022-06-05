using System;
using System.Text;

namespace Entidades
{
    public class Libro:IExponerFicha
    {
        string nombre;
        string autor;
        Categorias categoria;
        int stock;
        float precio;

        public enum Categorias
        {
            Accion,
            Drama,
            Ficcion,
            Enciclopedia,
            Terror
        }
        public Libro(string nombre, string autor, Categorias categoria, int stock, float precio)
        {
            this.Nombre = nombre;
            this.Autor = autor;
            this.Stock = stock;
            this.Precio = precio;
            this.categoria = categoria;
            
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Autor { get => autor; set => autor = value; }
        public int Stock
        {
            get
            {
                return stock;
            }
            set
            {
                this.stock = value;
            }
        }
        public float Precio { get => precio; set => precio = value; }
        public Categorias Categoria { get => categoria; set => categoria = value; }

        /// <summary>
        /// Muestra ficha completa del libro
        /// </summary>
        /// <returns>Retorna el string con todos los datos</returns>
        string IExponerFicha.MostrarFicha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.ToString());
            sb.AppendLine($"CATEGORIA: {this.Categoria}");
            sb.AppendLine($"STOCK DISPONIBLE: {this.Stock}");
            sb.AppendLine($"PRECIO: {this.Precio}");
            return sb.ToString();

        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(String.Format("NOMBRE: {0,-30} AUTOR: {1,-10}", this.Nombre, this.Autor));
            return builder.ToString();
        }
    }
}
