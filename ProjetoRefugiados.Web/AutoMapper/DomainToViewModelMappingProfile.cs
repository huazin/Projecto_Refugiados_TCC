using AutoMapper;
using ProjetoRefugiados.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected void Configure()
        {
            CreateMap<Paciente, PacienteViewModel>()
                .ForMember(dest => dest.ProfissaoId, opt => opt.MapFrom(src => src.Profissao.ProfissaoId))
                .ForMember(dest => dest.PaisId, opt => opt.MapFrom(src => src.Pais.PaisId))
                .ForMember(dest => dest.NascionalidadeId, opt => opt.MapFrom(src => src.Nascionalidade.NascionalidadeoId))
                .ForMember(dest => dest.ReligiaoId, opt => opt.MapFrom(src => src.Religiao.ReligiaoId));
        }
    }
}