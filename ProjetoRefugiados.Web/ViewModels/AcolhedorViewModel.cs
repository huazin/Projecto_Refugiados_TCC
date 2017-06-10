using ProjetoRefugiados.Web.Domain.Models;
using ProjetoRefugiados.Web.Domain.Models.Secudarias;
using ProjetoRefugiados.Web.ViewModels.Validadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.ViewModels
{
    public class AcolhedorViewModel
    {
        [Key]
        public int AcolhedorId { get; set; }

        [DisplayName("Como tomou conhecimento do projeto?")]
        [Range(0, 1, ErrorMessage = "Numeração invalida")]
        [Required]
        public int Conhecimento { get; set; } //0 = de forma espontânea, 1 = Indicação

        [Required]
        [DisplayName("Participa de algum Programa Social?")]
        public bool ProgramaSocial { get; set; }

        [DisplayName("Qual?")]
        [SomenteLetras]
        public string ProgramaSocialString { get; set; }

        //Sobre o acolhedor
        [DisplayName("Nome Completo:")]
        [SomenteLetras]
        [Required]
        public string Nome { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(11)]
        [DisplayName("Telefone para contato:")]
        public string Telefone { get; set; }

        [DisplayName("CPF")]
        [ValidadorCPFAcolhedor]
        public string Cpf { get; set; }

        public string Sexo { get; set; }

        [Required(ErrorMessage = "Data de nascimento é obrigatoria")]
        [DataAniversarioAttribute]
        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [DisplayName("Possui alguma deficiência?")]
        public bool Deficiencia { get; set; }
        [DisplayName("Qual?")]
        [Required]
        public string DeficienciaId { get; set; }

        [ScaffoldColumn(false)]
        public virtual Cid DeficienciaCid { get; set; }
        [DisplayName("Faz uso de medicação controlada, qual?")]
        [SomenteLetras]
        public string RemedioControlado { get; set; }

        //Escolaridade
        [DisplayName("Sabe Ler?")]
        public bool SabeLer { get; set; }

        [DisplayName("Frequenta escola atualmente?")]
        public bool FrequentaEscola { get; set; }

        [DisplayName("Ultima série concluida")]
        public string UltimaSerie { get; set; }

        //Trabalhos

        [DisplayName("Possui CPTS?")]
        public bool CPTS { get; set; }

        [DisplayName("Possui Qualificação? qual?")]
        [SomenteLetras]
        public string Qualificacao { get; set; }

        //Sobre a casa

        [DisplayName("Tipo de Residência?")]
        public string TipoResidencia { get; set; }

        [DisplayName("Tipo de Construção?")]
        public string TipoConstrucao { get; set; }

        [DisplayName("Acesso a Energia via?")]
        public string AcessoEnergia { get; set; }

        [DisplayName("Possui água canalizada?")]
        public bool AguaCanalizada { get; set; }

        [DisplayName("Forma de abastecimento d'água:")]
        public string FormaAbastecimentoAgua { get; set; }

        [DisplayName("Escoamento sanitário:")]
        public string EscoamentoSanitario { get; set; }

        [DisplayName("Numero de cômodos na casa:")]
        [Range(0,int.MaxValue, ErrorMessage = "Numeração invalida")]
        public int NumerosDeComodos { get; set; }

        [DisplayName("O local possui acessibilidade para portadores de deficiência?")]
        public bool Acebilidade { get; set; }

        [DisplayName("o local está em área de risco de desabamento ou alagamento?")]
        public bool AreaDesabamentoOuAlagamento { get; set; }

        //Observação do acolhedor
        [DisplayName("Observações do acolhedor:")]
        [SomenteLetras]
        public string Obervacao { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataDeModificacao { get; set; }
        [ScaffoldColumn(false)]
        public virtual ICollection<FamiliarAcolhedor> Familiares { get; set; }
        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }
    }
}
