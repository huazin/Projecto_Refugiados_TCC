using ProjetoRefugiados.Web.Domain.Models.Secudarias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Domain.Models
{
    public class Triagem
    {
        public int TriagemId { get; set; }
        public string QueixaAtual { get; set; }
        public string Tratamentos { get; set; }
        //public string AlergiasId { get; set; }
        public virtual ICollection<Cid> Alergias { get; set; }
        //public string DoencasInfectId { get; set; }
        public virtual ICollection<Cid> DoencasInfecto { get; set; }
        public bool UsoDrogas { get; set; }
        public int UsoDrogaTempo { get; set; }
        public string MedicacaoContinua { get; set; }
        public int MedicacaoTempo { get; set; }
        public virtual ICollection<Cid> Antecedentes { get; set; }
        public bool HabitosHigienicos { get; set; }
        public string Alimentacao { get; set; }
        public string IngestaoHidrica { get; set; }
        public string SonoRepouso { get; set; }
        public string FrequenciaUrianaria { get; set; }
        public string FrequenciaIntestinal { get; set; }
        public DateTime Menarca { get; set; }
        public DateTime DUM { get; set; }
        public int NParceiros { get; set; }
        public int GestacoesG { get; set; }
        public int GestacoesP { get; set; }
        public int GestacoesA { get; set; }
        public DateTime UltimoPapanicolau { get; set; }
        public string Resultado { get; set; }
        public string ExameDeMama { get; set; }

        public double SinaisPA { get; set; }
        public double SinaisP { get; set; }
        public double SinaisTEMP { get; set; }
        public double SinaisRESP { get; set; }
        public double SinaisDOR { get; set; }
        public string ProblemasEncontrados { get; set; }
        public string ExameFisico { get; set; }
        public string Diagnostico { get; set; }
        public string Prescricros { get; set; }
        public string Resultados { get; set; }
        public string Obs { get; set; }
    }
}