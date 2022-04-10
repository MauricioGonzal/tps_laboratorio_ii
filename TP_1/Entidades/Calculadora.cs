using System;

namespace Entidades
{
    public static class Calculadora
    {
        private static char ValidarOperador(char operador)
        {
            if(operador!= '+' || operador!= '-' || operador!= '*' || operador!= '/')
            {
                return '+';
            }
            return operador;
        }

        public static double Operar(Operando num1, Operando num2, char operador)
        {
            if (ValidarOperador(operador))
            {

            }
        }
        
    }
}
