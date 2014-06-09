using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MF0493_3.Models;

namespace Pruebas
{
    [TestClass]
    public class UsuarioTest
    {
        [TestMethod]
        public void validarTest()
        {
            Usuario u = UserManager.get("admin");
            Assert.IsTrue(u.validar("aaa111..."));
        }
    }
}