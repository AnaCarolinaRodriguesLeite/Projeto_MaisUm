using System.Linq;
using MaisUm_Projeto.Models_;
using System.Web.Http;
using MaisUm_Projeto.Models_.Data;

namespace MaisUm_Projeto.Controllers
{
    public class AtividadesFisicasController : ApiController
    {
        private ApplicationDbContext _context;

            public AtividadesFisicasController()
            {
                _context = new ApplicationDbContext();
            }

            // GET: api/AtividadesFisicas
            public IHttpActionResult Get()
            {
            var atividades = _context.AtividadesFisicas.ToList();
            return Ok(atividades);
            }

            // GET: api/AtividadesFisicas/5
            public IHttpActionResult Get(int id)
            {
                var atividade = _context.AtividadesFisicas.FirstOrDefault(a => a.AtividadeId == id);
                if (atividade == null)
                    return NotFound();
                return Ok(atividade);
            }

            // POST: api/AtividadesFisicas
            public IHttpActionResult Post([FromBody] AtividadeFisica atividade)
            {
                if (atividade == null)
                    return BadRequest("Atividade inválida.");

                _context.AtividadesFisicas.Add(atividade);
                return Ok(atividade);
            }

            // PUT: api/AtividadesFisicas/5
            public IHttpActionResult Put(int id, [FromBody] AtividadeFisica atividadeAtualizada)
            {
                var atividade = _context.AtividadesFisicas.FirstOrDefault(a => a.AtividadeId == id);
                if (atividade == null)
                    return NotFound();

                atividade.Nome = atividadeAtualizada.Nome;
                atividade.Data = atividadeAtualizada.Data;
                atividade.DuracaoMinutos = atividadeAtualizada.DuracaoMinutos;

                return Ok(atividade);
            }

            // DELETE: api/AtividadesFisicas/5
            public IHttpActionResult Delete(int id)
            {
                var atividade = _context.AtividadesFisicas.FirstOrDefault(a => a.AtividadeId == id);
                if (atividade == null)
                    return NotFound();

                _context.AtividadesFisicas.Remove(atividade);
                return Ok();
            }
    }
}