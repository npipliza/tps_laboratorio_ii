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

            Console.Title = "Pipliza Nadia. TP3 - División 2A";

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

            string rutaDep = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\listaDepositosStock.xml";
            string rutaInformes = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\listaInformesStock.xml";
            string rutaClientes = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\listaClientes.xml";

            DepositoP deposito = new DepositoP(2, DepositoP.Formato.Bobina, "Cartulina", 95, "USD220", "125478", 1);

            /// Ya está en la lista, no debería poder agregarse de nuevo
            DepositoP papelDuplicado = new DepositoP(2, DepositoP.Formato.Bobina, "Estucado Brillante", 120, "USD215", "140319", 1520);

            Controller.Guardar();
            Controller.AgregarDatos_Serializar_NuevasEdiciones();
            Stock.Deposito.AddRange(Controller.Deserializar(depositoConsola, rutaDep));
            Stock.Informes.AddRange(Controller.Deserializar(Stock.Informes, rutaInformes));

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
            Stock.RevisarIgualdadDepositoSeleccionado(papelDuplicado, inventarioConsola);

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

            Console.WriteLine("                                                                         ");
            Console.WriteLine("************************* PAPEL CON MAYOR STOCK *************************");
            Console.WriteLine("                                                                         ");

            Console.WriteLine("El papel {0}, es el que màs stock tiene.", mayorStock);

            //// MOSTRAR EL PAPEL MAS STOCKEADO
            Stock.RecuentoDePapelesEnStock(depo, mayorStock);

        }
    }
}