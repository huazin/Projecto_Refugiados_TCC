using ProjetoRefugiados.Web.Domain.Models;
using ProjetoRefugiados.Web.Domain.Models.Secudarias;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.ViewModels
{
    public class ReligiaoViewModel
    {
        [Key]
        public int ReligiaoId { get; set; }

        [Required]
        public string Nome { get; set; }

        [ScaffoldColumn(false)]
        public virtual IEnumerable<Refugiado> Refugiados { get; set; }
    }
}