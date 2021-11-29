using System;
using System.Collections.Generic;
using System.Linq;
using Serializacion;

namespace Entidades
{
    public static class Controller
    {
        #region generar Listas y obj

        private static SerializadoraXml<List<DepositoP>> serializacionDep;
        private static SerializadoraXml<List<Informes>> serializacionInformes;
        private static SerializadoraXml<List<Clientes>> serializacionCliente;

        private static SerializadoraTxt<List<DepositoP>> serializacionDepT;
        private static SerializadoraTxt<List<Informes>> serializacionInformesT;
        private static SerializadoraTxt<List<Clientes>> serializacionClienteT;


        private static List<DepositoP> depositoXml;
        private static List<Informes> informesXml;
        private static List<Clientes> clientesXml;

        private static List<DepositoP> depositoTxt;
        private static List<Informes> informesTxt;
        private static List<Clientes> clientesTxt;

        private static List<DepositoP> UnoDepo_ListaNuevasEdiciones = new List<DepositoP>();
        private static List<DepositoP> DosDepo_ListaNuevasEdiciones = new List<DepositoP>();


        private static List<Informes> UnoInfo_ListaNuevasEdiciones = new List<Informes>();
        private static List<Informes> DosInfo_ListaNuevasEdiciones = new List<Informes>();

        #endregion
        #region generar Rutas
        private static string rutaNuevasEdiciones_UnoInfo = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Informes_NuevasEdiciones1.txt";
        private static string rutaNuevasEdiciones_DosInfo = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Informes_NuevasEdiciones2.txt";
        private static string rutaNuevasEdiciones_UnoDepo = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Depositos_NuevasEdiciones1.txt";
        private static string rutaNuevasEdiciones_DosDepo = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Depositos_NuevasEdiciones2.txt";

        private static string rutaDep = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\listaDepositosStock.xml";
        private static string rutaInformes = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\listaInformesStock.xml";
        private static string rutaClientes = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\listaClientes.xml";
        #endregion

        /// <summary>
        /// Constructor privado y estático de la clase Controller. Instanciara todos los objetos de Serializadora y Listas.
        /// </summary>
        static Controller()
        {
            serializacionInformes = new SerializadoraXml<List<Informes>>();
            informesXml = new List<Informes>();
            serializacionDep = new SerializadoraXml<List<DepositoP>>();
            depositoXml = new List<DepositoP>();
            clientesXml = new List<Clientes>();
            serializacionCliente = new SerializadoraXml<List<Clientes>>();

            serializacionInformesT = new SerializadoraTxt<List<Informes>>();
            informesTxt = new List<Informes>();
            serializacionDepT = new SerializadoraTxt<List<DepositoP>>();
            depositoTxt = new List<DepositoP>();
            clientesTxt = new List<Clientes>();
            serializacionClienteT = new SerializadoraTxt<List<Clientes>>();

        }

        /// <summary>
        /// Carga los objetos clientes, inventario, depositos y listas.
        /// 
        /// </summary>
        private static void CargarObjetos()
        {
            #region AGREGAR PAPELES
            Inventario inventario1 = new Inventario("MARCA P", Inventario.TipoPapel.EstucadoBrillante);
            Inventario inventario2 = new Inventario("MARCA B", Inventario.TipoPapel.EstucadoMate);
            Inventario inventario3 = new Inventario("MARCA U", Inventario.TipoPapel.Cartulina);
            Inventario inventario4 = new Inventario("MARCA B", Inventario.TipoPapel.Cartulina);
            Inventario inventario5 = new Inventario("MARCA S", Inventario.TipoPapel.ObraAHuesado);
            Inventario inventario6 = new Inventario("MARCA D", Inventario.TipoPapel.EstucadoMate);
            Inventario inventario7 = new Inventario("MARCA G", Inventario.TipoPapel.Ilustracion);
            Inventario inventario8 = new Inventario("MARCA M", Inventario.TipoPapel.PapelPrensa);
            Inventario inventario9 = new Inventario("MARCA A", Inventario.TipoPapel.Cartulina);
            #endregion

            #region AGREGAR INVENTARIO DEPOSITOS A CLIENTES | INSTANCIAR CLIENTES
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
            #endregion

            #region INFORMES AGREGA A LISTA
            ///dato ok
            informesXml.Add(new Informes("Cartulina", 250, "USD210", "145078", 1, DateTime.Parse("22/02/2018")));
            inventario1.informes.Add(informesXml.Last()); inventario2.informes.Add(informesXml.Last()); inventario7.informes.Add(informesXml.Last()); inventario9.informes.Add(informesXml.Last());

            informesXml.Add(new Informes("Estucado Brillante", 250, "USD210", "145078", 1, DateTime.Parse("15/03/2018")));
            inventario2.informes.Add(informesXml.Last()); inventario4.informes.Add(informesXml.Last()); inventario7.informes.Add(informesXml.Last()); inventario9.informes.Add(informesXml.Last());

            informesXml.Add(new Informes("Estucado Mate", 250, "USD210", "145078", 1, DateTime.Parse("15/05/2016")));
            inventario1.informes.Add(informesXml.Last()); inventario3.informes.Add(informesXml.Last()); inventario6.informes.Add(informesXml.Last()); inventario8.informes.Add(informesXml.Last());
            ///dato ok
            informesXml.Add(new Informes("Papel Prensa", 250, "USD210", "145078", 1, DateTime.Parse("01/01/2010")));
            inventario4.informes.Add(informesXml.Last()); inventario6.informes.Add(informesXml.Last()); inventario9.informes.Add(informesXml.Last());

            informesXml.Add(new Informes("Cartulina", 250, "USD210", "145078", 1, DateTime.Parse("08/03/2018")));
            inventario2.informes.Add(informesXml.Last()); inventario4.informes.Add(informesXml.Last()); inventario6.informes.Add(informesXml.Last()); inventario8.informes.Add(informesXml.Last());
            ///dato ok
            informesXml.Add(new Informes("Estucado Mate", 250, "USD210", "145078", 1, DateTime.Parse("23/04/2005")));
            inventario1.informes.Add(informesXml.Last()); inventario2.informes.Add(informesXml.Last()); inventario6.informes.Add(informesXml.Last());

            informesXml.Add(new Informes("Ilustracion", 250, "USD210", "145078", 1, DateTime.Parse("21/06/2018")));
            inventario4.informes.Add(informesXml.Last()); inventario6.informes.Add(informesXml.Last()); inventario9.informes.Add(informesXml.Last()); inventario8.informes.Add(informesXml.Last());

            informesXml.Add(new Informes("Estucado Mate", 250, "USD210", "145078", 1, DateTime.Parse("06/09/2018")));
            inventario1.informes.Add(informesXml.Last()); inventario2.informes.Add(informesXml.Last()); inventario6.informes.Add(informesXml.Last()); inventario7.informes.Add(informesXml.Last());

            informesXml.Add(new Informes("Ilustracion", 250, "USD210", "145078", 1, DateTime.Parse("22/02/2010")));
            inventario4.informes.Add(informesXml.Last()); inventario5.informes.Add(informesXml.Last()); inventario7.informes.Add(informesXml.Last()); inventario9.informes.Add(informesXml.Last());

            informesXml.Add(new Informes("Estucado Brillante", 250, "USD210", "145078", 1, DateTime.Parse("15/02/2020")));
            inventario3.informes.Add(informesXml.Last()); inventario6.informes.Add(informesXml.Last()); inventario9.informes.Add(informesXml.Last());
            informesXml.Add(new Informes("Papel Prensa", 250, "USD210", "145078", 1, DateTime.Parse("25/05/2018")));
            inventario1.informes.Add(informesXml.Last()); inventario4.informes.Add(informesXml.Last()); inventario7.informes.Add(informesXml.Last());
            informesXml.Add(new Informes("Ilustracion", 250, "USD210", "145078", 1, DateTime.Parse("25/05/2018")));
            inventario2.informes.Add(informesXml.Last()); inventario5.informes.Add(informesXml.Last()); inventario9.informes.Add(informesXml.Last());
            informesXml.Add(new Informes("Ilustracion", 250, "USD210", "145078", 1, DateTime.Parse("15/03/2019")));
            inventario4.informes.Add(informesXml.Last()); inventario6.informes.Add(informesXml.Last()); inventario7.informes.Add(informesXml.Last());
            informesXml.Add(new Informes("Obra Ahuesado", 250, "USD210", "145078", 1, DateTime.Parse("21/03/2019")));
            inventario5.informes.Add(informesXml.Last()); inventario7.informes.Add(informesXml.Last()); inventario9.informes.Add(informesXml.Last());
            informesXml.Add(new Informes("Cartulina", 250, "USD210", "145078", 11, DateTime.Parse("15/03/2020")));
            inventario2.informes.Add(informesXml.Last()); inventario4.informes.Add(informesXml.Last()); inventario8.informes.Add(informesXml.Last());
            informesXml.Add(new Informes("Ilustracion", 250, "USD210", "145078", 1, DateTime.Parse("22/02/2018")));
            inventario3.informes.Add(informesXml.Last()); inventario5.informes.Add(informesXml.Last()); inventario7.informes.Add(informesXml.Last());

            informesXml.Add(new Informes("Cartulina", 250, "USD210", "145078", 1, DateTime.Parse("04/07/2019")));
            inventario1.informes.Add(informesXml.Last()); inventario4.informes.Add(informesXml.Last()); inventario5.informes.Add(informesXml.Last()); inventario9.informes.Add(informesXml.Last());
            informesXml.Add(new Informes("Ilustracion", 250, "USD210", "145078", 1, DateTime.Parse("12/06/2012")));
            inventario2.informes.Add(informesXml.Last()); inventario3.informes.Add(informesXml.Last()); inventario6.informes.Add(informesXml.Last()); inventario8.informes.Add(informesXml.Last());

            informesXml.Add(new Informes("Papel Prensa", 250, "USD210", "145078", 1, DateTime.Parse("02/02/2005")));
            inventario3.informes.Add(informesXml.Last()); inventario5.informes.Add(informesXml.Last()); inventario9.informes.Add(informesXml.Last());
            informesXml.Add(new Informes("Estucado Mate", 250, "USD210", "145078", 1, DateTime.Parse("06/02/2020")));
            inventario1.informes.Add(informesXml.Last()); inventario5.informes.Add(informesXml.Last()); inventario7.informes.Add(informesXml.Last());
            informesXml.Add(new Informes("Cartulina", 250, "USD210", "145078", 1, DateTime.Parse("22/05/2018")));

            inventario2.informes.Add(informesXml.Last()); inventario6.informes.Add(informesXml.Last()); inventario8.informes.Add(informesXml.Last());
            informesXml.Add(new Informes("Papel Prensa", 250, "USD210", "145078", 1, DateTime.Parse("22/01/2019")));

            inventario1.informes.Add(informesXml.Last()); inventario5.informes.Add(informesXml.Last()); inventario6.informes.Add(informesXml.Last()); inventario9.informes.Add(informesXml.Last());
            informesXml.Add(new Informes("Ilustracion", 250, "USD210", "145078", 1, DateTime.Parse("03/02/2012")));
            inventario1.informes.Add(informesXml.Last()); inventario2.informes.Add(informesXml.Last()); inventario3.informes.Add(informesXml.Last()); inventario7.informes.Add(informesXml.Last());

            informesXml.Add(new Informes("Obra Ahuesado", 250, "USD210", "145078", 1, DateTime.Parse("22/02/2005")));
            inventario5.informes.Add(informesXml.Last()); inventario7.informes.Add(informesXml.Last()); inventario9.informes.Add(informesXml.Last());
            informesXml.Add(new Informes("Cartulina", 250, "USD210", "145078", 1, DateTime.Parse("15/02/2010")));
            inventario3.informes.Add(informesXml.Last()); inventario6.informes.Add(informesXml.Last()); inventario8.informes.Add(informesXml.Last());
            informesXml.Add(new Informes("Obra Ahuesado", 250, "USD210", "145078", 1, DateTime.Parse("22/02/2018")));
            inventario5.informes.Add(informesXml.Last()); inventario7.informes.Add(informesXml.Last()); inventario9.informes.Add(informesXml.Last());


            #endregion
            #region DEPOSITO AGREGAR A LISTA
            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Hojas, "Obra Ahuesado", 250, "USD210", "145078", 1));
            inventario8.deposito.Add(depositoXml.Last()); inventario7.deposito.Add(depositoXml.Last()); inventario6.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(2, DepositoP.Formato.Bobina, "Obra Ahuesado", 120, "USD215", "130258", 1520)); //**
            inventario7.deposito.Add(depositoXml.Last()); inventario4.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(2, DepositoP.Formato.Hojas, "Obra Ahuesado", 120, "USD215", "130258", 1520));
            inventario8.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last()); inventario2.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Ilustracion", 45, "USD200", "178452", 1));
            inventario7.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(2, DepositoP.Formato.Bobina, "Estucado Brillante", 80, "USD219", "145369", 100));
            inventario8.deposito.Add(depositoXml.Last()); inventario7.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(2, DepositoP.Formato.Hojas, "Estucado Brillante", 80, "USD219", "145369", 100));
            inventario7.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last()); inventario4.deposito.Add(depositoXml.Last()); inventario2.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());
            inventario9.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Cartulina", 115, "USD210", "156985", 1));
            inventario9.deposito.Add(depositoXml.Last());
            inventario8.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Estucado Mate", 120, "USD215", "145872", 1));
            inventario6.deposito.Add(depositoXml.Last()); inventario4.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Obra Ahuesado", 95, "USD205", "178569", 700));
            inventario8.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last()); inventario2.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Hojas, "Obra Ahuesado", 95, "USD205", "178569", 700));
            inventario6.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Estucado Mate", 85, "USD215", "136589", 1));
            inventario8.deposito.Add(depositoXml.Last()); inventario6.deposito.Add(depositoXml.Last()); inventario4.deposito.Add(depositoXml.Last()); inventario2.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());
            ///dato ok
            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Obra Ahuesado", 270, "USD210", "158745", 1)); inventario3.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Ilustracion", 65, "USD210", "154789", 1));
            inventario7.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Papel Prensa", 95, "USD270", "136589", 1)); inventario2.deposito.Add(depositoXml.Last());
            inventario8.deposito.Add(depositoXml.Last()); inventario7.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last()); inventario9.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "DEPOSITO 34", 90, "USD215", "158796", 1));
            inventario9.deposito.Add(depositoXml.Last());
            inventario7.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Hojas, "Obra Ahuesado", 90, "USD215", "158796", 1));
            inventario1.deposito.Add(depositoXml.Last()); inventario8.deposito.Add(depositoXml.Last()); inventario4.deposito.Add(depositoXml.Last()); inventario9.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Ilustracion", 118, "USD210", "125698", 1));
            inventario6.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last()); inventario2.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last()); inventario9.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Obra Ahuesado", 220, "USD210", "145287", 1));
            inventario5.deposito.Add(depositoXml.Last()); inventario4.deposito.Add(depositoXml.Last()); inventario2.deposito.Add(depositoXml.Last());
            inventario9.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Cartulina", 300, "USD215", "123658", 1));
            inventario5.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Obra Ahuesado", 75, "USD210", "148852", 1));
            inventario8.deposito.Add(depositoXml.Last()); inventario4.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Cartulina", 95, "USD215", "145872", 1));
            inventario5.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last()); inventario2.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Ilustracion", 95, "USD215", "125696", 1));
            inventario8.deposito.Add(depositoXml.Last()); inventario6.deposito.Add(depositoXml.Last());
            inventario5.deposito.Add(depositoXml.Last()); inventario4.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Estucado Mate", 85, "USD245", "125789", 1));
            inventario5.deposito.Add(depositoXml.Last()); inventario4.deposito.Add(depositoXml.Last()); inventario2.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Cartulina", 95, "USD245", "125478", 1));
            inventario9.deposito.Add(depositoXml.Last()); inventario7.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Estucado Brillante", 95, "USD215", "123658", 1));
            inventario6.deposito.Add(depositoXml.Last()); inventario8.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last()); inventario4.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last()); inventario2.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Papel Prensa", 115, "USD215", "125874", 1));
            inventario8.deposito.Add(depositoXml.Last()); inventario4.deposito.Add(depositoXml.Last());
            inventario9.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Ilustracion", 2015, "USD215", "159632", 1));
            inventario6.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Estucado Brillante", 95, "USD215", "147859", 1));
            inventario2.deposito.Add(depositoXml.Last());
            inventario9.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Hojas, "Estucado Brillante", 115, "USD220", "140254", 71452));
            inventario8.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last()); inventario2.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Hojas, "Estucado Brillante", 115, "USD220", "140254", 71452));
            inventario4.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Hojas, "Estucado Brillante", 115, "USD220", "140255", 71452));
            inventario8.deposito.Add(depositoXml.Last()); inventario6.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last()); inventario2.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Ilustracion", 95, "USD220", "140752", 200));
            inventario8.deposito.Add(depositoXml.Last()); inventario5.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last()); inventario2.deposito.Add(depositoXml.Last());

            depositoXml.Add(new DepositoP(1, DepositoP.Formato.Hojas, "Estucado Brillante", 95, "USD220", "140752", 200));
            inventario5.deposito.Add(depositoXml.Last()); inventario4.deposito.Add(depositoXml.Last()); inventario3.deposito.Add(depositoXml.Last()); inventario1.deposito.Add(depositoXml.Last());
            inventario9.deposito.Add(depositoXml.Last());
            #endregion
        }

        /// <summary>
        /// Invoca a cargarObjetos y los guarda en formato XML en rutas preestablecidas.
        /// </summary>
        public static void Guardar()
        {
            CargarObjetos();
            serializacionInformes.Guardar(rutaInformes, informesXml);
            serializacionDep.Guardar(rutaDep, depositoXml);
            serializacionCliente.Guardar(rutaClientes, clientesXml);
            serializacionInformes.Guardar(rutaNuevasEdiciones_UnoInfo, informesTxt);
            serializacionInformes.Guardar(rutaNuevasEdiciones_DosInfo, informesTxt);
            serializacionDep.Guardar(rutaNuevasEdiciones_UnoDepo, depositoTxt);
            serializacionDep.Guardar(rutaNuevasEdiciones_DosDepo, depositoTxt);
        }

        /// <summary>
        /// Llama al metodo Leer para guardar cada objeto dentro de la lista y la devuelve.
        /// </summary>
        /// <param name="listaDep"></param>
        /// <returns></returns>
        public static List<DepositoP> Deserializar(List<DepositoP> listaDep, string ruta)
        {
            try
            {
                serializacionDep.Leer(ruta, out listaDep);
                return listaDep;
            }
            catch (NullReferenceException)
            {
                throw new Exception("La lista es null");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// Sobrecarga. Llama al metodo Leer para guardar cada objeto dentro de la lista y la devuelve.
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static List<Informes> Deserializar(List<Informes> lista, string ruta)
        {
            try
            {
                serializacionInformes.Leer(ruta, out lista);
                return lista;
            }
            catch (NullReferenceException)
            {
                throw new Exception("La lista es null");
            }
        }
        /// <summary>
        /// Sobrecarga. Llama al metodo Leer para guardar cada objeto dentro de la lista, luego la devuelve.
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

        /// <summary>
        /// Crea y agrega los datos necesarios para poder subir archivos de 'nuevas ediciones'
        /// </summary>
        public static void AgregarDatos_Serializar_NuevasEdiciones()
        {
            UnoInfo_ListaNuevasEdiciones.Add(new Informes("Cartulina", 250, "USD210", "145078", 1, DateTime.Parse("10/05/2021")));
            UnoInfo_ListaNuevasEdiciones.Add(new Informes("Papel Prensa", 250, "USD210", "145078", 1, DateTime.Parse("18/02/2021")));
            UnoInfo_ListaNuevasEdiciones.Add(new Informes("Estucado Mate", 250, "USD210", "145078", 1, DateTime.Parse("01/01/2021")));
            UnoInfo_ListaNuevasEdiciones.Add(new Informes("Ilustracion", 250, "USD210", "145078", 1, DateTime.Parse("22/01/2017")));
            UnoInfo_ListaNuevasEdiciones.Add(new Informes("Obra Ahuesado", 250, "USD210", "145078", 1, DateTime.Parse("05/03/2021")));
            UnoInfo_ListaNuevasEdiciones.Add(new Informes("Cartulina", 250, "USD210", "145078", 1, DateTime.Parse("05/03/2021")));

            serializacionInformes.Guardar(rutaNuevasEdiciones_UnoInfo, UnoInfo_ListaNuevasEdiciones);


            DosInfo_ListaNuevasEdiciones.Add(new Informes("Cartulina", 250, "USD210", "145078", 1, DateTime.Parse("22/02/2010")));
            DosInfo_ListaNuevasEdiciones.Add(new Informes("Cartulina", 250, "USD210", "145078", 1, DateTime.Parse("14/04/2021")));
            DosInfo_ListaNuevasEdiciones.Add(new Informes("Cartulina", 250, "USD210", "145078", 1, DateTime.Parse("11/06/2021")));
            DosInfo_ListaNuevasEdiciones.Add(new Informes("Cartulina", 250, "USD210", "145078", 1, DateTime.Parse("01/01/2021")));
            DosInfo_ListaNuevasEdiciones.Add(new Informes("Cartulina", 250, "USD210", "145078", 1, DateTime.Parse("01/01/2021")));


            serializacionInformes.Guardar(rutaNuevasEdiciones_DosInfo, DosInfo_ListaNuevasEdiciones);

            UnoDepo_ListaNuevasEdiciones.Add(new DepositoP(2, DepositoP.Formato.Bobina, "Obra Ahuesado", 90, "USD215", "130258", 1520));
            UnoDepo_ListaNuevasEdiciones.Add(new DepositoP(2, DepositoP.Formato.Hojas, "Obra Ahuesado", 90, "USD215", "130258", 1520));
            UnoDepo_ListaNuevasEdiciones.Add(new DepositoP(2, DepositoP.Formato.Bobina, "Estucado Brillante", 120, "USD219", "145369", 100));
            UnoDepo_ListaNuevasEdiciones.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Estucado Mate", 250, "USD215", "145872", 1));

            UnoDepo_ListaNuevasEdiciones.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Cartulina", 250, "USD210", "145078", 1));
            UnoDepo_ListaNuevasEdiciones.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Cartulina", 250, "USD210", "145078", 1));

            serializacionDep.Guardar(rutaNuevasEdiciones_UnoDepo, UnoDepo_ListaNuevasEdiciones);


            DosDepo_ListaNuevasEdiciones.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Estucado Mate", 90, "USD215", "136589", 1));
            DosDepo_ListaNuevasEdiciones.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Obra Ahuesado", 230, "USD210", "158745", 1));
            DosDepo_ListaNuevasEdiciones.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Papel Prensa", 75, "USD270", "136589", 1));
            DosDepo_ListaNuevasEdiciones.Add(new DepositoP(1, DepositoP.Formato.Bobina, "Cartulina", 250, "USD210", "145078", 1));

            serializacionDep.Guardar(rutaNuevasEdiciones_DosDepo, DosDepo_ListaNuevasEdiciones);

        }
    }
}
