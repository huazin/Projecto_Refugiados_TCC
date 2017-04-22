using ProjetoRefugiados.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRefugiados.Infra.EntityConfig
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
