using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MF0493_3.Models;

namespace Pruebas
{
    [TestClass]
    public class EmpresaManagerTest
    {
        [TestMethod]
        public void getTest()
        {
            Empresa e = new Empresa();
            e.nif = "00000000t";
            Assert.IsTrue(EmpresaManager.Nueva(e));
            Assert.AreEqual(EmpresaManager.get(e.nif).nif, e.nif);
            Assert.IsTrue(EmpresaManager.Eliminar(e.nif));
        }
        [TestMethod]
        public void NuevaTest()
        {
            Empresa e = new Empresa();
            e.nif = "00000000t";
            Assert.IsTrue(EmpresaManager.Nueva(e));
            Assert.IsTrue(EmpresaManager.Eliminar(e.nif));
        }
        [TestMethod]
        public void ModificarTest()
        {
            Empresa e = new Empresa();
            e.nif = "00000000t";
            Assert.IsTrue(EmpresaManager.Nueva(e));
            e.nombre = "empresa";
            e.poblacion = "almeria";
            Assert.IsTrue(EmpresaManager.Modificar(e));
            Assert.AreEqual(EmpresaManager.get(e.nif).nombre, "empresa");
            Assert.AreEqual(EmpresaManager.get(e.nif).poblacion, "almeria");
            Assert.IsTrue(EmpresaManager.Eliminar(e.nif));
        }
        [TestMethod]
        public void EliminarTest()
        {
            Empresa e = new Empresa();
            e.nif = "00000000t";
            Assert.IsTrue(EmpresaManager.Nueva(e));
            Assert.IsTrue(EmpresaManager.Eliminar(e.nif));
        }
    }
}
