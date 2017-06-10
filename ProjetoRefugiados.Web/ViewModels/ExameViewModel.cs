using ProjetoRefugiados.Web.Domain.Models;
using ProjetoRefugiados.Web.ViewModels.Validadores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.ViewModels
{
    public class ExameViewModel
    {
        [Key]
        public int ExameId { get; set; }
        [Required]
        [SomenteLetras]
        public string Descricao { get; set; }

        [ScaffoldColumn(false)]
        public int refugiadoId { get; set; }

        [ScaffoldColumn(false)]
        public virtual Refugiado refugiado { get; set; }
        public DateTime DataDeModificacao { get; set; }
    }
}