using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes
    {

        private string nombre;
        public List<Inventario> inventario;
        private int cantidadDepositos;

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
        public int CantidadDepositos
        {
            get
            {
                return this.cantidadDepositos;
            }
            set
            {
                this.cantidadDepositos = this.inventario.Count();
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
        public Clientes(string nombre) : this()
        {
            this.nombre = nombre;
        }
    }

}

