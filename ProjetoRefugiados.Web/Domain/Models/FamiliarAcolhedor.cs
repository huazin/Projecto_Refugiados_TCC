using ProjetoRefugiados.Web.Domain.Models.Secudarias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Domain.Models
{
    public class FamiliarAcolhedor
    {
        public int FamiliarAcolhedorId { get; set; }
        public int AcolhedorId { get; set; }
        public virtual Acolhedor Acolhedor { get; set; }
        //Sobre o acolhedor
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Sexo { get; set; }
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
        public DateTime DataDeModificacao { get; set; }
    }
}