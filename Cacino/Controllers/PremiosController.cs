using AutoMapper;
using Cacino.DTOs;
using Cacino.Entidades;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cacino.Controllers
{
    [ApiController]
    [Route("Rifa/{rifaId:int}/Premios")]
    public class PremiosController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly IConfiguration configuration;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public PremiosController(UserManager<IdentityUser> userManager, IConfiguration configuration, SignInManager<IdentityUser> signManager,
            ApplicationDbContext dbContext, IMapper mapper)
        {
            this.userManager = userManager;
            this.configuration = configuration;
            this.signInManager = signManager;
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post(int rifaId, PremiosCreacionDTO premiosCreacionDTO)
        {

            var existeRifa = await dbContext.Rifa.AnyAsync(rifaDB => rifaDB.Id == rifaId);
            if (!existeRifa)
            {
                return NotFound();
            }

            var mismoLugar = await dbContext.Premios.AnyAsync(x => x.Lugar == premiosCreacionDTO.Lugar);
            var mismoId = await dbContext.Premios.AnyAsync(x => x.RifaId == rifaId);

            if (mismoId && mismoLugar)
            {
                return BadRequest("Los lugares no se pueden repetir en una misma rifa. ");
            }

            var premios = mapper.Map<Premios>(premiosCreacionDTO);
            premios.RifaId = rifaId;

            dbContext.Add(premios);

            await dbContext.SaveChangesAsync();

            var premiosDTO = mapper.Map<PremiosDTO>(premios);
            return CreatedAtRoute(new { id = premios.Id }, premiosDTO);

        }
    }
}
