using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRefugiados.Domain
{
    public class Paciente
    {
        public int PacienteId { get; set; }
        public DateTime DataChegada { get; set; }
        public bool CarteiraVascinacao { get; set; }
        public int MembrosFamilia { get; set; }
        //public int ReligiaoId { get; set; }
        //public int NascionalidadeId { get; set; }
        //public int ProfissaoId { get; set; }
        //public int PaisId { get; set; }
        public virtual Religiao Religiao{ get; set; }
        public virtual Nascionalidade Nascionalidade { get; set; }
        public virtual Profissao Profissao { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual Pais Pais { get; set; }
    }
}
