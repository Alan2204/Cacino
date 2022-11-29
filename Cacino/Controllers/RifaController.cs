using AutoMapper;
using Cacino.DTOs;
using Cacino.Entidades;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Cacino.Controllers
{
    [ApiController]
    [Route("Rifa")]
    public class RifaController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly IConfiguration configuration;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public RifaController(UserManager<IdentityUser> userManager, IConfiguration configuration, SignInManager<IdentityUser> signManager,
            ApplicationDbContext dbContext, IMapper mapper)
        {
            this.userManager = userManager;
            this.configuration = configuration;
            this.signInManager = signManager;
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Rifa>>> Get()
        {
            return await dbContext.Rifa.ToListAsync();
        }
        [AllowAnonymous]
        [HttpPost("Crear Rifa")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsAdmin")]
        public async Task<ActionResult> Post(RifaCreacionDTO rifaCreacionDTO)
        {


            var mismoNombre = await dbContext.Rifa.AnyAsync(x => x.Nombre == rifaCreacionDTO.Nombre);

            if (mismoNombre)
            {
                return BadRequest($"Ya existe una rifa registrada como {rifaCreacionDTO.Nombre}");
            }

            var rifa = mapper.Map<Rifa>(rifaCreacionDTO);


            dbContext.Add(rifa);

            await dbContext.SaveChangesAsync();

            var rifaDTO = mapper.Map<RifaDTO>(rifa);
            return CreatedAtRoute(new { id = rifa.Id }, rifaDTO);
        }



        [HttpPut("Modificar Rifa")]
        public async Task<ActionResult> Put(RifaCreacionDTO rifaCreacionDTO, int id)
        {
            var exist = await dbContext.Rifa.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                return NotFound("El recurso no fue encontrado");
            }

            var rifa = mapper.Map<Rifa>(rifaCreacionDTO);
            rifa.Id = id;

            dbContext.Update(rifa);
            await dbContext.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("Eliminar Rifa.")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist = await dbContext.Rifa.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                return NotFound("El Recurso no fue encontrado.");
            }

            dbContext.Remove(new Rifa()
            {
                Id = id
            });
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("Consultar Rifa")]
        public async Task<ActionResult<List<GetRifaDTO>>> GetAll()
        {
            var rifa = await dbContext.Rifa.ToListAsync();
            return mapper.Map<List<GetRifaDTO>>(rifa);
        }
    }
}
