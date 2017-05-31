using ProjetoRefugiados.Web.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.EntityConfig
{
    public class OportunidadeConfiguration : EntityTypeConfiguration<Oportunidade>
    {
        public OportunidadeConfiguration()
        {
            HasKey(p => p.OportunidadeId);

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(255);

            Property(p => p.Titulo)
                .IsRequired()
                .HasMaxLength(255);

            Property(p => p.Quantidade)
                .IsRequired();

            HasRequired<Projeto>(p => p.projeto)
                .WithMany(p => p.Oportunidades)
                .HasForeignKey(p => p.ProjetoId)
                .WillCascadeOnDelete();

            HasMany<Refugiado>(p => p.Associados)
                .WithMany(c => c.Oportunidades)
                .Map(m =>
                {
                    m.ToTable("Refugiados_Oportunidades");
                    m.MapLeftKey("OportunidadeId");
                    m.MapRightKey("RefugiadoId");
                }
                );
        }
    }
}