using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Hace una operación aritmética entre dos números ingresados por el usuario.
        /// </summary>
        /// <param name="num1">Primer número.</param>
        /// <param name="num2">Segundo número.</param>
        /// <param name="operador">Tipo de operación a realizar.</param>
        /// <returns>El resultado de la operación.</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;

            switch (ValidarOperador(operador))
            {
                case '+':
                    resultado = num1 + num2;
                break;

                case '-':
                    resultado = num1 - num2;
                break;

                case '/':
                    resultado = num1 / num2;
                break;

                case '*':
                    resultado = num1 * num2;
                break;

                default:
                    resultado = num1 + num2;
                break;
            }
            return resultado;
        }
        /// <summary>
        /// Se valida que el operador ingresado sea +,-,/,*.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns> El operador seleccionado, ó en caso de no haber seleccionado uno, devuelve operador suma. </returns>
        private static char ValidarOperador(char operador) 
        {
            char retorno = '+';

            if (operador.Equals('+') || operador.Equals('-') || operador.Equals('/') || operador.Equals('*'))
            {
                retorno = operador;
            }
            return retorno;
        }
    }

/********************************************************************************************************************/
    class Conversor
    {
        /// <summary>
        /// Convierte un número de entero a binario.
        /// </summary>
        public static long DecimalBinario(int numeroC)
        {
            long binarioC     = 0;
            const int DIVISOR = 2;
            long digito       = 0;

            for (int i = numeroC % DIVISOR, j = 0; numeroC > 0; numeroC /= DIVISOR, i = numeroC % DIVISOR, j++)
            {
                digito    = i % DIVISOR;
                binarioC += digito * (long)Math.Pow(10, j);
            }
            return binarioC;
        }

        /// <summary>
        /// Convierte un número binario a entero.
        /// </summary>
        public static int BinarioDecimal(long binarioC)
        {
            int numeroC       = 0;
            int digito        = 0;
            const int DIVISOR = 10;

            for (long i = binarioC, j = 0; i > 0; i /= DIVISOR, j++)
            {
                digito = (int)i % DIVISOR;

                if (digito != 1 && digito != 0)
                {
                    return -1;
                }
                numeroC += digito * (int)Math.Pow(2, j);
            }
            return numeroC;
        }
    }
}
