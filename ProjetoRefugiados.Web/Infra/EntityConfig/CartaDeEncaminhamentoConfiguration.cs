using ProjetoRefugiados.Web.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.EntityConfig
{
    public class CartaDeEncaminhamentoConfiguration : EntityTypeConfiguration<CartaDeEncaminhamento>
    {
        public CartaDeEncaminhamentoConfiguration()
        {
            HasKey(p => p.CartaDeEncaminhamentoId);

            Property(p => p.CPF)
                .IsRequired()
                .HasMaxLength(11);

            Property(p => p.resultado)
                .IsRequired();

            HasRequired<Oportunidade>(p => p.oportunidade)
               .WithMany(p => p.Associados)
               .HasForeignKey(p => p.OportunidadeId)
               .WillCascadeOnDelete();

            HasRequired<Refugiado>(p => p.refugiado)
               .WithMany(p => p.Oportunidades)
               .HasForeignKey(p => p.RefugiadoId)
               .WillCascadeOnDelete();
        }
    }
}