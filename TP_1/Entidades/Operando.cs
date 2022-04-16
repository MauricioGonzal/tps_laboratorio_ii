using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        /// <summary>
        /// cambia el atributo numero que se recibe como string en 
        /// un valor de tipo double que sea valido para operar
        /// </summary>
        public string Numero
        {
            set
            {
                numero = ValidarOperando(value);
            }
        }

        public Operando(): this(0)
        {
            
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando (string numero)
        {
             this.Numero= numero;
        }

        private double ValidarOperando(string strNumero)
        {
            double numero;

            if(double.TryParse(strNumero, out numero))
            {
                return numero;
            }

            return 0;
            
            
        }

        private bool EsBinario(string binario)
        {
            foreach (char caracter in binario)
            {
                if (caracter != '0' && caracter != '1')
                {
                    return false;
                }
            }
            

            return true;
        }

        public string BinarioDecimal(string binario)
        {
           if(EsBinario(binario)==true)
            {
                return Convert.ToInt32(binario, 2).ToString();
            }

            return "Valor Invalido";
        }

        public string DecimalBinario(double numero)
        {   
            
            numero = Math.Abs(numero);

            if(Convert.ToString((long)numero, 2)!=null)
            {
                return Convert.ToString((long)numero, 2);
            }

            return "Valor Invalido";
        }

        public string DecimalBinario(string numero)
        {
            double datoNumerico;
            if(double.TryParse(numero, out datoNumerico))
            {
                return DecimalBinario(datoNumerico);
            }

            return "Valor Invalido";

            
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero- n2.numero;
        }

        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator /(Operando n1, Operando n2)
        {
            return n1.numero / n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }



    }
}
