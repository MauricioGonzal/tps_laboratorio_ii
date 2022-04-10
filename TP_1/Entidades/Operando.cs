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

        public Operando()
        {
            this.numero = 0;
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando (string numero)
        {
             double.TryParse(numero, out this.numero);
        }

        private double ValidarOperando(string strNumero)
        {
            double validacion;
            validacion = 1;
            foreach(char c in strNumero)
            {
                if(c<='0' && c >= '9')
                {
                    validacion = 0;
                }
            }
            if(validacion != 0)
            {
                return Convert.ToDouble(strNumero);
            }

            return 0;
            
            
        }

        private bool EsBinario(string binario)
        {
            for(int i = 0; i<binario.Length; i++)
            {
                if(binario[i]!='0' || binario[i] != '1')
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
