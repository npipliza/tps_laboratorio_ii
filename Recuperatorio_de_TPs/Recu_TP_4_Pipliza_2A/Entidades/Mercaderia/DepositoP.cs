using System;
using System.Text;

namespace Entidades
{
    [Serializable]
    public class DepositoP : Mercaderia
    {
        private int nroRack;
        public int[] idInventariosDepositos;

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
        public int NroRack
        {
            get
            {
                return this.nroRack;
            }
            set
            {
                if (nroRack <= 0)
                {
                    this.nroRack = 1;
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
        /// <param name="nroRack"></param>
        /// <param name="formato"></param>
        /// <param name="tipoPapel"></param>
        /// <param name="gramaje"></param>
        /// <param name="usd"></param>
        /// <param name="codigo"></param>
        /// <param name="kg"></param>
        public DepositoP(int nroRack, Formato formato, string tipoPapel, int gramaje, string usd, string codigo, int kg) 
            : base(tipoPapel, gramaje, usd, codigo, kg)
        {
            this.nroRack = nroRack;
            this.EFormato = formato;
        }

        public override void obtenerIdInventarios(int[] idInventarios)
        {
            this.idInventariosDepositos = idInventarios;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("TipoPapel: {0}", this.TipoPapel));
            sb.AppendLine(string.Format("Gramaje: {0}", this.Gramaje));
            sb.AppendLine(string.Format("Código: {0}", this.Codigo));
            sb.AppendLine(string.Format("Precio: {0}", this.USD));
            sb.AppendLine(string.Format("Formato: {0}", this.EFormato));

            return sb.ToString();
        }

    }
}
