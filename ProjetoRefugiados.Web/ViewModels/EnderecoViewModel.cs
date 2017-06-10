using ProjetoRefugiados.Web.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.ViewModels
{
    public class EnderecoViewModel
    {
        [Key, ForeignKey("Refugiado")]
        public int RefugiadoId { get; set; }

        [Required(ErrorMessage = "Logradouro é obrigatorio!")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Longadouro é obrigatorio!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Longadouro é obrigatorio!")]
        public string Estado { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "Longadouro é obrigatorio!")]
        public int CEP { get; set; }

        [ScaffoldColumn(false)]
        public virtual RefugiadoViewModel Refugiado { get; set; }
    }
}