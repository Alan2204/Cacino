using AutoMapper;
using Cacino.DTOs;
using Cacino.Entidades;

namespace Cacino.Utilidades
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ClienteDTO, Cliente>().ReverseMap();
            CreateMap<Cliente, GetClienteDTO>();
            CreateMap<ClienteCreacionDTO, Cliente>();

            //CreateMap<Cliente, ClienteDTOconRifa>()
            //   .ForMember(clienteDTO => clienteDTO.Rifa, opciones => opciones.MapFrom(MapClienteDTORifa));


            CreateMap<PremiosDTO, Premios>().ReverseMap();
            CreateMap<PremiosCreacionDTO, Premios>();

            CreateMap<RifaDTO, Rifa>().ReverseMap();
            CreateMap<Rifa, GetRifaDTO>();
            CreateMap<RifaCreacionDTO, Rifa>();
            CreateMap<Rifa, RifaDTOconCliente>()
                .ForMember(rifaDTO => rifaDTO.Cliente, opciones => opciones.MapFrom(MapRifaDTOCliente));
            
            
        }

        
        private List<ClienteDTO> MapRifaDTOCliente(Rifa rifa, RifaDTO rifaDTO)
        {
            var result = new List<ClienteDTO>();

            if (rifa.Participantes == null) { return result; }

            foreach (var participantes in rifa.Participantes)
            {
                result.Add(new ClienteDTO()
                {
                    Id = participantes.Cliente.Id,
                    Nombre = participantes.Cliente.Nombre
                });
            }

            return result;
        }

        private List<RifaDTO> MapClienteDTORifa(Cliente cliente, ClienteDTO clienteDTO)
        {
            var result = new List<RifaDTO>();

            if (cliente.Participantes == null) { return result; }

            foreach (var participantes in cliente.Participantes)
            {
                result.Add(new RifaDTO()
                {
                    Id = participantes.Rifa.Id,
                    Nombre = participantes.Rifa.Nombre
                });
            }

            return result;
        }

        private List<Participantes> MapAlumnoClase(RifaCreacionDTO claseCreacionDTO, Rifa clase)
        {
            var resultado = new List<Participantes>();

            
            
            return resultado;
        }
    }
}
