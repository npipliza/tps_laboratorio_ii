using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;
using Entidades;
using Serializacion;
using System.Collections.Generic;
using System;

namespace TestUnit
{
    [TestClass]
    public class ClienteMetodoDeExtension_Test
    {
        Clientes cliente1 = new Clientes("IMPRENTA 14");
        Inventario inventario1 = new Inventario("IMPRENTA 12", Inventario.TipoPapel.EstucadoBrillante);
        Inventario inventario2 = new Inventario("IMPRENTA 5", Inventario.TipoPapel.Cartulina);
        Inventario inventario3 = new Inventario("IMPRENTA 1", Inventario.TipoPapel.EstucadoMate);
        Inventario inventario4 = new Inventario("IMPRENTA 12", Inventario.TipoPapel.PapelPrensa);


        [TestMethod]
        public void ObtenerInventarioPorCadaCliente_Test()
        {
            Informes informe1 = new Informes("Papel Prensa", 250, "USD215", "154721", 1, DateTime.Parse("22/02/2018"));
            Informes informe2 = new Informes("Estucado Brillante", 119, "USD215", "125478", 1, DateTime.Parse("15/03/2018"));
            Informes informe3 = new Informes("Ilustracion", 95, "USD215", "154852", 1, DateTime.Parse("15/05/2016"));
            Informes informe4 = new Informes("Cartulina", 205, "USD215", "68524", 1, DateTime.Parse("01/01/2010"));

            cliente1.inventario.Add(inventario1);
            inventario1.informes.Add(informe1);
            cliente1.inventario.Add(inventario2);
            inventario1.informes.Add(informe2);
            cliente1.inventario.Add(inventario3);
            inventario1.informes.Add(informe3);
            cliente1.inventario.Add(inventario4);
            inventario1.informes.Add(informe4);

            Assert.AreEqual(4, cliente1.CantidadInformesPorCliente());

        }

        [TestMethod]
        public void ObtenerDepositosPorCadaCliente_Test()
        {
            DepositoP deposito1 = new DepositoP(1, DepositoP.Formato.Hojas, "Esstucado Brillante", 120, "USD230", "154215", 521);
            DepositoP deposito2 = new DepositoP(2, DepositoP.Formato.Bobina, "Cartulina", 118, "USD220", "136589", 84521);
            DepositoP deposito3 = new DepositoP(2, DepositoP.Formato.Hojas, "Ilustarcion", 250, "usd205", "175421", 1200);
            DepositoP deposito4 = new DepositoP(1, DepositoP.Formato.Bobina, "Estucado Brillante", 95, "usd215", "102458", 522);

            cliente1.inventario.Add(inventario1);
            inventario1.deposito.Add(deposito1);
            cliente1.inventario.Add(inventario2);
            inventario1.deposito.Add(deposito2);
            cliente1.inventario.Add(inventario3);
            inventario1.deposito.Add(deposito3);
            cliente1.inventario.Add(inventario4);
            inventario1.deposito.Add(deposito4);

            Assert.AreEqual(4, cliente1.CantidadDepositosPorCliente());

        }
    }
}