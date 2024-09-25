using System;
using System.Linq;
using System.Web.Http;
using MaisUm_Projeto.Models_;
using MaisUm_Projeto.Models_.Data;

namespace MaisUm_Projeto.Controllers
{
    public class UsuariosController : ApiController
    {
        private ApplicationDbContext _context;

        public UsuariosController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: api/Usuarios
        public IHttpActionResult GetUsuarios()
        {
            var usuarios = _context.Usuarios.ToList();
            return Ok(usuarios);
        }

        // GET: api/Usuarios/5
        public IHttpActionResult GetUsuario(int id)
        {
            var usuario = _context.Usuarios.SingleOrDefault(u => u.UsuarioId == id);
            if (usuario == null)
                return NotFound();

            return Ok(usuario);
        }

        // POST: api/Usuarios
        //public IHttpActionResult PostUsuario([FromBody] Usuario usuario)
        //{

        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);

        //    _context.Usuarios.Add(usuario);
        //    _context.SaveChanges();

        //    return Created(new Uri(Request.RequestUri + "/" + usuario.UsuarioId), usuario);
        //}

        public IHttpActionResult PostUsuario([FromBody] Usuarios usuario)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Usuarios.Add(usuario);

            try
            {
                _context.SaveChanges();
            }
            catch (System.Data.Entity.Core.UpdateException e)
            {
                // Log ou manipulação do erro de Update
                Console.WriteLine(e.InnerException);
                return InternalServerError(e);
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex) //DbContext
            {
                // Log ou manipulação do erro de Update
                Console.WriteLine(ex.InnerException);
                return InternalServerError(ex);
            }
            catch (Exception ex)
            {
                // Log ou manipulação de outros erros
                Console.WriteLine(ex.InnerException);
                throw;
            }

            return Created(new Uri(Request.RequestUri + "/" + usuario.UsuarioId), usuario);
        }


        // PUT: api/Usuarios/5
        public IHttpActionResult PutUsuario(int id, [FromBody] Usuarios usuarioAtualizado)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var usuarioInDb = _context.Usuarios.SingleOrDefault(u => u.UsuarioId == id);
            if (usuarioInDb == null)
                return NotFound();

            usuarioInDb.Nome = usuarioAtualizado.Nome;
            usuarioInDb.Email = usuarioAtualizado.Email;
            usuarioInDb.Senha = usuarioAtualizado.Senha;
            //usuarioInDb.DataCadastro = usuarioAtualizado.DataCadastro;

            _context.SaveChanges();

            return Ok(usuarioInDb);
        }

        // DELETE: api/Usuarios/5
        public IHttpActionResult DeleteUsuario(int id)
        {
            var usuarioInDb = _context.Usuarios.SingleOrDefault(u => u.UsuarioId == id);
            if (usuarioInDb == null)
                return NotFound();

            _context.Usuarios.Remove(usuarioInDb);
            _context.SaveChanges();

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}
