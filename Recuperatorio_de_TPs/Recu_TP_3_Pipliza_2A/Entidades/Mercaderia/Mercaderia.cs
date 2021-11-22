using System;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Informes))]
    [XmlInclude(typeof(DepositoP))]

    public abstract class Mercaderia
    {
        private string tipoPapel;
        private int gramaje;
        private string usd;
        private string codigo;
        private int kg;

        /// <summary>
        ///  Propiedad para el atributo gramaje de lectura y escritura
        /// </summary>
        public int Gramaje
        {
            get
            {
                return this.gramaje;
            }
            set
            {
                this.gramaje = value;
            }
        }

        /// <summary>
        /// Propiedad para el atributo tipoPapel de lectura y escritura
        /// </summary>
        public string TipoPapel
        {
            get
            {
                return this.tipoPapel;
            }
            set
            {
                this.tipoPapel = value;
            }
        }

        /// <summary>
        /// Propiedad para el atributo usd de lectura y escritura
        /// </summary>
        public string USD
        {
            get
            {
                return this.usd;
            }
            set
            {
                this.usd = value;
            }
        }

        /// <summary>
        /// Propiedad para el atributo código de lectura y escritura
        /// </summary>
        public string Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }

        /// <summary>
        /// Propiedad para el atributo cantidad de lectura y escritura
        /// </summary>
        public int Kg
        {
            get
            {
                return this.kg;
            }
            set
            {
                if (value < 0)
                    this.kg = 0;
                else
                    this.kg = value;
            }
        }

        /// <summary>
        ///  Constructor de mercadería, establecerá los valores pasados por parámetro.
        /// </summary>
        /// <param name="tipoPapel"></param>
        /// <param name="gramaje"></param>
        /// <param name="usd"></param>
        /// <param name="codigo"></param>
        public Mercaderia(string tipoPapel, int gramaje, string usd, string codigo, int kg)
        {
            this.tipoPapel = tipoPapel;
            this.gramaje = gramaje;
            this.usd = usd;
            this.codigo = codigo;
            this.kg = kg;
        }

        /// <summary>
        /// Constructor de defecto para la clase Mercadería
        /// </summary>
        public Mercaderia()
        {
        }

    }
}
