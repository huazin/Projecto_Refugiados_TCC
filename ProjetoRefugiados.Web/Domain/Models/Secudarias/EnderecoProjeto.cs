using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Domain.Models.Secudarias
{
    public class EnderecoProjeto
    {
        public int ProjetoId { get; set; }
        public string Longadouro { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int CEP { get; set; }
        public virtual Projeto Projeto { get; set; }
    }
}