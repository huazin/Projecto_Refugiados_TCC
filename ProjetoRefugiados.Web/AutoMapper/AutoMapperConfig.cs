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
                x.CreateMap<RefugiadoViewModel, Refugiado>().MaxDepth(2);
                x.CreateMap<TriagemViewModel, Triagem>().MaxDepth(2);

                x.CreateMap<Refugiado, RefugiadoViewModel>().MaxDepth(2);
                x.CreateMap<Triagem, TriagemViewModel>().MaxDepth(2);

                x.CreateMap<Projeto, ProjetoViewModel>().MaxDepth(2);
                x.CreateMap<ProjetoViewModel, Projeto>().MaxDepth(2);

                x.CreateMap<Oportunidade, OportunidadeViewModel>().MaxDepth(2);
                x.CreateMap<OportunidadeViewModel, Oportunidade>().MaxDepth(2);

                x.CreateMap<CartaDeEncaminhamento, CartaDeEncaminhamentoViewModel>().MaxDepth(2);
                x.CreateMap<CartaDeEncaminhamentoViewModel, CartaDeEncaminhamento>().MaxDepth(2);

                //Secunrarias
                x.CreateMap<ReligiaoViewModel, Religiao>().MaxDepth(2);
                x.CreateMap<PaisViewModel, Pais>().MaxDepth(2);
                x.CreateMap<ProfissaoViewModel, Profissao>().MaxDepth(2);
                x.CreateMap<NascionalidadeViewModel, Nascionalidade>().MaxDepth(2);
                x.CreateMap<EnderecoViewModel, Endereco>().MaxDepth(2);
                x.CreateMap<CidViewModel, Cid>().MaxDepth(2);
                x.CreateMap<EnderecoProjetoViewModel, EnderecoProjeto>().MaxDepth(2);

                x.CreateMap<Profissao, ProfissaoViewModel>().MaxDepth(2);
                x.CreateMap<Endereco, EnderecoViewModel>().MaxDepth(2);
                x.CreateMap<Religiao, ReligiaoViewModel>().MaxDepth(2);
                x.CreateMap<Pais, PaisViewModel>().MaxDepth(2);
                x.CreateMap<Nascionalidade, NascionalidadeViewModel>().MaxDepth(2);
                x.CreateMap<Cid, CidViewModel>().MaxDepth(2);
                x.CreateMap<EnderecoProjeto, EnderecoProjetoViewModel>().MaxDepth(2);
            });
        }
    }
}