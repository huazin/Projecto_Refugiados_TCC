using ProjetoRefugiados.Web.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.ViewModels
{
    public class NascionalidadeViewModel
    {
        [Key]
        public int NascionalidadeId { get; set; }
        public string Nome { get; set; }
        public virtual IEnumerable<Refugiado> Refugiados { get; set; }
    }
}