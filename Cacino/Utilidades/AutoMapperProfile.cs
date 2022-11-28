using AutoMapper;
using Cacino.DTOs;
using Cacino.Entidades;

namespace Cacino.Utilidades
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Cliente, ClienteDTO>();
            CreateMap<RifaDTO, Rifa>();
            CreateMap<Rifa, GetRifaDTO>();
            CreateMap<RifaCreacionDTO, Rifa>();
            CreateMap<Rifa, RifaDTOconCliente>();
            CreateMap<Rifa, RifaDTOconNumero>();
        }

    }
}
