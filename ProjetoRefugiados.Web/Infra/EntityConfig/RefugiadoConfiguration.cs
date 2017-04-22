using ProjetoRefugiados.Web.Domain.Models;
using System.Data.Entity.ModelConfiguration;
namespace ProjetoRefugiados.Web.Infra.EntityConfig
{
    public class RefugiadoConfiguration : EntityTypeConfiguration<Refugiado>
    {
        public RefugiadoConfiguration()
        {
            HasKey(p => p.RefugiadoId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.CPF)
                .IsRequired()
                .HasMaxLength(11);

            Property(p => p.RG)
                .IsRequired()
                .HasMaxLength(10);

            Property(p => p.Sexo)
                .IsRequired();

            Property(p => p.Vascinacao)
                .IsRequired();

            Property(p => p.MembrosNaFamilia)
                .IsRequired();

            HasRequired(p => p.Nascionalidade)
                .WithMany()
                .HasForeignKey(p => p.NacionalidadeId);

            HasRequired(p => p.Pais)
                .WithMany()
                .HasForeignKey(p => p.PaisId);

            HasRequired(p => p.Religiao)
                .WithMany()
                .HasForeignKey(p => p.ReligiaoId);

            HasRequired(p => p.Profissao)
                .WithMany()
                .HasForeignKey(p => p.ProfissaoId);
        }
    }
}