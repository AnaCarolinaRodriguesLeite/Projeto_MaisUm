using System;
using System.Linq;
using MaisUm_Projeto.Models_;
using System.Web.Http;
using MaisUm_Projeto.Models_.Data;

namespace MaisUm_Projeto.Controllers
{
    public class AlimentacaoController : ApiController
    {
        public ApplicationDbContext _context;

        public AlimentacaoController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        // GET: api/Alimentacao
        public IHttpActionResult GetAlimentacoes()
        {
            var alimentacao = _context.Alimentacoes.ToList();
            return Ok(alimentacao);
        }

        [HttpGet]
        public IHttpActionResult GetAlimentacao(int id)
        {
            var alimentacao = _context.Alimentacoes.SingleOrDefault(a => a.AlimentacaoId == id);

            if (alimentacao == null)
                return NotFound();

            return Ok(alimentacao);
        }

        [HttpPost]
        public IHttpActionResult PostAlimentacao([FromBody] Alimentacao alimentacao)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Alimentacoes.Add(alimentacao);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + alimentacao.AlimentacaoId), alimentacao);
        }

        [HttpPut]
        public IHttpActionResult PutAlimentacao(int id, [FromBody] Alimentacao alimentacao)
        {
            var alimentacaoInDb = _context.Alimentacoes.SingleOrDefault(a => a.AlimentacaoId == id);

            if (alimentacaoInDb == null)
                return NotFound();

            alimentacaoInDb.Descricao = alimentacao.Descricao;
            alimentacaoInDb.Data = alimentacao.Data;

            _context.SaveChanges();
            return Ok(alimentacaoInDb);
        }

        [HttpDelete]
        public IHttpActionResult DeleteAlimentacao(int id)
        {
            var alimentacaoInDb = _context.Alimentacoes.SingleOrDefault(a => a.AlimentacaoId == id);

            if (alimentacaoInDb == null)
                return NotFound();

            _context.Alimentacoes.Remove(alimentacaoInDb);
            _context.SaveChanges();
            return Ok();
        }
    }
}