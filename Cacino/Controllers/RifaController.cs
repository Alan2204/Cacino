using Cacino.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Cacino.Controllers
{
    [ApiController]
    [Route("Rifa")]
    public class RifaController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public RifaController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult<List<Rifa>>> Get()
        {
            return await dbContext.Rifa.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Rifa rifa)
        {
            dbContext.Add(rifa);
            await dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
