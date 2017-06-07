using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Domain.Models.Secudarias
{
    public class Cid
    {
        public string CidId { get; set; }
        public string Descricao { get; set; }

        public ICollection<Triagem> AlergiasTri { get; set; }
        public ICollection<Triagem> DoencasInfectoTri { get; set; }
        public ICollection<Triagem> AntecedentesTri { get; set; }
        public ICollection<Acolhedor> Deficiencia { get; set; }
        public ICollection<FamiliarAcolhedor> DeficienciaFamiliar { get; set; }

    }
}