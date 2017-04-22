using ProjetoRefugiados.Domain;
using System.Data.Entity.ModelConfiguration;
namespace ProjetoRefugiados.Infra.EntityConfig
{
    public class PessoaConfiguration : EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfiguration()
        {
            HasKey(p => p.PessoaId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Idade)
                .IsRequired();

            Property(p => p.Rg)
                .IsRequired();

            Property(p => p.Sexo)
                .IsRequired()
                .HasMaxLength(1);

            Property(p => p.DataDeNascimento)
                .IsRequired();
        }
    }
}
