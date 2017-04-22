using ProjetoRefugiados.Domain;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoRefugiados.Infra.EntityConfig
{
    public class PacienteConfiguration : EntityTypeConfiguration<Paciente>
    {
        public PacienteConfiguration()
        {
            HasKey(p => p.PacienteId);

            Property(p => p.CarteiraVascinacao)
                .IsRequired();

            Property(p => p.DataChegada)
                .IsRequired();

            Property(p => p.MembrosFamilia)
                .IsRequired();

            HasRequired(p => p.Profissao)
                .WithRequiredDependent()
                .Map(p => p.MapKey("ProfissaoId"));

            HasRequired(p => p.Pessoa)
                .WithRequiredDependent()
                .Map(p => p.MapKey("PessoaId"));

            HasRequired(p => p.Pais)
                .WithRequiredDependent()
                .Map(p => p.MapKey("PaisId"));

            HasRequired(p => p.Religiao)
                .WithRequiredDependent()
                .Map(p => p.MapKey("ReligiaoId"));

            HasRequired(p => p.Nascionalidade)
                .WithRequiredDependent()
                .Map(p => p.MapKey("NascionalidadeId"));
        }
    }
}
