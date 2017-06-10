using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Domain.Models
{
    public class Exame
    {
        public int ExameId { get; set; }
        public string Descricao { get; set; }

        public int refugiadoId { get; set; }
        public virtual Refugiado refugiado { get; set; }
        public DateTime DataDeModificacao { get; set; }
    }
}