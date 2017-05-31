using ProjetoRefugiados.Web.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.EntityConfig
{
    public class ProjetoConfiguration : EntityTypeConfiguration<Projeto>
    {
        public ProjetoConfiguration()
        {
            HasKey(p => p.ProjetoId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(255);

            Property(p => p.CNPJ)
                .IsRequired()
                .HasMaxLength(18);

            Property(p => p.Tipo)
                .IsRequired();

            HasRequired(p => p.Endereco)
               .WithRequiredPrincipal(p2 => p2.Projeto);
        }
    }
}