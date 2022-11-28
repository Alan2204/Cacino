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
        [HttpGet("Consultar Rifa")]
        public async Task<ActionResult<List<Cliente>>> Get()
        {
            return await dbContext.Cliente.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Cliente participante)
        {
            dbContext.Add(participante);
            await dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}