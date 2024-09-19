using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using MaisUm_Projeto;
using MaisUm_Projeto.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaisUm_Projeto.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Organizar
            UsuariosController controller = new UsuariosController();

            // Agir
            IEnumerable<string> result = controller.Get();

            // Declarar
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Organizar
            UsuariosController controller = new UsuariosController();

            // Agir
            string result = controller.Get(5);

            // Declarar
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Organizar
            UsuariosController controller = new UsuariosController();

            // Agir
            controller.Post("value");

            // Declarar
        }

        [TestMethod]
        public void Put()
        {
            // Organizar
            UsuariosController controller = new UsuariosController();

            // Agir
            controller.Put(5, "value");

            // Declarar
        }

        [TestMethod]
        public void Delete()
        {
            // Organizar
            UsuariosController controller = new UsuariosController();

            // Agir
            controller.Delete(5);

            // Declarar
        }
    }
}
