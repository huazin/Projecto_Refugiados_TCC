using ProjetoRefugiados.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRefugiados.Infra.EntityConfig
{
    class NascionalidadeConfiguration : EntityTypeConfiguration<Nascionalidade>
    {
        public NascionalidadeConfiguration()
        {
            HasKey(p => p.NascionalidadeoId);

            Property(p => p.Nome)
                .IsRequired();
        }
    }
}
