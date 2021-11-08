using System.Collections.Generic;

namespace Entidades
{
    public class Inventario
    {
        private string nombreInventario;
        public List<DepositoP> deposito;

        public enum tipoPapel
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
        public tipoPapel TipoPapel
        {
            get; set;
        }
        /// <summary>
        /// Constructor donde se instancian las listas
        /// </summary>
        private Inventario()
        {
            deposito = new List<DepositoP>();
        }
        /// <summary>
        /// Constructor de la clase inventario, llama al constructor privado
        /// </summary>
        /// <param name="nombreInventario"></param>
        /// <param name="tipo"></param>
        public Inventario(string nombreInventario, tipoPapel tipo)
        {
            this.NombreInventario = nombreInventario;
            this.TipoPapel = tipo;
        }
    }
}