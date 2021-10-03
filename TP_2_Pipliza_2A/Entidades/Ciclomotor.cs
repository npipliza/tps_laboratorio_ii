using System;
using System.Text;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        #region Propiedades
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
       {
            get
            {
                return ETamanio.Chico;
            }
        }
        #endregion

        #region Método
        /// <summary>
        /// Muestra string de datos Ciclomotor.
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());

            return sb.ToString();
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor Ciclomotor.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }
        #endregion
    }
}
