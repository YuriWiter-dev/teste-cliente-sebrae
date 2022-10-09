using AutoMapper;
using ProjectTemplate.Application.DTOs;
using ProjectTemplate.Domain.Entities;

namespace ProjectTemplate.Application.Mappings
{
    public class BaseMapping : Profile
    {
        public BaseMapping()
        {
            //CreateMap<Cliente, ClienteDto>()
            //    .ForMember(dto => dto.NomeCompleto,
            //        map => map.MapFrom(entidade => entidade.Nome));

            CreateMap<Cliente, ClienteDto>().ReverseMap();
        }
    }
}
