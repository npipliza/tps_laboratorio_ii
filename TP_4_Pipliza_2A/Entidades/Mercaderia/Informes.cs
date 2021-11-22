using System;
using System.Text;

namespace Entidades
{
    public class Informes : Mercaderia
    {
        private DateTime fechaCorreccion;
        public int[] idInventariosInformes;
        private int idInforme;

        /// <summary>
        /// Propiedad FechaCorreccion de lectura y escritura
        /// </summary>
        public DateTime FechaCorreccion
        {
            get
            {
                return this.fechaCorreccion;
            }
            set
            {
                if (value.GetType() == typeof(DateTime))
                {
                    this.fechaCorreccion = value;
                }
            }
        }
        /// <summary>
        /// Constructor de defecto para la clase informe, permite serializar
        /// </summary>
        public Informes()
        {

        }
        /// <summary>
        /// Constructor de la clase informe, llamará a la base: Mercadería 
        /// </summary>
        /// <param name="tipoPapel"></param>
        /// <param name="gramaje"></param>
        /// <param name="usd"></param>
        /// <param name="codigo"></param>
        /// <param name="kg"></param>
        /// <param name="fechaCorreccion"></param>
        public Informes(string tipoPapel, int gramaje, string usd, string codigo, int kg, DateTime fechaCorreccion)
            : base(tipoPapel, gramaje, usd, codigo, kg)
        {
            this.FechaCorreccion = fechaCorreccion;
        }

        public Informes(string tipoPapel, int gramaje, string usd, string codigo, int kg, DateTime fechaCorreccion, int idInforme)
           : base(tipoPapel, gramaje, usd, codigo, kg)
        {
            this.FechaCorreccion = fechaCorreccion;
            this.idInforme = idInforme;
        }

        private int IdInforme
        {
            get
            {
                return this.idInforme;
            }
            set
            {
                if (value < 0)
                {
                    this.idInforme = 0;
                }
                else
                {
                    this.idInforme = value;
                }
            }
        }

        public override void obtenerIdInventarios(int[] idInventarios)
        {
            this.idInventariosInformes = idInventarios;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("TipoPapel: {0}", this.TipoPapel));
            sb.AppendLine(string.Format("Gramaje: {0}", this.Gramaje));
            sb.AppendLine(string.Format("Código: {0}", this.Codigo));
            sb.AppendLine(string.Format("USD: {0}", this.USD));
            sb.AppendLine(string.Format("Fecha de corección: {0}", this.FechaCorreccion));

            return sb.ToString();
        }

    }
}
