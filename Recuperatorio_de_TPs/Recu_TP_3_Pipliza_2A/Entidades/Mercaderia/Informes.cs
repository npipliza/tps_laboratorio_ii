using System;
using System.Text;

namespace Entidades
{
    public class Informes : Mercaderia
    {
        private DateTime fechaCorreccion;

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
    }
}
