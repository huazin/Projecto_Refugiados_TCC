using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Domain.Models.Secudarias
{
    public class Nacionalidade
    {
        public int NacionalidadeId { get; set; }
        public string Nome { get; set; }

        public virtual IEnumerable<Refugiado> Refugiados { get; set; }
    }
}