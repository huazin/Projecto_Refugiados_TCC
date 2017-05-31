using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.ViewModels
{
    public class EnderecoProjetoViewModel
    {
        [Key, ForeignKey("Projeto")]
        public int ProjetoId { get; set; }

        [Required(ErrorMessage = "Longadouro é obrigatorio!")]
        public string Longadouro { get; set; }

        [Required(ErrorMessage = "Longadouro é obrigatorio!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Longadouro é obrigatorio!")]
        public string Estado { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "Longadouro é obrigatorio!")]
        public int CEP { get; set; }

        [ScaffoldColumn(false)]
        public virtual ProjetoViewModel Projeto { get; set; }
    }
}