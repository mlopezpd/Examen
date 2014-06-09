using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MF0493_3.Models;

namespace Pruebas
{
    [TestClass]
    public class UserManagerTest
    {
        [TestMethod]
        public void CrearAdminTest()
        {
            UserManager.CrearAdmin();
            Usuario u = UserManager.get("admin");
            Assert.IsNotNull(u);
            Assert.AreEqual(u.username, "admin");
        }
        [TestMethod]
        public void getAll()
        {
            List<Usuario> lista = UserManager.getAll();
            int nUsuarios = lista.Count;
            Usuario u = new Usuario();
            u.username = "usuario";
            u.passwdSinCifrar = "usuario";
            u.email = "usuario@gmail.com";
            u.activo = true;
            Assert.IsTrue(UserManager.NuevoUsuario(u));

            List<Usuario> lista2 = UserManager.getAll();
            int nUsuarios2 = lista2.Count;
            Assert.AreEqual(nUsuarios + 1, nUsuarios2);
        }
    }
}
