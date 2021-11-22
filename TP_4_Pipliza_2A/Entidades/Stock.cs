using System;
using System.Collections.Generic;

namespace Entidades
{
    public sealed class Stock
    {
        static public List<DepositoP> Deposito;
        static public List<Informes> Informes;
        static public List<Clientes> Clientes;
        private static Stock singleton;
        static public List<Inventario> Inventarios;

      //  private static string rutaClientes = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\listaClientes.xml";

        static public List<DepositoP> nuevasEdiciones_Depositos = new List<DepositoP>();
        static public List<Informes> nuevasEdiciones_Informes = new List<Informes>();

        /// <summary>
        /// Constructor sin paramatros que instanciara las listas depositos y Informes
        /// </summary>
        public Stock()
        {
            Deposito = new List<DepositoP>();
            Informes = new List<Informes>();
            Clientes = new List<Clientes>();
           // Clientes.AddRange(Controller.Deserializar(Clientes, rutaClientes));
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
        public static List<DepositoP> RevisarIgualdad(List<DepositoP> listaRevisar, List<DepositoP> nuevaLista)
        {
            foreach (DepositoP depositoLista in listaRevisar)
            {
                foreach (DepositoP depoStock in Deposito)
                {
                    if (depoStock.Codigo == depositoLista.Codigo && depoStock.EFormato == depositoLista.EFormato)
                    {
                        nuevaLista.Add(depoStock);
                        continue;
                    }
                }
            }
            return nuevaLista;
        }
        /// <summary>
        /// Sobrecarga. Recibe una lista por parámetro y revisa que elementos tiene en común con Stock.Depositos, los agrega a una nueva lista y la devuelve.
        /// </summary>
        /// <param name="listaRevisar"></param>
        /// <param name="nuevaLista"></param>
        /// <returns></returns>
        public static List<Informes> RevisarIgualdad(List<Informes> listaRevisar, List<Informes> nuevaLista)
        {
            foreach (Informes informeLista in listaRevisar)
            {
                foreach (Informes informeStock in Informes)
                {
                    if (informeStock.Codigo == informeLista.Codigo)
                    {
                        nuevaLista.Add(informeStock);
                        continue;
                    }
                }
            }
            return nuevaLista;
        }
        /// <summary>
        /// Sobrecarga del operador == que verifica si deposito pasado por parámetro es igual a la contenida dentro de la lista.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator ==(Stock s, DepositoP m)
        {

            foreach (DepositoP merc in Stock.Deposito)
            {
                if (merc.Codigo == m.Codigo)
                {
                    merc.Kg += m.Kg;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga del operador == que verifica si la informe pasada por parámetro es igual al dentro de la lista.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator ==(Stock s, Informes m)
        {
            foreach (Informes merc in Stock.Informes)
            {
                if (merc.Codigo == m.Codigo)
                {
                    merc.Kg += m.Kg;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga del operador != que verifica si el deposito pasada por parámetro es igual al de la lista, retorna lo opuesto al ==
        /// </summary>
        /// <param name="s"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator !=(Stock s, DepositoP m)
        {
            return !(s == m);
        }
        /// <summary>
        /// Sobrecarga del operador != que verifica si la informe pasada por parámetro es igual al de la lista, retorna lo opuesto al ==
        /// </summary>
        /// <param name="s"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator !=(Stock s, Informes m)
        {
            return !(s == m);
        }

        /// <summary>
        /// Sobrecarga del operador + verifica si lo recibido por parametro es igual a la lista, si no la agrega.
        /// Si es igual, sumará 1 unidad a la cantidad.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator +(Stock s, DepositoP m)
        {
            if ((s != m))
            {
                Stock.Deposito.Add(m);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador + verifica si lo recibido por parametro es igual a la lista, si no lo es, la agrega.
        /// Si es igual, sumará 1 unidad a la cantidad.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator +(Stock s, Informes m)
        {
            if (s != m)
            {
                Stock.Informes.Add(m);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Cuando se agrega un obj del tipo mercadería al datagrid, se agrega a ese iInventario. Para eso itera sobre clientes y si es igual al pasado por parámetro, 
        /// busca hasta encontrar iInventario y si es del tipo deposito, lo agrega a esa lista. si es del tipo informes, lo agrega a esa lista.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="cliente"></param>
        /// <param name="inventario"></param>
        public static void AgregarMercaderia_alInventario(Object obj, string cliente, string inventario)
        {
            foreach (Clientes clientesito in Clientes)
            {
                if (cliente == clientesito.Nombre)
                {
                    foreach (Inventario inv in clientesito.inventario)
                    {
                        if (obj.GetType() == typeof(DepositoP) && inventario == inv.NombreInventario)
                        {
                            inv.deposito.Add((DepositoP)obj);
                            return;
                        }
                        if (obj.GetType() == typeof(Informes) && inventario == inv.NombreInventario)
                        {
                            inv.informes.Add((Informes)obj);
                            return;
                        }
                    }
                }
            }
        }

        public static List<Inventario> RevisarIgualdadDepositoSeleccionado(DepositoP depo, List<Inventario> listaInventarios)
        {
            foreach (Clientes clientesito in Stock.Clientes)
            {
                foreach (Inventario inv in clientesito.inventario)
                {
                    foreach (DepositoP deposito in inv.deposito)
                    {

                        if (deposito.Codigo == depo.Codigo && deposito.EFormato == depo.EFormato)
                        {
                            listaInventarios.Add(inv);
                            break;
                        }
                    }
                }
            }
            return listaInventarios;
        }

        public static string RecuentoDePapelesEnStock(DepositoP depo, Inventario.TipoPapel tipo)
        {
            int contadorEB = 0;
            int contadorEM = 0;
            int contadorI = 0;
            int contadorPP = 0;
            int contadorOA = 0;
            int contadorC = 0;
            string mayorStock;
            foreach (Clientes clientesito in Stock.Clientes)
            {
                foreach (Inventario inv in clientesito.inventario)
                {
                    foreach (DepositoP deposito in inv.deposito)
                    {

                        switch (tipo)
                        {
                            case Inventario.TipoPapel.EstucadoBrillante:
                                if (deposito.TipoPapel == "Estucado Brillante")
                                {
                                    contadorEB++;
                                }
                                break;

                            case Inventario.TipoPapel.EstucadoMate:
                                if (deposito.TipoPapel == "Estucado Mate")
                                {
                                    contadorEM++;
                                }
                                break;

                            case Inventario.TipoPapel.Ilustracion:
                                if (depo.TipoPapel == "Ilustracion")
                                {
                                    contadorI++;
                                }
                                break;

                            case Inventario.TipoPapel.PapelPrensa:
                                if (depo.TipoPapel == "Papel Prensa")
                                {
                                    contadorPP++;
                                }
                                break;

                            case Inventario.TipoPapel.ObraAHuesado:
                                if (depo.TipoPapel == "Obra Ahuesado")
                                {
                                    contadorOA++;
                                }
                                break;

                            case Inventario.TipoPapel.Cartulina:
                                if (depo.TipoPapel == "Cartulina")
                                {
                                    contadorC++;
                                }
                                break;

                        }
                    }
                }
            }

            if (contadorEB > contadorEM && contadorEB > contadorI && contadorEB > contadorPP && contadorEB > contadorOA && contadorEB > contadorC)
            {
                mayorStock = "Estucado Brillante";
            }
            else if (contadorEM > contadorI && contadorEM > contadorPP && contadorEM > contadorOA && contadorEM > contadorC)
            {
                mayorStock = "Estucado Mate";
            }
            else if (contadorI > contadorPP && contadorI > contadorOA && contadorI > contadorC)
            {
                mayorStock = "Ilustración";
            }
            else if (contadorPP > contadorOA && contadorPP > contadorC)
            {
                mayorStock = "Papel Prensa";
            }
            else if (contadorOA > contadorC)
            {
                mayorStock = "Obra Ahuesado";
            }
            else
            {
                mayorStock = "Cartulina";
            }
            return mayorStock;

        }
    

        public static void RevisarIgualdadInventario(List<Informes> listaRevisar, List<Informes> listaModificar, Inventario inventario)
        {
            foreach (Informes informesLista in listaRevisar)
            {
                foreach (Informes informesStock in inventario.informes)
                {
                    if (informesStock.Codigo == informesLista.Codigo)
                    {
                        listaModificar.Add(informesStock);
                        continue;
                    }
                }
            }

        }

        public static void RevisarIgualdadInventario(List<DepositoP> listaRevisar, List<DepositoP> listaModificar, Inventario inventario)
        {
            foreach (DepositoP depositoLista in listaRevisar)
            {
                foreach (DepositoP publiStock in inventario.deposito)
                {
                    if (publiStock.Codigo == depositoLista.Codigo && publiStock.EFormato == depositoLista.EFormato)
                    {
                        listaModificar.Add(publiStock);
                        continue;
                    }
                }
            }

        }
    }
}
