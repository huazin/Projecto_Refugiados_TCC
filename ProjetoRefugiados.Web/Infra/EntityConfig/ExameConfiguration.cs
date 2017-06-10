using ProjetoRefugiados.Web.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.EntityConfig
{
    public class ExameConfiguration : EntityTypeConfiguration<Exame>
    {
        public ExameConfiguration()
        {
            HasKey(p => p.ExameId);

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(500);

            HasRequired<Refugiado>(p => p.refugiado)
                .WithMany(p => p.Exames)
                .HasForeignKey(p => p.refugiadoId)
                .WillCascadeOnDelete();
        }
    }
}