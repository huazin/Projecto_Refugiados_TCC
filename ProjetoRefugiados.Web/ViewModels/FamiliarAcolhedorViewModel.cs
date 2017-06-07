using ProjetoRefugiados.Web.Domain.Models;
using ProjetoRefugiados.Web.Domain.Models.Secudarias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.ViewModels
{
    public class FamiliarAcolhedorViewModel
    {
        [Key]
        public int FamiliarAcolhedorId { get; set; }

        [Key]
        public int AcolhedorId { get; set; }

        [ScaffoldColumn(false)]
        public virtual Acolhedor Acolhedor { get; set; }

        //Sobre o acolhedor
        [DisplayName("Nome Completo:")]
        public string Nome { get; set; }

        [DisplayName("CPF")]
        public string Cpf { get; set; }

        public string Sexo { get; set; }

        [Required(ErrorMessage = "Data de nascimento é obrigatoria")]
        [Range(typeof(DateTime), "1900-12-01", "2020-12-31",
        ErrorMessage = "Data invalida")]
        public DateTime DataNascimento { get; set; }

        [DisplayName("Possui Deficiencia?")]
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

        [ScaffoldColumn(false)]
        public DateTime DataDeModificacao { get; set; }
    }
}