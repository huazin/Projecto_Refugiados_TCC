using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.ViewModels
{
    public class PacienteViewModel
    {
        [Key]
        public int PacienteId { get; set; }

        [Required(ErrorMessage = "Data de Chegada é obrigatoria")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayName("Data de Chegada no Brasil:")]
        public DateTime DataChegadda { get; set; }

        [Required]
        [DisplayName("Possui Carteira de Vascinação:")]
        public bool CarteiraVascinacao { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Range(typeof(int),"0","99", ErrorMessage = "Numero invalido")]
        public int MembrosFamilia { get; set; }

        [Required]
        [DisplayName("Religião:")]
        public int ReligiaoId { get; set; }

        [Required]
        [DisplayName("Profissão:")]
        public int ProfissaoId { get; set; }

        [Required]
        [DisplayName("Nascionalidade:")]
        public int NascionalidadeId { get; set; }

        [Required]
        [DisplayName("Pais de Origem:")]
        public int PaisId { get; set; }

        public virtual Pessoa Pessoa { get; set; }

    }
}