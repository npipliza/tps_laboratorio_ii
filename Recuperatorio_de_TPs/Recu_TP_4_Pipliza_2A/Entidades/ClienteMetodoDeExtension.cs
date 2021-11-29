
namespace Entidades
{
    public static class ClienteMetodoDeExtension
    {
        /// <summary>
        /// Contará cantidad de informes total por cada cliente y cada deposito
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static int CantidadInformesPorCliente(this Clientes cliente)
        {
            int cantidad = 0;
            foreach (Inventario inv in cliente.inventario)
            {
                foreach (Informes informes in inv.informes)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        /// <summary>
        /// Contará cantidad de depositoes total por cada cliente y cada depo
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static int CantidadDepositosPorCliente(this Clientes cliente)
        {
            int cantidad = 0;
            foreach (Inventario inv in cliente.inventario)
            {
                foreach (DepositoP deposito in inv.deposito)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
    }
}
