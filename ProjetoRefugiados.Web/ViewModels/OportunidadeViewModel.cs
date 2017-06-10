using ProjetoRefugiados.Web.Domain.Models;
using ProjetoRefugiados.Web.ViewModels.Validadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.ViewModels
{
    public class OportunidadeViewModel
    {
        [Key]
        public int OportunidadeId { get; set; }

        [Required(ErrorMessage = "Titulo é obrigatorio")]
        [MinLength(10,ErrorMessage = "O titulo é muito curto")]
        [MaxLength(255, ErrorMessage = "Tamanho maximo atingido")]
        [DisplayName("Título")]
        [SomenteLetras]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatorio")]
        [MinLength(10, ErrorMessage = "O descrição é muito curto")]
        [MaxLength(255, ErrorMessage = "Tamanho maximo atingido")]
        [DisplayName("Descrição")]
        [SomenteLetras]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "A quantiade de vagas é obrigatoria")]
        [DisplayName("Quantidade de Vagas")]
        [Range(1,100,ErrorMessage = "Quantidade invalida")]
        public int Quantidade { get; set; }
        public bool Ativo { get; set; }

        [ScaffoldColumn(false)]
        public virtual ICollection<CartaDeEncaminhamento> Associados { get; set; }
        [ScaffoldColumn(false)]
        public int ProjetoId { get; set; }
        [ScaffoldColumn(false)]
        public virtual Projeto projeto { get; set; }
    }
}