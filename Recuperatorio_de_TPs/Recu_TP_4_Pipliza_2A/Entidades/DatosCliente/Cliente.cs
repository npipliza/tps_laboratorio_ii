using System.Collections.Generic;
using System.Linq;

namespace Entidades
{
    public class Clientes
    {

        private string nombre;
        public List<Inventario> inventario;
        private int cantidadInventarios;
        private int idCliente;

        /// <summary>
        /// Propiedad de lectura y escritura para this.nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de this.cantidad de deposito
        /// </summary>
        public int CantidadInventarios
        {
            get
            {
                return this.cantidadInventarios;
            }
            set
            {
                this.cantidadInventarios = this.inventario.Count();
            }
        }
        /// <summary>
        /// Constructor privado que instanciará lista de deposito
        /// </summary>
        private Clientes()
        {
            inventario = new List<Inventario>();
        }

        /// <summary>
        /// Constructor de clientes, llamará al constructor privado
        /// </summary>
        /// <param name="nombre"></param>
        public Clientes(string nombre, int idCliente) : this()
        {
            this.nombre = nombre;
            this.idCliente = idCliente;
        }
        public Clientes(string nombre) : this()
        {
            this.nombre = nombre;
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

    }
}

