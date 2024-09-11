using System.Web.Mvc;
using MaisUm_Projeto;
using MaisUm_Projeto.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaisUm_Projeto.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Organizar
            HomeController controller = new HomeController();

            // Agir
            ViewResult result = controller.Index() as ViewResult;

            // Declarar
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
