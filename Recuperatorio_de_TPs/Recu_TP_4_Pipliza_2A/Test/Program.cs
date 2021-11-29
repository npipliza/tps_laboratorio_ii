using System;
using System.Collections.Generic;
using Entidades;
using Serializacion;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Pipliza Nadia. TP4 - División 2A";

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("******                 * BIENVENIDO A LA PAPELERA *                 *****");
            Console.WriteLine("*************************************************************************");

            #region instancias para funcionamiento
            SerializadoraXml<List<DepositoP>> serializacionDepo    = new SerializadoraXml<List<DepositoP>>();
            SerializadoraXml<List<Informes>> serializacionInformes = new SerializadoraXml<List<Informes>>();
            SerializadoraXml<List<Clientes>> serializacionClientes = new SerializadoraXml<List<Clientes>>();

            List<Informes> informesConsola     = new List<Informes>();
            List<Clientes> clientesConsola     = new List<Clientes>();
            List<Inventario> inventarioConsola = new List<Inventario>();
            List<DepositoP> depositoConsola    = new List<DepositoP>();

            Stock stocksito = new Stock();
            Inventario.TipoPapel mayorStock = new Inventario.TipoPapel();
            DepositoP depo = new DepositoP();
            DepositoP.Formato mayorFormato = new DepositoP.Formato();

            string rutaDep = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\listaDepositosStock.xml";
            string rutaInformes = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\listaInformesStock.xml";
            string rutaClientes = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\listaClientes.xml";

            DepositoP deposito = new DepositoP(2, DepositoP.Formato.Bobina, "DEPOSITO 1", 95, "USD220", "125478", 1);

            /// Ya está en la lista, no debería poder agregarse de nuevo
            DepositoP papelDuplicado = new DepositoP(2, DepositoP.Formato.Bobina, "Estucado Brillante", 120, "USD215", "140319", 1520);

            DepositoP cantPapeles = new DepositoP();

            #endregion

            Console.WriteLine("                                                                         ");
            Console.WriteLine("**************************** AGREGAR PAPELES ****************************");
            Console.WriteLine("                                                                         ");

            if (stocksito + deposito)
            {
                Console.WriteLine("Se agregó {0} con éxito", deposito.TipoPapel);
                depositoConsola.Add(deposito);
            }

            Console.WriteLine("                                                                         ");

            if (stocksito + papelDuplicado)
            {
                Console.WriteLine("Se agregó el papel con éxito");
            }
            else
            {
                Console.WriteLine("No se pudo agregar el papel {0}.", papelDuplicado.TipoPapel);
            }

            Console.WriteLine("                                                                         ");
            Console.Write("--- PRESIONE UNA TECLA PARA CONTINUAR ---                                    ");
            Console.ReadKey();

            Console.WriteLine("                                                                         ");
            Console.WriteLine("************************** PAPELES DUPLICADOS ***************************");
            Console.WriteLine("                                                                         ");

            Console.WriteLine("El papel {0} està duplicado y no se pudo agregar, ya estaba en la lista.\nSu código es {1}.", papelDuplicado.TipoPapel, papelDuplicado.Codigo);

            Console.WriteLine("                                                                         ");
            Console.Write("--- PRESIONE UNA TECLA PARA CONTINUAR ---                                    ");
            Console.ReadKey();


            //// MOSTRAR LOS SIGUIENTES PAPELES:
            ///Estucado brillante 140319
            Stock.RevisarIgualdadInventarioSeleccionado(papelDuplicado, inventarioConsola);

            if (inventarioConsola.Count > 0)
            {
                foreach (Inventario inv in inventarioConsola)
                {
                    Console.WriteLine(inv.NombreInventario);
                }
            }
            else
            {
                Console.WriteLine("Ningun deposito tiene este papel.");
            }

            Console.WriteLine("                                                                         ");
            Console.Write("--- PRESIONE UNA TECLA PARA CONTINUAR ---                                    ");
            Console.ReadKey();

            //// MOSTRAR EL FORMATO PAPEL MAS STOCKEADO
            Stock.MayorFormatoPapelesEnStock(mayorFormato);

            Console.WriteLine("                                                                         ");
            Console.WriteLine("********************* FORMATO PAPEL CON MAYOR STOCK *********************");
            Console.WriteLine("                                                                         ");

            Console.WriteLine("El FORMATO de papel {0}, es el que tiene mayor stock.", mayorFormato);
            Console.ReadKey();

        }
    }
}