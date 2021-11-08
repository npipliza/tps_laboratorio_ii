using System;
using System.Collections.Generic;
using System.Linq;
using Serializacion;

namespace Entidades
{
    public static class Controller
    {
        private static SerializadoraXml<List<DepositoP>> serializacionDep;
        private static SerializadoraXml<List<Clientes>> serializacionCliente;

        private static List<DepositoP> depositoXml;
        private static List<Clientes> clientesXml;

        private static string rutaDep = AppDomain.CurrentDomain.BaseDirectory + "listaInvlicacionesStock";
        private static string rutaClientes = AppDomain.CurrentDomain.BaseDirectory + "listaClientes";

        /// <summary>
        /// Constructor privado y estático de la clase Controller. Instancia todos los objetos de Serializadora y Listas.
        /// </summary>
        static Controller()
        {
            serializacionDep = new SerializadoraXml<List<DepositoP>>();
            depositoXml = new List<DepositoP>();
            clientesXml = new List<Clientes>();
            serializacionCliente = new SerializadoraXml<List<Clientes>>();
        }
        /// <summary>
        /// Carga los objetos clientes, inventario, depositos y listas.
        /// </summary>
        private static void cargarObjetos()
        {
            Inventario inventario1 = new Inventario("MARCA P", Inventario.tipoPapel.EstucadoBrillante);
            Inventario inventario2 = new Inventario("MARCA A", Inventario.tipoPapel.EstucadoMate);
            Inventario inventario3 = new Inventario("MARCA U", Inventario.tipoPapel.Cartulina);
            Inventario inventario4 = new Inventario("MARCA B", Inventario.tipoPapel.Cartulina);
            Inventario inventario5 = new Inventario("MARCA S", Inventario.tipoPapel.ObraAHuesado);
            Inventario inventario6 = new Inventario("MARCA D", Inventario.tipoPapel.EstucadoMate);
            Inventario inventario7 = new Inventario("MARCA G", Inventario.tipoPapel.Ilustracion);
            Inventario inventario8 = new Inventario("MARCA M", Inventario.tipoPapel.PapelPrensa);
            Inventario inventario9 = new Inventario("MARCA A", Inventario.tipoPapel.Cartulina);

            clientesXml.Add(new Clientes("IMPRENTA 11"));
            clientesXml.Last().inventario.Add(inventario1);
            clientesXml.Last().inventario.Add(inventario2);
            clientesXml.Last().inventario.Add(inventario9);
            clientesXml.Add(new Clientes("IMPRENTA 3"));
            clientesXml.Last().inventario.Add(inventario3);
            clientesXml.Last().inventario.Add(inventario4);
            clientesXml.Add(new Clientes("IMPRENTA 1"));
            clientesXml.Last().inventario.Add(inventario5);
            clientesXml.Add(new Clientes("IMPRENTA 15"));
            clientesXml.Last().inventario.Add(inventario6);
            clientesXml.Last().inventario.Add(inventario7);
            clientesXml.Add(new Clientes("IMPRENTA 7"));
            clientesXml.Last().inventario.Add(inventario8);

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Hojas, "DEPOSITO 1", 250, "USD210", "KB531E", 1));
            inventario8.deposito.Add(depositoXml.Last()); inventario7.deposito.Add(depositoXml.Last()); inventario6.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(2, DepositoP.Formato.Bobina, "DEPOSITO 3", 120, "USD215", "140319", 1520)); //**
            inventario7.deposito.Add(depositoXml.Last()); inventario4.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(2, DepositoP.Formato.Hojas, "DEPOSITO 4", 95, "USD218", "KK210M", 1));
            inventario8.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last()); inventario2.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "DEPOSITO 3", 45, "USD200", "KC265F", 1));
            inventario7.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(2, DepositoP.Formato.Bobina, "DEPOSITO 12", 80, "USD219", "KA110S", 1));
            inventario8.deposito.Add(depositoXml.Last()); inventario7.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(2, DepositoP.Formato.Hojas, "DEPOSITO 3", 95, "USD215", "KA110S", 1));
            inventario7.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last()); inventario4.deposito.Add(depositoXml.Last()); inventario2.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());
            inventario9.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "DEPOSITO 6", 115, "USD210", "KG110S", 1));
            inventario9.deposito.Add(depositoXml.Last());
            inventario8.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "DEPOSITO 2", 120, "USD215", "NP314-21", 1));
            inventario6.deposito.Add(depositoXml.Last()); inventario4.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "DEPOSITO 3", 95, "IMO", "NP100", 1));
            inventario8.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last()); inventario2.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Hojas, "DEPOSITO 1", 92, "IMO", "NP100", 1));
            inventario6.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "DEPOSITO 12", 85, "2020", "NP205", 1));
            inventario8.deposito.Add(depositoXml.Last()); inventario6.deposito.Add(depositoXml.Last()); inventario4.deposito.Add(depositoXml.Last()); inventario2.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "DEPOSITO 3", 270, "USD210", "NP201", 1)); inventario3.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "DEPOSITO 8", 65, "USD210", "NP12", 1));
            inventario7.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "DEPOSITO 7", 95, "USD270", "NP22", 1)); inventario2.deposito.Add(depositoXml.Last());
            inventario8.deposito.Add(depositoXml.Last()); inventario7.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last()); inventario9.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "DEPOSITO 5", 90, "USD215", "ID117E", 1));
            inventario9.deposito.Add(depositoXml.Last());
            inventario7.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Hojas, "DEPOSITO 3", 80, "USD210", "ID117E", 1));
            inventario1.deposito.Add(depositoXml.Last()); inventario8.deposito.Add(depositoXml.Last()); inventario4.deposito.Add(depositoXml.Last()); inventario9.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "DEPOSITO 5", 118, "USD210", "UYP3", 1));
            inventario6.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last()); inventario2.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last()); inventario9.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "DEPOSITO 1", 220, "USD210", "UYP2", 1));
            inventario5.deposito.Add(depositoXml.Last()); inventario4.deposito.Add(depositoXml.Last()); inventario2.deposito.Add(depositoXml.Last());
            inventario9.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "DEPOSITO 11", 300, "USD215", "UYP5", 1));
            inventario5.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "DEPOSITO 6", 75, "USD210", "IB701E", 1));
            inventario8.deposito.Add(depositoXml.Last()); inventario4.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "DEPOSITO 9", 95, "USD215", "145872", 1));
            inventario5.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last()); inventario2.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "DEPOSITO 7", 95, "USD215", "125696", 1));
            inventario8.deposito.Add(depositoXml.Last()); inventario6.deposito.Add(depositoXml.Last());
            inventario5.deposito.Add(depositoXml.Last()); inventario4.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "DEPOSITO 3", 85, "IMO", "125789", 1));
            inventario5.deposito.Add(depositoXml.Last()); inventario4.deposito.Add(depositoXml.Last()); inventario2.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "DEPOSITO1 ", 95, "IMO", "125478", 1));
            inventario9.deposito.Add(depositoXml.Last()); inventario7.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "DEPOSITO 5", 95, "USD215", "123658", 1));
            inventario6.deposito.Add(depositoXml.Last()); inventario8.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last()); inventario4.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last()); inventario2.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "DEPOSITO 12", 115, "USD215", "125874", 1));
            inventario8.deposito.Add(depositoXml.Last()); inventario4.deposito.Add(depositoXml.Last());
            inventario9.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "DEPOSITO 4", 2015, "USD215", "159632", 1));
            inventario6.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "DEPOSITO 5", 95, "USD215", "147859", 1));
            inventario2.deposito.Add(depositoXml.Last());
            inventario9.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Hojas, "DEPOSITO 22", 115, "USD220", "140254", 71452));
            inventario8.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last()); inventario2.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Hojas, "DEPOSITO 22", 115, "USD220", "140254", 71452));
            inventario4.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Hojas, "DEPOSITO 22", 115, "USD220", "140254", 71452));
            inventario8.deposito.Add(depositoXml.Last()); inventario6.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last()); inventario2.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "DEPOSITO 17", 95, "USD220", "140752", 200));
            inventario8.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last()); inventario2.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Hojas, "DEPOSITO 2", 80, "USD220", "142587", 7526));
            inventario5.deposito.Add(depositoXml.Last()); inventario4.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());
            inventario9.deposito.Add(depositoXml.Last());
        }
        /// <summary>
        /// Invoca cargarObjetos y los guarda en formato XML en las rutas preestablecidas.
        /// </summary>
        public static void GuardarXml()
        {
            cargarObjetos();
            serializacionDep.Guardar(rutaDep, depositoXml);
            serializacionCliente.Guardar(rutaClientes, clientesXml);
        }
        /// <summary>
        /// Llama al metodo Leer para guardar cada objeto dentro de la lista y la devuelve.
        /// </summary>
        /// <param name="listaInv"></param>
        /// <returns></returns>
        public static List<DepositoP> Deserializar(List<DepositoP> listaInv, string ruta)
        {
            try
            {
                serializacionDep.Leer(ruta, out listaInv);
                return listaInv;
            }
            catch (NullReferenceException)
            {
                throw new Exception("La lista es null");
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Sobrecarga. Llama al metodo Leer para guardar cada objeto dentro de la lista y la devuelve.
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static List<Clientes> Deserializar(List<Clientes> lista, string ruta)
        {
            try
            {
                serializacionCliente.Leer(ruta, out lista);
                return lista;
            }
            catch (NullReferenceException)
            {
                throw new Exception("La lista es null");
            }
        }
    }
}