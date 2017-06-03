using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Domain.Models
{
    public class CartaDeEncaminhamento
    {
        public int CartaDeEncaminhamentoId { get; set; }
        public string CPF { get; set; }
        public int RefugiadoId { get; set; }
        public virtual Refugiado refugiado { get; set; }
        public int OportunidadeId { get; set; }
        public virtual Oportunidade oportunidade { get; set; }
        public DateTime DataDeModificacao { get; set; }
        public bool ativo { get; set; }
        public int resultado { get; set; }//0 = encaminhado, 1 = aprovado, 2 = reprovado.
    }
}