using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;
using Entidades;
using Serializacion;
using System.Collections.Generic;
using System;

namespace TestUnit
{
    [TestClass]
    public class SerializadoraXml_Test
    {
        //USO DE TESTS UNITARIOS

        SerializadoraXml<List<DepositoP>> serializadoraTesting = new SerializadoraXml<List<DepositoP>>();

        private static string rutaPub = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\testDep.xml";

        public List<DepositoP> listaDepositoPUno = new List<DepositoP>();

        [TestMethod]
        public void SerializarGuardarXML_RutaVacia_Test()
        {
            Assert.IsFalse(serializadoraTesting.Guardar("", listaDepositoPUno));
        }

        [TestMethod]
        public void SerializarGuardarXML_RutaCorrecta_Test()
        {
            Assert.IsTrue(serializadoraTesting.Guardar(rutaPub, listaDepositoPUno));
        }

        [TestMethod]
        public void SerializarLeerXML_RutaVacia_Test()
        {
            Assert.ThrowsException<Exception>(() => serializadoraTesting.Leer("", out listaDepositoPUno));

        }
    }
}