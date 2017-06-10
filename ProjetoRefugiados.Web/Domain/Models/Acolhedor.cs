using ProjetoRefugiados.Web.Domain.Models.Secudarias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Domain.Models
{
    public class Acolhedor
    {
        public int AcolhedorId { get; set; }
        public int Conhecimento { get; set; } //0 = de forma espontânea, 1 = Indicação
        public bool ProgramaSocial { get; set; }
        public string ProgramaSocialString { get; set; }
        //Sobre o acolhedor
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Deficiencia { get; set; }
        public string DeficienciaId { get; set; }
        public virtual Cid DeficienciaCid { get; set; }
        public string RemedioControlado { get; set; }
        //Escolaridade
        public bool SabeLer { get; set; }
        public bool FrequentaEscola { get; set; }
        public string UltimaSerie { get; set; }
        //Trabalhos
        public bool CPTS { get; set; }
        public string Qualificacao { get; set; }
        //Sobre a casa
        public string TipoResidencia { get; set; }
        public string TipoConstrucao { get; set; }
        public string AcessoEnergia { get; set; }
        public bool AguaCanalizada { get; set; }
        public string FormaAbastecimentoAgua { get; set; }
        public string EscoamentoSanitario { get; set; }
        public int NumerosDeComodos { get; set; }
        public bool Acebilidade { get; set; }
        public bool AreaDesabamentoOuAlagamento { get; set; }
        //Observação do acolhedor
        public string Obervacao { get; set; }
        public DateTime DataDeModificacao { get; set; }
        public virtual ICollection<FamiliarAcolhedor> Familiares { get; set; }
        public bool Ativo { get; set; }
    }
}