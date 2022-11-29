using AutoMapper;
using Cacino.DTOs;
using Cacino.Entidades;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Cacino.Controllers
{
    [ApiController]
    [Route("Participante")]
    public class ParticipanteController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly IConfiguration configuration;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;


        public ParticipanteController(UserManager<IdentityUser> userManager, IConfiguration configuration, SignInManager<IdentityUser> signManager,
            ApplicationDbContext dbContext, IMapper mapper)
        {
            this.userManager = userManager;
            this.configuration = configuration;
            this.signInManager = signManager;
            this.dbContext = dbContext;
            this.mapper = mapper;
        }



        [HttpPost("Registrar Datos.")]
        public async Task<ActionResult> Put(ClienteCreacionDTO clienteCreacionDTO)
        {

            var mismoNombre = await dbContext.Cliente.AnyAsync(x => x.Nombre == clienteCreacionDTO.Nombre);
            var mismoApellido = await dbContext.Cliente.AnyAsync(x => x.Nombre == clienteCreacionDTO.Apellidos);

            if (mismoNombre && mismoApellido)
            {
                return BadRequest($"{clienteCreacionDTO.Nombre} {clienteCreacionDTO.Apellidos} ya esta registrado como cliente.");
            }


            var cliente = mapper.Map<Cliente>(clienteCreacionDTO);

            dbContext.Add(cliente);

            await dbContext.SaveChangesAsync();


            var clienteDTO = mapper.Map<GetClienteDTO>(cliente);
            return CreatedAtRoute(new { id = cliente.Id }, clienteDTO);

        }


        

    }
}