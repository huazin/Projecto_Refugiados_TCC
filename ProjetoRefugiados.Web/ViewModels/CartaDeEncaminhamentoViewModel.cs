using ProjetoRefugiados.Web.Domain.Models;
using ProjetoRefugiados.Web.ViewModels.Validadores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.ViewModels
{
    public class CartaDeEncaminhamentoViewModel
    {
        [Key]
        public int CartaDeEncaminhamentoId { get; set; }

        [ValidadorCPFCarta]
        [Required]
        public string CPF { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public int RefugiadoId { get; set; }
        public virtual Refugiado refugiado { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public int OportunidadeId { get; set; }
        public virtual Oportunidade oportunidade { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataDeModificacao { get; set; }

        [ScaffoldColumn(false)]
        public bool ativo { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public int resultado { get; set; }//0 = encaminhado, 1 = aprovado, 2 = reprovado.
    }
}