using System;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        /// <summary>
        /// Setea el valor del atributo privado número.
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = this.ValidarOperando(value);
            }
        }

        /// <summary>
        /// Convierte el número que ingresó el usuario de binario a decimal.
        /// </summary>
        /// <param name="binarioC">string del binario a convertir</param>
        /// <returns>Si realizó la conversión, devuelve el número convertido a binario. Sino, devuelve "Valor inválido"</returns>
        public string BinarioDecimal(string binarioC)
        {
            int numeroDecimal = 0;

            if (EsBinario(binarioC))
            {
                char[] binarioCharArray = binarioC.ToCharArray();
                Array.Reverse(binarioCharArray);

                for (int i = 0; i < binarioCharArray.Length; i++)
                {
                    if (binarioCharArray[i] == '1')
                    {
                        if (i == 0)
                        {
                            numeroDecimal += 1;
                        }
                        else
                        {
                            numeroDecimal += (int)Math.Pow(2, i);
                        }
                    }
                }
                return numeroDecimal.ToString();
            }
            else
            {
                return "Valor inválido.";
            }
        }

        /// <summary>
        /// Convierte el número que ingresó el usuario de decimal double a binario.
        /// </summary>
        /// <param name="numeroC">string del decimal a convertir</param>
        /// <returns>Si realizó la conversión, devuelve el número convertido a decimal. Sino, devuelve "Valor inválido"</returns>
        public string DecimalBinario(double numeroC)
        {
            int numeroEntero = (int)numeroC;

            if (numeroEntero >= 0)
            {
                if (numeroEntero == 0)
                {
                    return "0";
                }
                else
                {
                    string binario = "";
                    while (numeroEntero > 0)
                    {

                        if (numeroEntero % 2 == 0)
                        {
                            binario = "0" + binario;
                        }
                        else
                        {
                            binario = "1" + binario;
                        }
                        numeroEntero = numeroEntero / 2;
                    }
                    return binario;
                }
            }
            else
            {
                return "Valor inválido.";
            }
        }
        /// <summary>
        /// Convierte el número que ingresó el usuario de decimal string a binario.
        /// </summary>
        /// <param name="numeroC">string del decimal a convertir</param>
        /// <returns>Si realizó la conversión, devuelve una llamada al método que recibe double para convertir a binario. Sino, devuelve "Valor inválido"</returns>
        public string DecimalBinario(string numeroC)
        {
            if (double.TryParse(numeroC, out double num))
            {
                return DecimalBinario(num);
            }
            else
            {
                return "Valor inválido";
            }
        }

        /// <summary>
        /// Verifica que un número sea entero binario (sólo 0 y 1).
        /// </summary>
        /// <param name="binario">Cadena de caractéres a chequear.</param>
        /// <returns>Devuelve true si es binario y false si no lo es.</returns>
        private static bool EsBinario(string binario)
        {
            bool esBinario = true;

            foreach (char i in binario)
            {
                if (i != '0' && i != '1')
                {
                    esBinario = false;
                    break;
                }
            }
            return esBinario;
        }

        /********************************************************************************************************************/
        /// <summary>
        /// Constructor sin parámetros. Por defecto, el valor de número es el 0.
        /// </summary>
        public Operando() : this(0)
        {
        }

        /// <summary>
        /// Constructor que recibe un double.
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor que recibe un string.
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        /// <summary>
        /// Sobrecarga del operador + para que sume dos objetos de la clase Número.
        /// </summary>
        /// <param name="n1">Primer dato a operar.</param>
        /// <param name="n2">Segundo dato a operar.</param>
        /// <returns>El resultado de la suma, fto Double.</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }//fin operador +

        /// <summary>
        /// Sobrecarga del operador - para que reste dos objetos de la clase Número.
        /// </summary>
        /// <param name="n1">Primer dato a operar.</param>
        /// <param name="n2">Segundo dato a operar.</param>
        /// <returns>El resultado de la resta, fto Double.</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }//fin operador -

        /// <summary>
        /// Sobrecarga del operador / para que divida dos objetos de la clase Número.
        /// </summary>
        /// <param name="n1">Primer dato a operar.</param>
        /// <param name="n2">Segundo dato a opera.r</param>
        /// <returns>El resultado de la división, fto Double.</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
        }//fin operador /

        /// <summary>
        /// Sobrecarga del operador * para que multiplique dos objetos de la clase Número.
        /// </summary>
        /// <param name="n1">Primer dato a operar.</param>
        /// <param name="n2">Segundo dato a opera.r</param>
        /// <returns>El resultado de la multiplicación, fto Double.</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }//fin operador *

        /********************************************************************************************************************/
        /// <summary>
        /// Valida que un operando ingresado como string sea un número y lo devuelve como double.
        /// </summary>
        /// <param name="strNumero">Cadena de caracteres a validar.</param>
        /// <returns>El operando en double si se valida, o 0 si no se puede validar.</returns>
        private double ValidarOperando(string strNumero)
        {
            double retorno = 0;
            double var;

            if (double.TryParse(strNumero.Replace(".", ","), out var))
            {
                retorno = var;
            }
            return retorno;
        }//fin ValidarOperando
    }
}//fin namespace Entidades
