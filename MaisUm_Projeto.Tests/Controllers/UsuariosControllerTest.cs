using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MaisUm_Projeto.Controllers;
using MaisUm_Projeto.Models_;
using MaisUm_Projeto.Models_.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;

namespace MaisUm_Projeto.Tests.Controllers
{
    [TestClass]
    //Para o teste funcionar, precisa fazer a mockagem dos objetos, para passar no teste
    public class UsuariosControllerTests
    {
        //private Mock<ApplicationDbContext> _mockContext;
        //private UsuariosController _controller;

        //[TestInitialize]
        //public void Setup()
        //{
        //    _mockContext = new Mock<ApplicationDbContext>();
        //    _controller = new UsuariosController
        //    {
        //        _context = _mockContext.Object
        //    };
        //}

        //[TestMethod]
        //public void GetUsuarios_ShouldReturnAllUsuarios(int v)
        //{
        //    var usuarios = new List<Usuarios>
        //    {
        //        new Usuarios { UsuarioId = 1, Nome = "Usuario 1", Email = "usuario1@exemplo.com" },
        //        new Usuarios { UsuarioId = 2, Nome = "Usuario 2", Email = "usuario2@exemplo.com" }
        //    }.AsQueryable();

        //    _mockContext.Setup(c => c.Usuarios).Returns((System.Data.Entity.DbSet<Usuarios>)usuarios);

        //    var result = _controller.GetUsuarios() as OkNegotiatedContentResult<List<Usuarios>>;

        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(2, result.Content.Count);
        //}

        //[TestMethod]
        //public void GetUsuario_ById_ShouldReturnUsuario()
        //{
        //    var usuario = new Usuarios { UsuarioId = 1, Nome = "Usuario 1", Email = "usuario1@exemplo.com" };
        //    _mockContext.Setup(c => c.Usuarios).Returns((System.Data.Entity.DbSet<Usuarios>)new List<Usuarios> { usuario }.AsQueryable());

        //    var result = _controller.GetUsuario(1) as OkNegotiatedContentResult<Usuarios>;

        //    Assert.IsNotNull(result);
        //    Assert.AreEqual("Usuario 1", result.Content.Nome);
        //}

        //[TestMethod]
        //public void GetUsuario_ById_ShouldReturnNotFound()
        //{
        //    _mockContext.Setup(c => c.Usuarios).Returns((System.Data.Entity.DbSet<Usuarios>)new List<Usuarios>().AsQueryable());

        //    var result = _controller.GetUsuario(1);

        //    Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        //}

        //[TestMethod]
        //public void PostUsuario_ShouldCreateUsuario(string v)
        //{
        //    var usuario = new Usuarios { UsuarioId = 1, Nome = "Usuario 1", Email = "usuario1@exemplo.com" };
        //    _mockContext.Setup(c => c.Usuarios.Add(It.IsAny<Usuarios>())).Callback<Usuarios>(u => {
        //        u.UsuarioId = 1;
        //    });

        //    var result = _controller.PostUsuario(usuario) as CreatedNegotiatedContentResult<Usuarios>;

        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(1, result.Content.UsuarioId);
        //}

        //[TestMethod]
        //public void PostUsuario_ShouldReturnBadRequest_WhenUsuarioIsNull()
        //{
        //    var result = _controller.PostUsuario(null);

        //    Assert.IsInstanceOfType(result, typeof(BadRequestErrorMessageResult));
        //}

        //[TestMethod]
        //public void PutUsuario_ShouldUpdateUsuario(int v, string v1)
        //{
        //    var usuarioInDb = new Usuarios { UsuarioId = 1, Nome = "Usuario 1", Email = "usuario1@exemplo.com" };
        //    var usuarioAtualizado = new Usuarios { Nome = "Usuario Atualizado", Email = "usuarioatualizado@exemplo.com" };

        //    _mockContext.Setup(c => c.Usuarios).Returns((System.Data.Entity.DbSet<Usuarios>)new List<Usuarios> { usuarioInDb }.AsQueryable());

        //    var result = _controller.PutUsuario(1, usuarioAtualizado) as OkNegotiatedContentResult<Usuarios>;

        //    Assert.IsNotNull(result);
        //    Assert.AreEqual("Usuario Atualizado", result.Content.Nome);
        //}

        //[TestMethod]
        //public void PutUsuario_ShouldReturnNotFound_WhenUsuarioDoesNotExist()
        //{
        //    var usuarioAtualizado = new Usuarios { Nome = "Usuario Atualizado", Email = "usuarioatualizado@exemplo.com" };
        //    var result = _controller.PutUsuario(1, usuarioAtualizado);

        //    Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        //}

        //[TestMethod]
        //public void DeleteUsuario_ShouldRemoveUsuario()
        //{
        //    var usuarioInDb = new Usuarios { UsuarioId = 1, Nome = "Usuario 1", Email = "usuario1@exemplo.com" };
        //    _mockContext.Setup(c => c.Usuarios).Returns((System.Data.Entity.DbSet<Usuarios>)new List<Usuarios> { usuarioInDb }.AsQueryable());

        //    var result = _controller.DeleteUsuario(1) as OkResult;

        //    Assert.IsNotNull(result);
        //}

        //[TestMethod]
        //public void DeleteUsuario_ShouldReturnNotFound_WhenUsuarioDoesNotExist(int v)
        //{
        //    _mockContext.Setup(c => c.Usuarios).Returns((System.Data.Entity.DbSet<Usuarios>)new List<Usuarios>().AsQueryable());

        //    var result = _controller.DeleteUsuario(1);

        //    Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        //}
    }
}
