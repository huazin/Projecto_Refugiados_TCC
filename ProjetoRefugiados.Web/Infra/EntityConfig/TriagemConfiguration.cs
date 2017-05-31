using ProjetoRefugiados.Web.Domain.Models;
using ProjetoRefugiados.Web.Domain.Models.Secudarias;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.EntityConfig
{
    public class TriagemConfiguration : EntityTypeConfiguration<Triagem>
    {
        public TriagemConfiguration()
        {
            HasKey(p => p.TriagemId);

            Property(p => p.QueixaAtual)
                .IsOptional()
                .HasMaxLength(255);

            Property(p => p.Tratamentos)
                .IsOptional()
                .HasMaxLength(255);

            Property(p => p.AlergiasId)
                .IsOptional();

            HasMany<Cid>(p => p.Alergias)
                .WithMany(c => c.AlergiasTri)
                .Map(m =>
                {
                    m.ToTable("Triagem_Alergias");
                    m.MapLeftKey("TriagemId");
                    m.MapRightKey("CidId");
                }
                );

            Property(p => p.DoencasInfectId)
                .IsOptional();

            HasMany<Cid>(p => p.DoencasInfecto)
                .WithMany(c => c.DoencasInfectoTri)
                .Map(m =>
                {
                    m.ToTable("DoencasTriagem");
                    m.MapLeftKey("TriagemId");
                    m.MapRightKey("CidId");
                }
                );

            Property(p => p.UsoDrogas)
                .IsRequired();

            Property(p => p.UsoDrogaTempo)
                .IsOptional();

            Property(p => p.MedicacaoContinua)
                .IsOptional()
                .HasMaxLength(150);

            Property(p => p.MedicacaoTempo)
                .IsOptional();

            Property(p => p.AntecedentesId)
                .IsOptional();

            HasMany<Cid>(p => p.Antecedentes)
                .WithMany(c => c.AntecedentesTri)
                .Map(m =>
                {
                    m.ToTable("AntecedentesTriagem");
                    m.MapLeftKey("TriagemId");
                    m.MapRightKey("CidId");
                });

            Property(p => p.HabitosHigienicos)
                .IsRequired();

            Property(p => p.Alimentacao)
                .IsOptional()
                .HasMaxLength(150);

            Property(p => p.IngestaoHidrica)
                .IsOptional()
                .HasMaxLength(150);

            Property(p => p.SonoRepouso)
                .IsOptional()
                .HasMaxLength(150);

            Property(p => p.FrequenciaUrianaria)
                .IsOptional()
                .HasMaxLength(150);

            Property(p => p.FrequenciaIntestinal)
                .IsOptional()
                .HasMaxLength(150);

            Property(p => p.Menarca)
                .IsOptional();

            Property(p => p.DUM)
                .IsOptional();

            Property(p => p.NParceiros)
                .IsOptional();

            Property(p => p.GestacoesG)
                .IsOptional();

            Property(p => p.GestacoesP)
                .IsOptional();

            Property(p => p.GestacoesA)
                .IsOptional();

            Property(p => p.UltimoPapanicolau)
                .IsOptional();

            Property(p => p.Resultado)
                .IsOptional();

            Property(p => p.ExameDeMama)
                .IsOptional();

            Property(p => p.SinaisPA)
                .IsRequired();

            Property(p => p.SinaisP)
                .IsRequired();

            Property(p => p.SinaisTEMP)
                .IsRequired();

            Property(p => p.SinaisRESP)
                .IsRequired();

            Property(p => p.SinaisDOR)
                .IsRequired();

            Property(p => p.ProblemasEncontrados)
                .HasMaxLength(255)
                .IsOptional();

            Property(p => p.ExameFisico)
                .HasMaxLength(255)
                .IsOptional();

            Property(p => p.Diagnostico)
                .HasMaxLength(255)
                .IsOptional();

            Property(p => p.Prescricros)
                .HasMaxLength(255)
                .IsOptional();

            Property(p => p.Resultado)
                .IsOptional();

            Property(p => p.Obs)
                .IsOptional();

            Property(p => p.Ativo)
                .IsRequired();

            Property(p => p.DataDeModificacao)
                .IsOptional();

            Property(p => p.AtividadeFisica)
                .IsOptional();

            Property(p => p.Lazer)
                .IsOptional();

            Property(p => p.Telarca)
                .IsOptional();

            HasRequired<Refugiado>(p => p.refugiado)
                .WithMany(p => p.Triagens)
                .HasForeignKey(p => p.RefugiadoId)
                .WillCascadeOnDelete();
        }
    }
}