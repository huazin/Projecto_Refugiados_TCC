using AutoMapper;
using ProjetoRefugiados.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        // Não realizar este override na versão 4.x e superiores
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected void Configure()
        {
            CreateMap<PacienteViewModel, Paciente>()
                .ForMember(dest => dest.Profissao.ProfissaoId, opt => opt.MapFrom(src => src.ProfissaoId))
                .ForMember(dest => dest.Pais.PaisId, opt => opt.MapFrom(src => src.PaisId))
                .ForMember(dest => dest.Nascionalidade.NascionalidadeoId, opt => opt.MapFrom(src => src.NascionalidadeId))
                .ForMember(dest => dest.Religiao.ReligiaoId, opt => opt.MapFrom(src => src.ReligiaoId));
            CreateMap<PessoaViewModel, Pessoa>();
        }
    }
}