using ProjetoRefugiados.Web.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.ViewModels
{
    public class ProfissaoViewModel
    {
        [Key]
        public int ProfissaoId { get; set; }
        [Required]
        public string Nome { get; set; }

        public virtual IEnumerable<RefugiadoViewModel> Refugiados { get; set; }
    }
}