using ProjetoRefugiados.Web.Domain.Models.Secudarias;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.EntityConfig.Secundarios
{
    public class ProfissaoConfiguration : EntityTypeConfiguration<Profissao>
    {
        public ProfissaoConfiguration()
        {
            HasKey(p => p.ProfissaoId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(200) ;
        }
    }
}