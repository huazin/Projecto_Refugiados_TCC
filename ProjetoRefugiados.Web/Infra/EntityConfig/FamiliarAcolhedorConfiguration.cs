using ProjetoRefugiados.Web.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.EntityConfig
{
    public class FamiliarAcolhedorConfiguration : EntityTypeConfiguration<FamiliarAcolhedor>
    {
        public FamiliarAcolhedorConfiguration()
        {
            HasKey(p => p.FamiliarAcolhedorId);

            HasRequired(p => p.DeficienciaCid)
               .WithMany()
               .HasForeignKey(p => p.DeficienciaId);

            HasRequired<Acolhedor>(p => p.Acolhedor)
                .WithMany(p => p.Familiares)
                .HasForeignKey(p => p.AcolhedorId)
                .WillCascadeOnDelete();
        }
    }
}