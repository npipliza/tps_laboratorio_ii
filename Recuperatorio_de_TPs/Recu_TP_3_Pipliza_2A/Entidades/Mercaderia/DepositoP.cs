using System;

namespace Entidades
{
    [Serializable]
    public class DepositoP : Mercaderia
    {
        private int nroRacks;

        public enum Formato
        {
            Bobina,
            Hojas,
        }

        /// <summary>
        /// Propiedad para el enumerado Formato de lectura y escritura
        /// </summary>
        public Formato EFormato
        {
            get; set;
        }

        /// <summary>
        /// Propiedad para el atributo nroRacks de lectura y escritura. En su setter verifica que no tenga un número negativo y lo settea en 1.
        /// </summary>
        public int NroRacks
        {
            get
            {
                return this.nroRacks;
            }
            set
            {
                if (nroRacks <= 0)
                {
                    this.nroRacks = 1;
                }
            }
        }

        /// <summary>
        /// Constructor de defecto para la clase deposito
        /// </summary>
        public DepositoP()
        {

        }

        /// <summary>
        /// Constructor para la clase deposito, llamará a su base en Mercadería
        /// </summary>
        /// <param name="nroRacks"></param>
        /// <param name="formato"></param>
        /// <param name="tipoPapel"></param>
        /// <param name="gramaje"></param>
        /// <param name="usd"></param>
        /// <param name="codigo"></param>
        /// <param name="kg"></param>
        public DepositoP(int nroRacks, Formato formato, string tipoPapel, int gramaje, string usd, string codigo, int kg) 
            : base(tipoPapel, gramaje, usd, codigo, kg)
        {
            this.nroRacks = nroRacks;
            this.EFormato = formato;
        }
    }
}
