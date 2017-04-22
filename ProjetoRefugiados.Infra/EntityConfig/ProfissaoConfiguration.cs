using ProjetoRefugiados.Domain;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoRefugiados.Infra.EntityConfig 
{
    public class ProfissaoConfiguration : EntityTypeConfiguration<Profissao>
    {
        public ProfissaoConfiguration()
        {
            HasKey(p => p.ProfissaoId);

            Property(p => p.nome)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
