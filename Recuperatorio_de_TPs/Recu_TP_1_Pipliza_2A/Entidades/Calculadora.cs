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
}
