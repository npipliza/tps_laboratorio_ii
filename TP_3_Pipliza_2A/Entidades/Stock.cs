using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Stock
    {
        static public List<DepositoP> Inventario;
        static public List<Clientes> Clientes;
        private static Stock singleton;
        private static string rutaClientes = AppDomain.CurrentDomain.BaseDirectory + "listaClientes";
        static public List<DepositoP> nuevasEdiciones_Inventario = new List<DepositoP>();

        /// <summary>
        /// Constructor sin paramatros que instanciara las listas Inventario 
        /// </summary>
        public Stock()
        {
            Inventario = new List<DepositoP>();
            Clientes = new List<Clientes>();
            Clientes.AddRange(Controller.Deserializar(Clientes, rutaClientes));
        }
        /// <summary>
        /// Propiedad que permitirá la instancia de la clase Stock sólo si es la primera vez que se llama a la propiedad.
        /// </summary>
        /// <returns></returns>
        public static Stock GetStock()
        {
            if (Stock.singleton is null)
            {
                Stock.singleton = new Stock();
            }
            return Stock.singleton;
        }

        /// <summary>
        /// Recibe una lista por parámetro y revisa que elementos tiene en común con Stock.Inventario, los agrega a una nueva lista y la devuelve.
        /// </summary>
        /// <param name="listaRevisar"></param>
        /// <param name="nuevaLista"></param>
        /// <returns></returns>
        public static List<DepositoP> revisarIgualdad(List<DepositoP> listaRevisar, List<DepositoP> nuevaLista)
        {
            foreach (DepositoP inventarioLista in listaRevisar)
            {
                foreach (DepositoP publiStock in Inventario)
                {
                    if (publiStock.Codigo == inventarioLista.Codigo && publiStock.eFormato == inventarioLista.eFormato)
                    {
                        nuevaLista.Add(publiStock);
                        continue;
                    }
                }
            }
            return nuevaLista;
        }
        /// <summary>
        /// Sobrecarga del operador == que verifica si la deposito pasada por parámetro es igual a q esta dentro de la lista.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator ==(Stock s, DepositoP m)
        {

            foreach (DepositoP merc in Stock.Inventario)
            {
                if (merc.Codigo == m.Codigo)
                {
                    merc.Cantidad += m.Cantidad;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga del operador != que verifica si deposito pasado por parámetro es igual a  q esta dentro de la lista, retorna lo opuesto al ==
        /// </summary>
        /// <param name="s"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator !=(Stock s, DepositoP m)
        {
            return !(s == m);
        }

        /// <summary>
        /// Sobrecarga del operador + verifica si lo recibido por parametro es igual a la lista, si no lo es, la agrega.
        /// Si es igual, sumará 1 unidad a la cantidad.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator +(Stock s, DepositoP m)
        {
            if ((s != m))
            {
                Stock.Inventario.Add(m);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Cuando se agrega un obj del tipo mercadería al datagrid, se agrega a ese deposito. Para eso itera sobre clientes y si es igual al pasado por parámetro. si corresponde lo agrega
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="cliente"></param>
        /// <param name="deposito"></param>
        public static void agregarMercaderia_alDeposito(Object obj, string cliente, string deposito)
        {
            foreach (Clientes clientesito in Clientes)
            {
                if (cliente == clientesito.Nombre)
                {
                    foreach (Inventario dep in clientesito.inventario)
                    {
                        if (obj.GetType() == typeof(DepositoP) && deposito == dep.NombreInventario)
                        {
                            dep.deposito.Add((DepositoP)obj);
                            return;
                        }
                    }
                }
            }
        }

        public static List<DepositoP> revisarIgualdadDepositoSeleccionado(DepositoP depo, List<DepositoP> listaDepositos)
        {
            foreach (Clientes clientesito in Stock.Clientes)
            {
                foreach (Inventario inv in clientesito.inventario)
                {

                    foreach (DepositoP deposito in inv.deposito)
                    {

                        if (deposito.Codigo == depo.Codigo && deposito.eFormato == depo.eFormato)
                        {
                            listaDepositos.Add(deposito);
                            break;
                        }
                    }
                }
            }
            return listaDepositos;
        }

    }
}
