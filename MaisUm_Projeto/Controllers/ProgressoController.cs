using System;
using System.Linq;
using System.Web.Http;
using MaisUm_Projeto.Models_;
using MaisUm_Projeto.Models_.Data;

namespace MaisUm_Projeto.Controllers
{
    public class ProgressoController : ApiController
    {
        private ApplicationDbContext _context;

        public ProgressoController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        public IHttpActionResult GetProgressos()
        {
            var progresso = _context.Progresso.ToList();
            return Ok(progresso);
        }

        [HttpGet]
        public IHttpActionResult GetProgresso(int id)
        {
            var progresso = _context.Progresso.SingleOrDefault(p => p.ProgressoId == id);
            if (progresso == null)
                return NotFound();
            return Ok(progresso);
        }

        [HttpPost]
        //public IHttpActionResult PostProgresso([FromBody] Progresso progresso)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);

        //    _context.Progresso.Add(progresso);
        //    _context.SaveChanges();

        //    return Created(new Uri(Request.RequestUri + "/" + progresso.ProgressoId), progresso);
        //}

        public IHttpActionResult Post([FromBody] Progresso progresso)
        {
            if (progresso == null)
                return BadRequest("Progresso inválido.");

            _context.Progresso.Add(progresso);
            _context.SaveChanges();
            return Created(new Uri(Request.RequestUri + "/" + progresso.ProgressoId), progresso);
        }

        [HttpPut]
        public IHttpActionResult PutProgresso(int id, [FromBody] Progresso progresso)
        {
            var progressoInDb = _context.Progresso.SingleOrDefault(p => p.ProgressoId == id);

            if (progressoInDb == null)
                return NotFound();

            progressoInDb.Peso = progresso.Peso;
            progressoInDb.Data = progresso.Data;

            _context.SaveChanges();
            return Ok(progressoInDb);
        }

        [HttpDelete]
        public IHttpActionResult DeleteProgresso(int id)
        {
            var progressoInDb = _context.Progresso.SingleOrDefault(p => p.ProgressoId == id);

            if (progressoInDb == null)
                return NotFound();

            _context.Progresso.Remove(progressoInDb);
            _context.SaveChanges();
            return Ok();
        }
    }
}