using ProjetoRefugiados.Web.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.EntityConfig
{
    public class AcolhedorConfiguration : EntityTypeConfiguration<Acolhedor>
    {
        public AcolhedorConfiguration()
        {
            HasKey(p => p.AcolhedorId);

            HasRequired(p => p.DeficienciaCid)
                .WithMany()
                .HasForeignKey(p => p.DeficienciaId);
        }
    }
}