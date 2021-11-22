using System.Collections.Generic;

namespace Entidades
{
    public class Inventario
    {

        private string nombreInventario;
        public List<DepositoP> deposito;
        public List<Informes> informes;
        private int idCliente;
        private int idInventario;


        public enum TipoPapel
        {
            EstucadoBrillante,
            EstucadoMate,
            Ilustracion,
            PapelPrensa,
            ObraAHuesado,
            Cartulina,
        }

        /// <summary>
        /// Propiedad de lectura y escritura de nombreInventario
        /// </summary>
        public string NombreInventario
        {
            get
            {
                return this.nombreInventario;
            }
            set
            {
                this.nombreInventario = value;
            }
        }

        /// <summary>
        /// Propiedad para el enum tipoPapel
        /// </summary>
        public TipoPapel TipoPapeles
        {
            get; set;
        }

        /// <summary>
        /// Propiedad para atributo idCliente
        /// </summary>
        public int IdCliente
        {
            get
            {
                return this.idCliente;
            }
            set
            {
                if (value < 1)
                {
                    this.idCliente = 1;
                }
                else
                {
                    this.idCliente = value;
                }
            }
        }
        /// <summary>
        /// Propiedad para atributo idInventario
        /// </summary>
        public int IdInventario
        {
            get
            {
                return this.idInventario;
            }
            set
            {
                if (value < 1)
                {
                    this.idInventario = 1;
                }
                else
                {
                    this.idInventario = value;
                }
            }
        }


        /// <summary>
        /// Constructor donde se instancian las listas
        /// </summary>
        private Inventario()
        {
            deposito = new List<DepositoP>();
            informes = new List<Informes>();
        }

        /// <summary>
        /// Constructor de la clase inventario, llama al constructor privado
        /// </summary>
        /// <param name="nombreInventario"></param>
        /// <param name="tipo"></param>
        public Inventario(string nombreInventario, TipoPapel tipo) : this()
        {
            this.NombreInventario = nombreInventario;
            this.TipoPapeles = tipo;
        }

        /// <summary>
        /// Constructor de la clase inventario, llama al constructor privado
        /// </summary>
        /// <param name="nombreInventario"></param>
        /// <param name="tipo"></param>
        public Inventario(string nombreInventario, TipoPapel tipo, int idCliente, int idInventario) : this()
        {
            this.NombreInventario = nombreInventario;
            this.TipoPapeles = tipo;
            this.idCliente = idCliente;
            this.IdInventario = idInventario;
        }

    }
}
