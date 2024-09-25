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
            UsuariosControllerTests controller = new UsuariosControllerTests();

            // Agir
            IEnumerable<string> result = (IEnumerable<string>)controller.GetType();

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
            UsuariosControllerTests controller = new UsuariosControllerTests();

            // Agir
            controller.GetUsuarios_ShouldReturnAllUsuarios(5);

            // Declarar
            // Adicione asserções apropriadas aqui, se necessário
        }

        [TestMethod]
        public void Post()
        {
            // Organizar
            UsuariosControllerTests controller = new UsuariosControllerTests();

            // Agir
            controller.PostUsuario_ShouldCreateUsuario("value");

            // Declarar
        }

        [TestMethod]
        public void Put()
        {
            // Organizar
            UsuariosControllerTests controller = new UsuariosControllerTests();

            // Agir
            controller.PutUsuario_ShouldUpdateUsuario(5, "value");

            // Declarar
        }

        [TestMethod]
        public void Delete()
        {
            // Organizar
            UsuariosControllerTests controller = new UsuariosControllerTests();

            // Agir
            controller.DeleteUsuario_ShouldReturnNotFound_WhenUsuarioDoesNotExist(5);

            // Declarar
        }
    }
}
