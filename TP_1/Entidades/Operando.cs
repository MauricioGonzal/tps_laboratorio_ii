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

        /// <summary>
        /// constructor que asigna el valor 0 al atributo numero
        /// </summary>
        public Operando(): this(0)
        {
            
        }

        /// <summary>
        /// asigna el valor recibido al atributo numero
        /// </summary>
        /// <param name="numero">dato en formato double</param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// asigna el valor recibido al atributo numero usando la propiedad Numero
        /// </summary>
        /// <param name="numero"> dato en formato string</param>
        public Operando (string numero)
        {
             this.Numero= numero;
        }

        /// <summary>
        /// Comprueba que el valor recibido es numérico, y lo retorna en formato double. Caso contrario, retorna 0
        /// </summary>
        /// <param name="strNumero">numero en formato string</param>
        /// <returns>retorna el numero convertido a tipo de dato double si es posible, sino retorna 0</returns>
        private double ValidarOperando(string strNumero)
        {
            double numero;

            if(double.TryParse(strNumero, out numero))
            {
                return numero;
            }

            return 0;
            
            
        }

        /// <summary>
        /// comprueba si el dato esta o no compuesto por 1 y 0
        /// </summary>
        /// <param name="binario"> dato a verificar en formato string</param>
        /// <returns>true si el dato es binario</returns>
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

        /// <summary>
        /// convierte el resultado a decimal si es posible
        /// </summary>
        /// <param name="binario">dato a convertir en formato string</param>
        /// <returns>devuelve el numero convertido en formato string si la operacion salio de forma exitosa, o retorna "Valor Invalido"</returns>
        public string BinarioDecimal(string binario)
        {
           if(EsBinario(binario)==true)
            {
                return Convert.ToInt32(binario, 2).ToString();
            }

            return "Valor Invalido";
        }

        /// <summary>
        /// convierte el resultado a binario si es posible
        /// </summary>
        /// <param name="numero">dato a convertir en formato double</param>
        /// <returns>devuelve el numero convertido en formato string si la operacion salio de forma exitosa, o retorna "Valor Invalido"</returns>
        public string DecimalBinario(double numero)
        {   
            
            numero = Math.Abs(numero);

            if(Convert.ToString((long)numero, 2)!=null)
            {
                return Convert.ToString((long)numero, 2);
            }

            return "Valor Invalido";
        }

        /// <summary>
        /// convierte el resultado a binario si es posible
        /// </summary>
        /// <param name="numero">dato a convertir en formato string</param>
        /// <returns>devuelve el numero convertido en formato string si la operacion salio de forma exitosa, o retorna "Valor Invalido"</returns>
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
