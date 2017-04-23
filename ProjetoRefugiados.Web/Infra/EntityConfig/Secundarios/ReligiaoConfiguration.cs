using ProjetoRefugiados.Web.Domain.Models;
using ProjetoRefugiados.Web.Domain.Models.Secudarias;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.EntityConfig.Secundarios
{
    public class ReligiaoConfiguration : EntityTypeConfiguration<Religiao>
    {
        public ReligiaoConfiguration()
        {
            HasKey(p => p.ReligiaoId);

            Property(p => p.Nome)
                .IsRequired();
        }
    }
}