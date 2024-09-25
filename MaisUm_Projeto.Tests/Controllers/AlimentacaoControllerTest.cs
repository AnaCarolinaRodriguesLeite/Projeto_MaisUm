using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MaisUm_Projeto.Controllers;
using MaisUm_Projeto.Models_;
using MaisUm_Projeto.Models_.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;

namespace MaisUm_Projeto.Tests.Controllers
{
    [TestClass]
    //Para o teste funcionar, precisa fazer a mockagem dos objetos, para passar no teste
    public class AlimentacaoControllerTests
    {
        //private Mock<ApplicationDbContext> _mockContext;
        //private AlimentacaoController _controller;

        //[TestInitialize]
        //public void Setup()
        //{
        //    _mockContext = new Mock<ApplicationDbContext>();
        //    _controller = new AlimentacaoController
        //    {
        //        _context = _mockContext.Object
        //    };
        //}

        //[TestMethod]
        //public void GetAlimentacoes_ShouldReturnAllAlimentacoes()
        //{
        //    var alimentacoes = new List<Alimentacao>
        //    {
        //        new Alimentacao { AlimentacaoId = 1, Descricao = "Almoço" },
        //        new Alimentacao { AlimentacaoId = 2, Descricao = "Jantar" }
        //    }.AsQueryable();

        //    _mockContext.Setup(c => c.Alimentacoes).Returns((System.Data.Entity.DbSet<Alimentacao>)alimentacoes);

        //    var result = _controller.GetAlimentacoes() as OkNegotiatedContentResult<List<Alimentacao>>;

        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(2, result.Content.Count);
        //}

        //[TestMethod]
        //public void GetAlimentacao_ById_ShouldReturnAlimentacao()
        //{
        //    var alimentacao = new Alimentacao { AlimentacaoId = 1, Descricao = "Almoço" };
        //    _mockContext.Setup(c => c.Alimentacoes).Returns((System.Data.Entity.DbSet<Alimentacao>)new List<Alimentacao> { alimentacao }.AsQueryable());

        //    var result = _controller.GetAlimentacao(1) as OkNegotiatedContentResult<Alimentacao>;

        //    Assert.IsNotNull(result);
        //    Assert.AreEqual("Almoço", result.Content.Descricao);
        //}

        //[TestMethod]
        //public void GetAlimentacao_ById_ShouldReturnNotFound()
        //{
        //    _mockContext.Setup(c => c.Alimentacoes).Returns((System.Data.Entity.DbSet<Alimentacao>)new List<Alimentacao>().AsQueryable());

        //    var result = _controller.GetAlimentacao(1);

        //    Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        //}

        //[TestMethod]
        //public void PostAlimentacao_ShouldCreateAlimentacao()
        //{
        //    var alimentacao = new Alimentacao { AlimentacaoId = 1, Descricao = "Almoço" };
        //    _mockContext.Setup(c => c.Alimentacoes.Add(It.IsAny<Alimentacao>())).Callback<Alimentacao>(a => {
        //        a.AlimentacaoId = 1; // Simulando a atribuição de um ID
        //    });

        //    var result = _controller.PostAlimentacao(alimentacao) as CreatedNegotiatedContentResult<Alimentacao>;

        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(1, result.Content.AlimentacaoId);
        //}

        //[TestMethod]
        //public void PostAlimentacao_ShouldReturnBadRequest_WhenModelStateIsInvalid()
        //{
        //    _controller.ModelState.AddModelError("Descricao", "Required");

        //    var result = _controller.PostAlimentacao(new Alimentacao());

        //    Assert.IsInstanceOfType(result, typeof(BadRequestResult));
        //}

        //[TestMethod]
        //public void PutAlimentacao_ShouldUpdateAlimentacao()
        //{
        //    var alimentacaoInDb = new Alimentacao { AlimentacaoId = 1, Descricao = "Almoço" };
        //    var alimentacaoAtualizada = new Alimentacao { Descricao = "Almoço Atualizado" };

        //    _mockContext.Setup(c => c.Alimentacoes).Returns((System.Data.Entity.DbSet<Alimentacao>)new List<Alimentacao> { alimentacaoInDb }.AsQueryable());

        //    var result = _controller.PutAlimentacao(1, alimentacaoAtualizada) as OkNegotiatedContentResult<Alimentacao>;

        //    Assert.IsNotNull(result);
        //    Assert.AreEqual("Almoço Atualizado", result.Content.Descricao);
        //}

        //[TestMethod]
        //public void PutAlimentacao_ShouldReturnNotFound_WhenAlimentacaoDoesNotExist()
        //{
        //    var alimentacaoAtualizada = new Alimentacao { Descricao = "Almoço Atualizado" };
        //    var result = _controller.PutAlimentacao(1, alimentacaoAtualizada);

        //    Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        //}

        //[TestMethod]
        //public void DeleteAlimentacao_ShouldRemoveAlimentacao()
        //{
        //    var alimentacaoInDb = new Alimentacao { AlimentacaoId = 1, Descricao = "Almoço" };
        //    _mockContext.Setup(c => c.Alimentacoes).Returns((System.Data.Entity.DbSet<Alimentacao>)new List<Alimentacao> { alimentacaoInDb }.AsQueryable());

        //    var result = _controller.DeleteAlimentacao(1) as OkResult;

        //    Assert.IsNotNull(result);
        //}

        //[TestMethod]
        //public void DeleteAlimentacao_ShouldReturnNotFound_WhenAlimentacaoDoesNotExist()
        //{
        //    _mockContext.Setup(c => c.Alimentacoes).Returns((System.Data.Entity.DbSet<Alimentacao>)new List<Alimentacao>().AsQueryable());

        //    var result = _controller.DeleteAlimentacao(1);

        //    Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        //}
    }
}
