using AutoMapper;
using ProjetoRefugiados.Web.Domain.Models;
using ProjetoRefugiados.Web.Domain.Models.Secudarias;
using ProjetoRefugiados.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                //Primeiras
                x.CreateMap<RefugiadoViewModel, Refugiado>();

                x.CreateMap<Refugiado, RefugiadoViewModel>();
                
                //Secunrarias
                x.CreateMap<ReligiaoViewModel, Religiao>();
                x.CreateMap<PaisViewModel, Pais>();
                x.CreateMap<ProfissaoViewModel, Profissao>();
                x.CreateMap<NascionalidadeViewModel, Nascionalidade>();

                x.CreateMap<Profissao, ProfissaoViewModel>();
                x.CreateMap<Religiao, ReligiaoViewModel>();
                x.CreateMap<Pais, PaisViewModel>();
                x.CreateMap<Nascionalidade, NascionalidadeViewModel>();
            });
        }
    }
}