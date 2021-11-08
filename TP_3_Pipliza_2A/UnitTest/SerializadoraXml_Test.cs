using System;
using System.Collections.Generic;
using Entidades;
using Serializacion;
using Xunit.Sdk;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class SerializadoraXml_Test
    {
        // USO DE TESTS UNITARIOS

        SerializadoraXml<List<DepositoP>> serializadoraTesting = new SerializadoraXml<List<DepositoP>>();

        private static string rutaPub = AppDomain.CurrentDomain.BaseDirectory + "testInv";

        public List<DepositoP> listaInventarioUno = new List<DepositoP>();

        [TestMethod]
        public void SerializarGuardarXML_RutaVacia_Test()
        {
            Assert.IsFalse(serializadoraTesting.Guardar("", listaInventarioUno));
        }

        [TestMethod]
        public void SerializarGuardarXML_RutaCorrecta_Test()
        {
            Assert.IsTrue(serializadoraTesting.Guardar(rutaPub, listaInventarioUno));
        }

        [TestMethod]
        public void SerializarLeerXML_RutaVacia_Test()
        {
            Assert.ThrowsException<Exception>(() => serializadoraTesting.Leer("", out listaInventarioUno));
        }
    }
}