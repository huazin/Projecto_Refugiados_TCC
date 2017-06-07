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
        public string ProgramaSocialString { get; set; }

        //Sobre o acolhedor
        [DisplayName("Nome Completo:")]
        public string Nome { get; set; }

        [DisplayName("CPF")]
        [ValidadorCPFAcolhedor]
        public string Cpf { get; set; }

        public string Sexo { get; set; }

        [Required(ErrorMessage = "Data de nascimento é obrigatoria")]
        [Range(typeof(DateTime), "1900-12-01", "2020-12-31",
        ErrorMessage = "Data invalida")]
        public DateTime DataNascimento { get; set; }

        [DisplayName("Posui alguma deficiencia?")]
        public bool Deficiencia { get; set; }
        [DisplayName("Qual?")]
        public string DeficienciaId { get; set; }

        [ScaffoldColumn(false)]
        public virtual Cid DeficienciaCid { get; set; }
        [DisplayName("Uso de Remedio controlado? Qual?")]
        public string RemedioControlado { get; set; }

        //Escolaridade
        [DisplayName("Sabe Ler?")]
        public bool SabeLer { get; set; }

        [DisplayName("Frequenta escola atualmente?")]
        public bool FrequentaEscola { get; set; }

        [DisplayName("Ultima serie concluida")]
        public string UltimaSerie { get; set; }

        //Trabalhos

        [DisplayName("Possui CPTS?")]
        public bool CPTS { get; set; }

        [DisplayName("Possui Qualificação? qual?")]
        public string Qualificacao { get; set; }

        //Sobre a casa

        [DisplayName("Tipo de Residencia?")]
        public string TipoResidencia { get; set; }

        [DisplayName("Tipo de Construção?")]
        public string TipoConstrucao { get; set; }

        [DisplayName("Acesso a Energia via?")]
        public string AcessoEnergia { get; set; }

        [DisplayName("Possui Agua canalizada?")]
        public bool AguaCanalizada { get; set; }

        [DisplayName("Forma de abastecimento dágua:")]
        public string FormaAbastecimentoAgua { get; set; }

        [DisplayName("Escoamento sanitario:")]
        public string EscoamentoSanitario { get; set; }

        [DisplayName("Numero de comodos na casa:")]
        public int NumerosDeComodos { get; set; }

        [DisplayName("O local possui acebilidade para portadores de deficiencia fisica?")]
        public bool Acebilidade { get; set; }

        [DisplayName("o local esta em area de risco de desabamento ou alagamento?")]
        public bool AreaDesabamentoOuAlagamento { get; set; }

        //Observação do acolhedor
        [DisplayName("Observação do acolhedor:")]
        public string Obervacao { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataDeModificacao { get; set; }
        [ScaffoldColumn(false)]
        public virtual ICollection<FamiliarAcolhedor> Familiares { get; set; }
    }
}
