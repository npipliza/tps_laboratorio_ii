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

            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("------------------------------LA PAPELERA------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------");

            #region instancias para funcionamiento
            SerializadoraXml<List<DepositoP>> serializacionPubs = new SerializadoraXml<List<DepositoP>>();
            SerializadoraXml<List<Clientes>> serializacionCliente = new SerializadoraXml<List<Clientes>>();

            List<Clientes> clientesConsola = new List<Clientes>();
            List<Inventario> inventarioConsola = new List<Inventario>();
            List<DepositoP> depositoConsola = new List<DepositoP>();

            Stock stocksito = new Stock();

            string rutaInv = AppDomain.CurrentDomain.BaseDirectory + "listaInventarioStock";
            string rutaClientes = AppDomain.CurrentDomain.BaseDirectory + "listaClientes";

            DepositoP deposito = new DepositoP(2, DepositoP.Formato.Bobina, "DEPOSITO 1", 95, "USD220", "125478", 1);

            /// Ya está en la lista, no debería poder agregarse de nuevo
            DepositoP inventarioDuplicado = new DepositoP(2, DepositoP.Formato.Bobina, "DEPOSITO 5", 120, "USD215", "140319", 1520);

            Controller.GuardarXml();
            Stock.Inventario.AddRange(Controller.Deserializar(depositoConsola, rutaInv));

            #endregion

            Console.WriteLine("                                                   ");
            Console.WriteLine("                                                   ");

            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("-----------------------------AGREGAR PAPELES---------------------------");
            Console.WriteLine("-----------------------------------------------------------------------");


            Console.WriteLine("                                                   ");
            Console.WriteLine("                                                   ");


            if (stocksito + deposito)
            {
                Console.WriteLine("Se agregó el papel {0} con éxito", deposito.Titulo);
                depositoConsola.Add(deposito);
            }


            Console.WriteLine("                                                   ");
            Console.WriteLine("                                                   ");


            if (stocksito + inventarioDuplicado)
            {
                Console.WriteLine("Se agregó el papel con éxito");
            }
            else
            {
                Console.WriteLine("No se pudo agregar el papel {0}.", inventarioDuplicado.Titulo);
            }
            Console.WriteLine("                                                   ");
            Console.WriteLine("                                                   ");

            Console.Write("-----------------PRESIONE UNA TECLA PARA CONTINUAR--------------------------");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("------------------------------LA PAPELERA------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------");

            Console.WriteLine("                                                   ");
            Console.WriteLine("                                                   ");

            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("--------------------¿QUE PAPELES ESTAN DUPLICADOS?---------------------");
            Console.WriteLine("-----------------------------------------------------------------------");

            Console.WriteLine("                                                   ");
            Console.WriteLine("                                                   ");

            Console.WriteLine("El papel duplicado es: {0} . \nNo se pudo agregar, ya estaba en la lista. Su código es {1}.", inventarioDuplicado.Titulo, inventarioDuplicado.Codigo);

            Console.WriteLine("                                                   ");
            Console.WriteLine("                                                   ");

            //// DEBERÍA MOSTRAR LOS SIGUIENTES PAPELES:
            Stock.revisarIgualdadDepositoSeleccionado(inventarioDuplicado, depositoConsola);

            if (depositoConsola.Count > 0)
            {
                foreach (Inventario inv in inventarioConsola)
                {
                    Console.WriteLine(inv.NombreInventario);
                }
            }
            else
            {
                Console.WriteLine("Ningun deposito tiene este papel");
            }
            Console.ReadKey();
        }
    }
}