using ProjetoRefugiados.Web.Domain.Models.Secudarias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Domain.Models
{
    public class Projeto
    {
        public int ProjetoId { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public bool Ativo { get; set; }
        public string Tipo { get; set; }
        public virtual EnderecoProjeto Endereco { get; set; }
        public ICollection<Oportunidade> Oportunidades { get; set; }
        public DateTime DataDeModificacao { get; set; }
    }
}