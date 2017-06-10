using ProjetoRefugiados.Web.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.ViewModels
{
    public class NacionalidadeViewModel
    {
        [Key]
        public int NacionalidadeId { get; set; }
        public string Nome { get; set; }
        public virtual IEnumerable<RefugiadoViewModel> Refugiados { get; set; }
    }
}