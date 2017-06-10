using ProjetoRefugiados.Web.Domain.Models;
using ProjetoRefugiados.Web.Domain.Models.Secudarias;
using ProjetoRefugiados.Web.ViewModels.Validadores;
using System;
using System.Collections.Generic;
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
        [SomenteLetras]
        public string Nome { get; set; }

        [Required(ErrorMessage = "CPF é obrigatorio")]
        [ValidadorCPFAttribute]
        public string CPF { get; set; }

        [Required(ErrorMessage = "RG é obrigatorio")]
        [MinLength(6, ErrorMessage = "Esse RG não é valido")]
        [MaxLength(10, ErrorMessage = "Esse RG não é valido")]
        public string RG { get; set; }

        [Required]
        public string Sexo { get; set; }

        [DisplayName("Data de chegada no brasil?")]
        [Range(typeof(DateTime), "1900-12-01", "2020-12-31",
        ErrorMessage = "Data invalida")]
        [DataAttribute]
        public DateTime DataDeChegada { get; set; }

        [Required(ErrorMessage = "Religião é obrigatorio")]
        [DisplayName("Religião")]
        public int ReligiaoId { get; set; }

        [Required(ErrorMessage = "Nacionalidade é obrigatorio")]
        [DisplayName("Nacionalidade")]
        public int NacionalidadeId { get; set; }

        [Required(ErrorMessage = "Profissão é obrigatorio")]
        [DisplayName("Profissão")]
        public int ProfissaoId { get; set; }

        [Required(ErrorMessage = "Origem é obrigatorio")]
        [DisplayName("Pais de Origem")]
        public int PaisId { get; set; }

        [DisplayName("Possui carteira de Vacinação?")]
        public bool Vacinacao { get; set; }

        [Required(ErrorMessage = "Quantidade de membros na familia é obrigatorio")]
        [Range(0, 20, ErrorMessage = "Numeração invalida")]
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
       [DataAniversario]
        public DateTime DataDeNascimento { get; set; }

        [ScaffoldColumn(false)]
        public virtual Religiao Religiao { get; set; }

        [ScaffoldColumn(false)]
        public virtual Nacionalidade Nacionalidade { get; set; }

        [ScaffoldColumn(false)]
        public virtual Profissao Profissao { get; set; }

        [ScaffoldColumn(false)]
        public virtual Pais Pais { get; set; }

        [ScaffoldColumn(false)]
        public virtual Endereco Endereco { get; set; }
        [ScaffoldColumn(false)]
        public virtual ICollection<Triagem> Triagens { get; set; }
        [ScaffoldColumn(false)]
        public virtual ICollection<CartaDeEncaminhamento> Oportunidades { get; set; }
        [ScaffoldColumn(false)]
        public virtual ICollection<Exame> Exames { get; set; }
    }
}