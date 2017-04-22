using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.ViewModels
{
    public class PessoaViewModel
    {
        [Key]
        public int PessoaId { get; set; }

        [Required(ErrorMessage = "Nome é requerido")]
        [MaxLength(150, ErrorMessage = "O tamanho maximo é 150 Caracteres")] 
        [DisplayName("Nome:")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "CPF é requerido")]
        [DataType(DataType.Currency)]
        [Range(typeof(int), "0", "99999999999", ErrorMessage = "CPF Invalido")]
        [DisplayName("CPF:")]
        public int Cpf { get; set; }

        [Required(ErrorMessage = "RG é requerido")]
        [DataType(DataType.Currency)]
        [Range(typeof(int),"0", "9999999999", ErrorMessage = "RG Invalido")]
        [DisplayName("RG:")]
        public int Rg { get; set; }

        [Required(ErrorMessage = "Sexo é requerido")]
        [DisplayName("Sexo:")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Idade é requerida")]
        [Range(0, 110, ErrorMessage = "Idade invalida")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Data de Nascimento é obrigatoria")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayName("Data de Nascimento")]
        public DateTime DataDeNascimento { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataDeCadastro { get; set; }

        [DefaultValue(true)]
        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }
    }
}