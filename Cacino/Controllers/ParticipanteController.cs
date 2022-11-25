using Cacino.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Cacino.Controllers
{
    [ApiController]
    [Route("Participante")]
    public class ParticipanteController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public ParticipanteController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult<List<Participante>>> Get()
        {
            return await dbContext.Participantes.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Participante participante)
        {
            dbContext.Add(participante);
            await dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}