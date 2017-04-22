using ProjetoRefugiados.Domain;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoRefugiados.Infra.EntityConfig
{
    public class PaisConfiguration : EntityTypeConfiguration<Pais>
    {
        public PaisConfiguration()
        {
            HasKey(p => p.PaisId);

            Property(p => p.Nome)
                .IsRequired();

        }
    }
}
