using AutoMapper;
using Infraestructure.API.DTO;
using Infraestructure.API.Models;

namespace Infraestructure.API.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<UsuarioCreacionDTO, Usuario>();
            CreateMap<Usuario, UsuarioConsultaDTO>();
        }

    }
}
