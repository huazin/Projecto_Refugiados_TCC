using System;
using ProjetoRefugiados.Web.Domain.Models.Secudarias;
using System.Collections.Generic;

namespace ProjetoRefugiados.Web.Domain.Models
{
    public class Refugiado
    {
        public int RefugiadoId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Sexo { get; set; }
        public DateTime DataDeChegada { get; set; }
        public int ReligiaoId { get; set; }
        public int NacionalidadeId { get; set; }
        public int ProfissaoId { get; set; }
        public int PaisId { get; set; }
        public bool Vascinacao { get; set; }
        public int MembrosNaFamilia { get; set; }
        public DateTime DataDeModificacao { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public bool Ativo { get; set; }
        public virtual Religiao Religiao { get; set; }
        public virtual Nascionalidade Nascionalidade { get; set; }
        public virtual Profissao Profissao { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual Endereco Endereco { get; set; }

        public virtual ICollection<Triagem> Triagens { get; set; }
    }
}