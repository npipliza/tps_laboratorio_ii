﻿using System;
using System.Text;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        #region Atributos
        private EMarca marca;
        private string chasis;
        private ConsoleColor color;
        #endregion

        #region Propiedades
        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get; }
        #endregion

        #region Método
        /// <summary>
        /// Muetra todos los datos del Vehiculo.
        /// </summary>
        /// <returns>this</returns>        
        public virtual string Mostrar()
        {
            return (string)this;
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Casteo de forma explicita a string
        /// </summary>
        /// <param name="p">Datos vehículo</param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS : {0}\r\n", p.chasis);
            sb.AppendFormat("MARCA  : {0}\r\n", p.marca);
            sb.AppendFormat("COLOR  : {0}\r\n", p.color);
            sb.AppendLine("---------------------");
            sb.AppendLine("");
            sb.AppendFormat("TAMAÑO : {0}\r\n", p.Tamanio);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        /// 
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca  = marca;
            this.color  = color;
        }
        #endregion

        #region Enumerados
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }

        public enum ETamanio
        {
            Chico, Mediano, Grande
        }
        #endregion
    }
}