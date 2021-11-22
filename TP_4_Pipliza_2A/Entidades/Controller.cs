using System;
using System.Collections.Generic;
using System.Linq;
using Serializacion;

namespace Entidades
{
    public static class Controller
    {
        /// <summary>
        /// Itera sobre lista de inventarios hasta encontrar el pasado por parametro y retorna su ID.
        /// </summary>
        /// <param name="nombreInventario"></param>
        /// <returns></returns>
        public static int BuscarInventarioPorId(string nombreInventario)
        {
            foreach (Inventario inventario in Stock.Inventarios)
            {
                if (nombreInventario == inventario.NombreInventario)
                {
                    return inventario.IdInventario;
                }
            }
            return 0;
        }
        /// <summary>
        /// Agrega la depositoción recibida por parámetro a todos los inventarios que la tengan. Recibe idinventarios que son todos los id de inventarios que la tienen.
        /// </summary>
        /// <param name="idInventarios"></param>
        /// <param name="depo"></param>
        public static void AgregarDepositosAInventarios(int[] idInventarios, DepositoP depo)
        {
            try
            {
                for (int i = 0; i < Stock.Inventarios.Count; i++)
                {
                    depo.obtenerIdInventarios(idInventarios);
                    foreach (Inventario inv in Stock.Inventarios)
                    {
                        if (depo.idInventariosDepositos[i] == inv.IdInventario)
                        {
                            inv.deposito.Add(depo);
                        }
                    }
                }
            }
            catch (Exception e)
            {

            }
        }
        /// <summary>
        /// Agrega la informe recibida por parámetro a todos los inventarios que la tengan. Recibe idinventarios que son todos los id de inventarios que la tienen.
        /// </summary>
        /// <param name="idInventarios"></param>
        /// <param name="inventario"></param>
        public static void AgregarInformesAInventarios(int[] idInventarios, Informes informes)
        {
            try
            {
                for (int i = 0; i < Stock.Inventarios.Count; i++)
                {
                    informes.obtenerIdInventarios(idInventarios);
                    foreach (Inventario inv in Stock.Inventarios)
                    {
                        if (informes.idInventariosInformes[i] == inv.IdInventario)
                        {
                            inv.informes.Add(informes);
                        }
                    }
                }
            }
            catch (Exception e) { }

        }
        /// <summary>
        /// Agrega a la lista de inventarios de cada cliente los inventarios que le corresponden según el ID CLIENTE que ambos comparten.
        /// </summary>
        /// <param name="listaClientes"></param>
        /// <param name="listaInventarios"></param>      
        public static void ObtenerInventariosPorCadaCliente(List<Clientes> listaClientes, List<Inventario> listaInventarios)
        {
            foreach (Inventario inv in listaInventarios)
            {
                foreach (Clientes clientesito in listaClientes)
                {
                    if (inv.IdCliente == clientesito.IdCliente)
                    {
                        clientesito.inventario.Add(inv);
                    }
                }
            }
        }

    }
}
