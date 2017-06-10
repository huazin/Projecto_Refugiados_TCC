using ProjetoRefugiados.Web.ViewModels.Validadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.ViewModels
{
    public class ProjetoViewModel
    {
        [Key]
        public int ProjetoId { get; set; }

        [DisplayName("Razão Social")]
        [MaxLength(255, ErrorMessage = "Numero de caracteres excede o limite")]
        [Required(ErrorMessage = "Razão Social é obrigatorio")]
        [MinLength(3, ErrorMessage = "Nome muito curto")]
        [SomenteLetras]
        public string Nome { get; set; }

        [Required(ErrorMessage = "CNPJ é obrigatorio")]
        [MaxLength(18, ErrorMessage = "CNPJ Invalido")]
        [MinLength(18, ErrorMessage = "CNPJ Invalido")]
        public string CNPJ { get; set; }
        
        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }

        public string Tipo { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataDeModificacao { get; set; }
        [ScaffoldColumn(false)]
        public virtual EnderecoProjetoViewModel Endereco { get; set; }
    }
}