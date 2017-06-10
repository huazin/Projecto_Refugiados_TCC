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
    public class TriagemViewModel
    {
        [Key]
        public int TriagemId { get; set; }

        [ScaffoldColumn(false)]
        public int RefugiadoId { get; set; }

        [DisplayName("Queixas atuais:")]
        [MaxLength(255,ErrorMessage = "Tamanho Maximo atingido")]
        [SomenteLetras]
        public string QueixaAtual { get; set; }

        [DisplayName("Tratamentos anteriores:")]
        [MaxLength(255, ErrorMessage = "Tamanho Maximo atingido")]
        [SomenteLetras]
        public string Tratamentos { get; set; }

        [DisplayName("Alergias:")]
        public string AlergiasId { get; set; }
        public virtual CidViewModel Alergias { get; set; }

        [DisplayName("Doenlas Infec.:")]
        public string DoencasInfectId { get; set; }
        public virtual CidViewModel DoencasInfecto { get; set; }

        [Required]
        [DisplayName("Uso de drogas líctas ou ilícitas?")]
        public bool UsoDrogas { get; set; }

        [DisplayName("Há quanto tempo?")]
        [Range(0, int.MaxValue,ErrorMessage = "Numeração invalida")]
        public int UsoDrogaTempo { get; set; }

        [DisplayName("Uso de medicação continua?")]
        [MaxLength(150, ErrorMessage = "Tamanho Maximo atingido")]
        public string MedicacaoContinua { get; set; }

        [DisplayName("Há quanto tempo?")]
        [Range(0, int.MaxValue, ErrorMessage = "Numeração invalida")]
        public int MedicacaoTempo { get; set; }

        [DisplayName("Antecedentes:")]
        public string AntecedentesId { get; set; }
        public virtual CidViewModel Antecedentes { get; set; }

        [Required]
        [DisplayName("Hábitos higiênicos satisfatórios?")]

        public bool HabitosHigienicos { get; set; }

        [DisplayName("Alimentação:")]
        [MaxLength(150, ErrorMessage = "Tamanho Maximo atingido")]
        [SomenteLetras]
        public string Alimentacao { get; set; }

        [DisplayName("Ingestão hídrica:")]
        [MaxLength(150, ErrorMessage = "Tamanho Maximo atingido")]
        [SomenteLetras]
        public string IngestaoHidrica { get; set; }

        [DisplayName("Sono e repouso:")]
        [MaxLength(150, ErrorMessage = "Tamanho Maximo atingido")]
        [SomenteLetras]
        public string SonoRepouso { get; set; }

        [DisplayName("Prática atividades físicas? se sim qual?")]
        [MaxLength(150, ErrorMessage = "Tamanho Maximo atingido")]
        [SomenteLetras]
        public string AtividadeFisica { get; set; }

        [DisplayName("Práticas de lazer e/ou recriação?")]
        [MaxLength(150, ErrorMessage = "Tamanho Maximo atingido")]
        [SomenteLetras]
        public string Lazer { get; set; }

        [DisplayName("Frequência urinaria:")]
        [MaxLength(150, ErrorMessage = "Tamanho Maximo atingido")]
        [SomenteLetras]
        public string FrequenciaUrianaria { get; set; }

        [DisplayName("Frequência instestinal:")]
        [MaxLength(150, ErrorMessage = "Tamanho Maximo atingido")]
        [SomenteLetras]
        public string FrequenciaIntestinal { get; set; }

        [DisplayName("Data da menarca:")]
        [Range(typeof(DateTime), "1900-12-01", "2020-12-31",
        ErrorMessage = "Data invalida")]
        [DataAttribute]
        public DateTime Menarca { get; set; }

        [DisplayName("Data DUM:")]
        [Range(typeof(DateTime), "1900-12-01", "2020-12-31",
        ErrorMessage = "Data invalida")]
        [DataAttribute]
        public DateTime DUM { get; set; }

        [DisplayName("Nº de parceiros:")]
        [Range(0, int.MaxValue,ErrorMessage = "Quantidade invalida")]
        public int NParceiros { get; set; }

        [DisplayName("Data da Telarca:")]
        [Range(typeof(DateTime), "1900-12-01", "2020-12-31",
        ErrorMessage = "Data invalida")]
        [DataAttribute]
        public DateTime Telarca { get; set; }

        [DisplayName("Gestações G:")]
        [Range(0, int.MaxValue, ErrorMessage = "Quantidade invalida")]
        public int GestacoesG { get; set; }

        [DisplayName("Gestações P:")]
        [Range(0, int.MaxValue, ErrorMessage = "Quantidade invalida")]
        public int GestacoesP { get; set; }

        [DisplayName("Gestações A:")]
        [Range(0, int.MaxValue, ErrorMessage = "Quantidade invalida")]
        public int GestacoesA { get; set; }

        [DisplayName("Data do ultimo Papanicolau")]
        [Range(typeof(DateTime), "1900-12-01", "2020-12-31",
        ErrorMessage = "Data invalida")]
        [DataAttribute]
        public DateTime UltimoPapanicolau { get; set; }

        [DisplayName("Resultado:")]
        [MaxLength(150,ErrorMessage ="Tamanho maximo atingido")]
        [SomenteLetras]
        public string Resultado { get; set; }

        [DisplayName("Exame de mama:")]
        [MaxLength(150, ErrorMessage = "Tamanho maximo atingido")]
        [Data]
        public string ExameDeMama { get; set; }

        [Required]
        [DisplayName("Pressão Arterial:")]
        [Range(0, 250, ErrorMessage = "Sinais vitais invalidos")]
        public double SinaisPA { get; set; }

        [Required]
        [DisplayName("Pressão")]
        [Range(0, 250, ErrorMessage = "Sinais vitais invalidos")]
        public double SinaisP { get; set; }

        [Required]
        [DisplayName("Temperatura")]
        [Range(0, 60, ErrorMessage = "Sinais vitais invalidos")]
        public double SinaisTEMP { get; set; }

        [Required]
        [DisplayName("Respiração")]
        [Range(0, 100, ErrorMessage = "Sinais vitais invalidos")]
        public double SinaisRESP { get; set; }

        [Required]
        [DisplayName("DOR")]
        [Range(0, 100, ErrorMessage = "Sinais vitais invalidos")]
        public double SinaisDOR { get; set; }

        [DisplayName("Problemas encontrados:")]
        [MaxLength(250, ErrorMessage = "Tamanho maximo atingido")]
        [SomenteLetras]
        public string ProblemasEncontrados { get; set; }

        [DisplayName("Exame físico:")]
        [MaxLength(150, ErrorMessage = "Tamanho maximo atingido")]
        [SomenteLetras]
        public string ExameFisico { get; set; }

        [DisplayName("Diagnósticos de Enfermagem:")]
        [MaxLength(150, ErrorMessage = "Tamanho maximo atingido")]
        [SomenteLetras]
        public string Diagnostico { get; set; }

        [DisplayName("Prescrições de Enfermagem:")]
        [MaxLength(150, ErrorMessage = "Tamanho maximo atingido")]
        [SomenteLetras]
        public string Prescricros { get; set; }

        [DisplayName("Resultados Esperados:")]
        [MaxLength(150, ErrorMessage = "Tamanho maximo atingido")]
        [SomenteLetras]
        public string Resultados { get; set; }

        [DisplayName("Observações:")]
        [MaxLength(150, ErrorMessage = "Tamanho maximo atingido")]
        [SomenteLetras]
        public string Obs { get; set; }

        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataDeModificacao { get; set; }

        [ScaffoldColumn(false)]
        public virtual RefugiadoViewModel refugiado { get; set; }
    }
}