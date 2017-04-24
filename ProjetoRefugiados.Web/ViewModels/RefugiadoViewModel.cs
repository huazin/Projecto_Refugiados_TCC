using ProjetoRefugiados.Web.Domain.Models.Secudarias;
using ProjetoRefugiados.Web.ViewModels.Validadores;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoRefugiados.Web.ViewModels
{
    public class RefugiadoViewModel
    {
        [Key]
        public int RefugiadoId { get; set; }

        [Required(ErrorMessage = "O nome é obrigatorio")]
        [MinLength(5, ErrorMessage = "Nome muito pequeno")]
        [MaxLength(150, ErrorMessage = "Tamanho maximo atingido")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "CPF é obrigatorio")]
        [ValidadorCPF]
        public string CPF { get; set; }

        [Required(ErrorMessage = "RG é obrigatorio")]
        [MinLength(10, ErrorMessage = "Esse RG não é valido")]
        [MaxLength(10, ErrorMessage = "Esse RG não é valido")]
        public string RG { get; set; }

        [Required]
        public string Sexo { get; set; }

        [DisplayName("Data de chegada no brasil?")]
        [Range(typeof(DateTime), "1900-12-01", "2020-12-31",
        ErrorMessage = "Data invalida")]
        public DateTime DataDeChegada { get; set; }

        [Required(ErrorMessage = "Religião é obrigatorio")]
        [DisplayName("Religião")]
        public int ReligiaoId { get; set; }

        [Required(ErrorMessage = "Nascionalidade é obrigatorio")]
        [DisplayName("Nascionalidade")]
        public int NacionalidadeId { get; set; }

        [Required(ErrorMessage = "Profissão é obrigatorio")]
        [DisplayName("Profissão")]
        public int ProfissaoId { get; set; }

        [Required(ErrorMessage = "Origem é obrigatorio")]
        [DisplayName("Pais de Origem")]
        public int PaisId { get; set; }

        [DisplayName("Possui carteira de Vascinação?")]
        public bool Vascinacao { get; set; }

        [Required(ErrorMessage = "Quantidade de membros na familia é obrigatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Numeração invalida")]
        [DisplayName("Quantidade de membros na familia?")]
        public int MembrosNaFamilia { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataDeModificacao { get; set; }

        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }

        [Required(ErrorMessage = "Data de nascimento é obrigatoria")]
        [Range(typeof(DateTime), "1900-12-01", "2020-12-31",
        ErrorMessage = "Data invalida")]
        [DisplayName("Data de Nascimento")]
        public DateTime DataDeNascimento { get; set; }

        [ScaffoldColumn(false)]
        public virtual ReligiaoViewModel Religiao { get; set; }

        [ScaffoldColumn(false)]
        public virtual NascionalidadeViewModel Nascionalidade { get; set; }

        [ScaffoldColumn(false)]
        public virtual ProfissaoViewModel Profissao { get; set; }

        [ScaffoldColumn(false)]
        public virtual PaisViewModel Pais { get; set; }

        [ScaffoldColumn(false)]
        public virtual EnderecoViewModel Endereco { get; set; }
    }
}