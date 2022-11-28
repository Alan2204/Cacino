using AutoMapper;
using Cacino.DTOs;
using Cacino.Entidades;

namespace Cacino.Utilidades
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ClienteDTO, Cliente>();
            CreateMap<Cliente, GetClienteDTO>();
            CreateMap<ClienteCreacionDTO, Cliente>();
            CreateMap<Cliente, ClienteDTOconRifa>();


            CreateMap<RifaDTO, Rifa>();
            CreateMap<Rifa, GetRifaDTO>();
            CreateMap<RifaCreacionDTO, Rifa>();
            CreateMap<Rifa, RifaDTOconCliente>();
            CreateMap<Rifa, RifaDTOconNumero>();
        }

        

    }
}
