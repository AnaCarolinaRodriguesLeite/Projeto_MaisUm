using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MaisUm_Projeto.Controllers;
using MaisUm_Projeto.Models_;
using MaisUm_Projeto.Models_.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;
using System;
using System.Data.Entity;

namespace MaisUm_Projeto.Tests.Controllers
{
    [TestClass]
    //Para o teste funcionar, precisa fazer a mockagem dos objetos, para passar no teste
    public class ProgressoControllerTests
    {
        //private Mock<ApplicationDbContext> _mockContext;
        //private Mock<DbSet<Progresso>> _mockSet;
        //private ProgressoController _controller;

        //[TestInitialize]
        //public void Setup()
        //{
        //    _mockContext = new Mock<ApplicationDbContext>();
        //    _mockSet = new Mock<DbSet<Progresso>>();
        //    _controller = new ProgressoController
        //    {
        //        _context = _mockContext.Object
        //    };
        //}

        //[TestMethod]
        //public void GetProgressos_ShouldReturnAllProgressos()
        //{
        //    var progressos = new List<Progresso>
        //    {
        //        new Progresso { ProgressoId = 1, Peso = 70, Data = DateTime.Now.ToString() },
        //        new Progresso { ProgressoId = 2, Peso = 75, Data = DateTime.Now.AddDays(-1).ToString() }
        //    }.AsQueryable();

        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.Provider).Returns(progressos.Provider);
        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.Expression).Returns(progressos.Expression);
        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.ElementType).Returns(progressos.ElementType);
        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.GetEnumerator()).Returns(progressos.GetEnumerator());

        //    _mockContext.Setup(c => c.Progresso).Returns(_mockSet.Object);

        //    var result = _controller.GetProgressos() as OkNegotiatedContentResult<List<Progresso>>;

        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(2, result.Content.Count);
        //}

        //[TestMethod]
        //public void GetProgresso_ById_ShouldReturnProgresso()
        //{
        //    var progresso = new Progresso { ProgressoId = 1, Peso = 70, Data = DateTime.Now.ToString() };
        //    var progressos = new List<Progresso> { progresso }.AsQueryable();

        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.Provider).Returns(progressos.Provider);
        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.Expression).Returns(progressos.Expression);
        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.ElementType).Returns(progressos.ElementType);
        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.GetEnumerator()).Returns(progressos.GetEnumerator());

        //    _mockContext.Setup(c => c.Progresso).Returns(_mockSet.Object);

        //    var result = _controller.GetProgresso(1) as OkNegotiatedContentResult<Progresso>;

        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(70, result.Content.Peso);
        //}

        //[TestMethod]
        //public void GetProgresso_ById_ShouldReturnNotFound()
        //{
        //    var progressos = new List<Progresso>().AsQueryable();

        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.Provider).Returns(progressos.Provider);
        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.Expression).Returns(progressos.Expression);
        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.ElementType).Returns(progressos.ElementType);
        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.GetEnumerator()).Returns(progressos.GetEnumerator());

        //    _mockContext.Setup(c => c.Progresso).Returns(_mockSet.Object);

        //    var result = _controller.GetProgresso(1);

        //    Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        //}

        //[TestMethod]
        //public void Post_ShouldCreateProgresso()
        //{
        //    var progresso = new Progresso { ProgressoId = 1, Peso = 70, Data = DateTime.Now.ToString() };
        //    _mockSet.Setup(m => m.Add(It.IsAny<Progresso>())).Callback<Progresso>(p => {
        //        p.ProgressoId = 1;
        //    });

        //    _mockContext.Setup(c => c.Progresso).Returns(_mockSet.Object);

        //    var result = _controller.Post(progresso) as CreatedNegotiatedContentResult<Progresso>;

        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(1, result.Content.ProgressoId);
        //}

        //[TestMethod]
        //public void Post_ShouldReturnBadRequest_WhenProgressoIsNull()
        //{
        //    var result = _controller.Post(null);

        //    Assert.IsInstanceOfType(result, typeof(BadRequestErrorMessageResult));
        //}

        //[TestMethod]
        //public void PutProgresso_ShouldUpdateProgresso()
        //{
        //    var progressoInDb = new Progresso { ProgressoId = 1, Peso = 70, Data = DateTime.Now.ToString() };
        //    var progressoAtualizado = new Progresso { Peso = 75, Data = DateTime.Now.AddDays(1).ToString() };
        //    var progressos = new List<Progresso> { progressoInDb }.AsQueryable();

        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.Provider).Returns(progressos.Provider);
        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.Expression).Returns(progressos.Expression);
        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.ElementType).Returns(progressos.ElementType);
        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.GetEnumerator()).Returns(progressos.GetEnumerator());

        //    _mockContext.Setup(c => c.Progresso).Returns(_mockSet.Object);

        //    var result = _controller.PutProgresso(1, progressoAtualizado) as OkNegotiatedContentResult<Progresso>;

        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(75, result.Content.Peso);
        //}

        //[TestMethod]
        //public void PutProgresso_ShouldReturnNotFound_WhenProgressoDoesNotExist()
        //{
        //    var progressoAtualizado = new Progresso { Peso = 75, Data = DateTime.Now.AddDays(1).ToString() };
        //    var progressos = new List<Progresso>().AsQueryable();

        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.Provider).Returns(progressos.Provider);
        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.Expression).Returns(progressos.Expression);
        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.ElementType).Returns(progressos.ElementType);
        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.GetEnumerator()).Returns(progressos.GetEnumerator());

        //    _mockContext.Setup(c => c.Progresso).Returns(_mockSet.Object);

        //    var result = _controller.PutProgresso(1, progressoAtualizado);

        //    Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        //}

        //[TestMethod]
        //public void DeleteProgresso_ShouldRemoveProgresso()
        //{
        //    var progressoInDb = new Progresso { ProgressoId = 1, Peso = 70, Data = DateTime.Now.ToString() };
        //    var progressos = new List<Progresso> { progressoInDb }.AsQueryable();

        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.Provider).Returns(progressos.Provider);
        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.Expression).Returns(progressos.Expression);
        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.ElementType).Returns(progressos.ElementType);
        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.GetEnumerator()).Returns(progressos.GetEnumerator());

        //    _mockContext.Setup(c => c.Progresso).Returns(_mockSet.Object);

        //    var result = _controller.DeleteProgresso(1) as OkResult;

        //    Assert.IsNotNull(result);
        //}

        //[TestMethod]
        //public void DeleteProgresso_ShouldReturnNotFound_WhenProgressoDoesNotExist()
        //{
        //    var progressos = new List<Progresso>().AsQueryable();

        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.Provider).Returns(progressos.Provider);
        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.Expression).Returns(progressos.Expression);
        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.ElementType).Returns(progressos.ElementType);
        //    _mockSet.As<IQueryable<Progresso>>().Setup(m => m.GetEnumerator()).Returns(progressos.GetEnumerator());

        //    _mockContext.Setup(c => c.Progresso).Returns(_mockSet.Object);

        //    var result = _controller.DeleteProgresso(1);

        //    Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        //}
    }
}
