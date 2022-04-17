using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// valida que el operador recibido sea +, -, / o *. Caso contrario retornará +
        /// </summary>
        /// <param name="operador">operador a validar</param>
        /// <returns>devuelve el operador validado y con el que trabajara el programa</returns>
        private static char ValidarOperador(char operador)
        {

            if(operador!= '+' && operador!= '-' && operador!= '*' && operador!= '/')
            {
                return '+';
            }
            return operador;
        }

        /// <summary>
        /// valida y realiza la operación pedida entre ambos números.
        /// </summary>
        /// <param name="num1">primer operando</param>
        /// <param name="num2">segundo operando</param>
        /// <param name="operador"></param>
        /// <returns>el resultado de la operacion</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado=0;
            char operadorAux = ValidarOperador(operador);
            

            switch (operadorAux)
            {
                case '-':
                    resultado = num1 - num2;
                    break;
                case '/':
                    resultado= num1 / num2;
                    break;
                case '*':
                    resultado= num1 * num2;
                    break;
                case '+':
                    resultado = num1 + num2;
                    break;
            }

            return resultado;
           
        }
        
    }

}
