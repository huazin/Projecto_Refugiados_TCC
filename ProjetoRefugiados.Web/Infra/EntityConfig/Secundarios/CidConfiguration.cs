using ProjetoRefugiados.Web.Domain.Models;
using ProjetoRefugiados.Web.Domain.Models.Secudarias;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.EntityConfig.Secundarios
{
    public class CidConfiguration :  EntityTypeConfiguration<Cid>
    {
        public CidConfiguration()
        {
            HasKey(p => p.CidId);

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(255);

            //HasMany<Triagem>(p => p.AlergiasTri)
            //    .WithMany(c => c.Alergias)
            //    .Map(m =>
            //    {
            //        m.ToTable("Triagem_Alergias");
            //        m.MapLeftKey("TriagemId");
            //        m.MapRightKey("CidId");
            //    }
            //    );

            //HasMany<Triagem>(p => p.DoencasInfectoTri)
            //    .WithMany(c => c.DoencasInfecto)
            //    .Map(m =>
            //    {
            //        m.ToTable("DoencasTriagem");
            //        m.MapLeftKey("TriagemId");
            //        m.MapRightKey("CidId");
            //    }
            //    );

            //HasMany<Triagem>(p => p.AntecedentesTri)
            //    .WithMany(c => c.Antecedentes)
            //    .Map(m =>
            //    {
            //        m.ToTable("AntecedentesTriagem");
            //        m.MapLeftKey("TriagemId");
            //        m.MapRightKey("CidId");
            //    });
        }
    }
}