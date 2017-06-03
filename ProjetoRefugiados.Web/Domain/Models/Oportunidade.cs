using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Domain.Models
{
    public class Oportunidade
    {
        public int OportunidadeId { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public int Quantidade { get; set; }
        public bool Ativo { get; set; }

        public virtual ICollection<CartaDeEncaminhamento> Associados { get; set; }
        public int ProjetoId { get; set; }
        public virtual Projeto projeto { get; set; }
    }
}