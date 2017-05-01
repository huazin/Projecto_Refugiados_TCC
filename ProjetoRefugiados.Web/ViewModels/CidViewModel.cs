using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.ViewModels
{
    public class CidViewModel
    {
        [Key]
        public string CidId { get; set; }
        public string Descricao { get; set; }

        public ICollection<TriagemViewModel> AlergiasTri { get; set; }
        public ICollection<TriagemViewModel> DoencasInfectoTri { get; set; }
        public ICollection<TriagemViewModel> AntecedentesTri { get; set; }
    }
}