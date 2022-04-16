using System;

namespace biblioteca
{
    public class Calculadora
    {
        public static float Calcular (float primerOperando, float segundoOperando, char
            operacion)
        {
            float resultado;
            switch (operacion)
            {
                case '+':

                    resultado = primerOperando + segundoOperando;
                    break;
                case '-':
                    resultado = primerOperando - segundoOperando;
                    break;
                case '*':
                    resultado= primerOperando * segundoOperando;
                    break;
                default:
                    if (Validar(segundoOperando))
                    {
                        resultado= primerOperando / segundoOperando;
                    }
                    break;


            }
            
        }

        private static bool Validar(float segundoOperando)
        {
            return segundoOperando != 0;
        }
    }
}
