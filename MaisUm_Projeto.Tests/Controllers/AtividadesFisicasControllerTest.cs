using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MaisUm_Projeto.Controllers;
using MaisUm_Projeto.Models_;
using MaisUm_Projeto.Models_.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;
using System.Runtime.Remoting.Contexts;

namespace MaisUm_Projeto.Tests.Controllers
{
    [TestClass]
    //Para o teste funcionar, precisa fazer a mockagem dos objetos, para passar no teste
    public class AtividadesFisicasControllerTests
    {
        //private Mock<ApplicationDbContext> _mockContext;
        //private AtividadesFisicasController _controller;

        //[TestInitialize]
        //public void Setup()
        //{
        //    _mockContext = new Mock<ApplicationDbContext>();
        //    _controller = new AtividadesFisicasController
        //    {
        //        // Substitua a instância real do contexto pelo mock
        //        _context = _mockContext.Object
        //    };
        //}

        //[TestMethod]
        //public void Get_ShouldReturnAllAtividades()
        //{
        //    var atividades = new List<AtividadesFisica>
        //    {
        //        new AtividadesFisica { AtividadeId = 1, Nome = "Caminhada" },
        //        new AtividadesFisica { AtividadeId = 2, Nome = "Corrida" }
        //    }.AsQueryable();

        //    _mockContext.Setup(c => c.AtividadesFisicas).Returns((System.Data.Entity.DbSet<AtividadesFisica>)atividades);

        //    var result = _controller.Get() as OkNegotiatedContentResult<List<AtividadesFisica>>;

        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(2, result.Content.Count);
        //}

        //[TestMethod]
        //public void Get_ById_ShouldReturnAtividade()
        //{
        //    var atividade = new AtividadesFisica { AtividadeId = 1, Nome = "Caminhada" };
        //    _mockContext.Setup(c => c.AtividadesFisicas).Returns((System.Data.Entity.DbSet<AtividadesFisica>)new List<AtividadesFisica> { atividade }.AsQueryable());

        //    var result = _controller.Get(1) as OkNegotiatedContentResult<AtividadesFisica>;

        //    Assert.IsNotNull(result);
        //    Assert.AreEqual("Caminhada", result.Content.Nome);
        //}

        //[TestMethod]
        //public void Get_ById_ShouldReturnNotFound()
        //{
        //    _mockContext.Setup(c => c.AtividadesFisicas).Returns((System.Data.Entity.DbSet<AtividadesFisica>)new List<AtividadesFisica>().AsQueryable());

        //    var result = _controller.Get(1);

        //    Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        //}

        //[TestMethod]
        //public void Post_ShouldCreateAtividade()
        //{
        //    var atividade = new AtividadesFisica { AtividadeId = 1, Nome = "Caminhada" };
        //    _mockContext.Setup(c => c.AtividadesFisicas.Add(It.IsAny<AtividadesFisica>())).Callback<AtividadesFisica>(a => {
        //        a.AtividadeId = 1; // Simulando a atribuição de um ID
        //    });

        //    var result = _controller.Post(atividade) as CreatedNegotiatedContentResult<AtividadesFisica>;

        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(1, result.Content.AtividadeId);
        //}

        //[TestMethod]
        //public void Post_ShouldReturnBadRequest_WhenAtividadeIsNull()
        //{
        //    var result = _controller.Post(null);

        //    Assert.IsInstanceOfType(result, typeof(BadRequestErrorMessageResult));
        //}

        //[TestMethod]
        //public void Put_ShouldUpdateAtividade()
        //{
        //    var atividade = new AtividadesFisica { AtividadeId = 1, Nome = "Caminhada", DuracaoMinutos = 30 };
        //    var atividadeAtualizada = new AtividadesFisica { Nome = "Caminhada Atualizada", DuracaoMinutos = 60 };

        //    _mockContext.Setup(c => c.AtividadesFisicas).Returns((System.Data.Entity.DbSet<AtividadesFisica>)new List<AtividadesFisica> { atividade }.AsQueryable());

        //    var result = _controller.Put(1, atividadeAtualizada) as OkNegotiatedContentResult<AtividadesFisica>;

        //    Assert.IsNotNull(result);
        //    Assert.AreEqual("Caminhada Atualizada", result.Content.Nome);
        //    Assert.AreEqual(60, result.Content.DuracaoMinutos);
        //}

        //[TestMethod]
        //public void Put_ShouldReturnNotFound_WhenAtividadeDoesNotExist()
        //{
        //    var atividadeAtualizada = new AtividadesFisica { Nome = "Caminhada Atualizada" };
        //    var result = _controller.Put(1, atividadeAtualizada);

        //    Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        //}

        //[TestMethod]
        //public void Delete_ShouldRemoveAtividade()
        //{
        //    var atividade = new AtividadesFisica { AtividadeId = 1, Nome = "Caminhada" };
        //    _mockContext.Setup(c => c.AtividadesFisicas).Returns((System.Data.Entity.DbSet<AtividadesFisica>)new List<AtividadesFisica> { atividade }.AsQueryable());

        //    var result = _controller.Delete(1) as OkResult;

        //    Assert.IsNotNull(result);
        //}

        //[TestMethod]
        //public void Delete_ShouldReturnNotFound_WhenAtividadeDoesNotExist()
        //{
        //    _mockContext.Setup(c => c.AtividadesFisicas).Returns((System.Data.Entity.DbSet<AtividadesFisica>)new List<AtividadesFisica>().AsQueryable());

        //    var result = _controller.Delete(1);

        //    Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        //}
    }
}
