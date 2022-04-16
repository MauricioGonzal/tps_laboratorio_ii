﻿using System;

namespace Entidades
{
    public static class Calculadora
    {
        private static char ValidarOperador(char operador)
        {

            if(operador!= '+' && operador!= '-' && operador!= '*' && operador!= '/')
            {
                return '+';
            }
            return operador;
        }

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
