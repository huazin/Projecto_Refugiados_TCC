using ProjetoRefugiados.Domain;
using ProjetoRefugiados.Infra.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace ProjetoRefugiados.Infra.Context
{
    public class ProjetoContext : DbContext
    {
        public ProjetoContext() : base("ProjetoRefugiados")
        {

        }
        //Adicionar Entity para DbSet
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Profissao> Profissoes { get; set; }
        public DbSet<Religiao> Religioes { get; set; }
        public DbSet<Nascionalidade> Nascionalidades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Remover conversões desnecessarias
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Propriedades basicas.
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

                
            //Adicionar Configuração no Entity
            modelBuilder.Configurations.Add(new PessoaConfiguration());
            modelBuilder.Configurations.Add(new PacienteConfiguration());
            modelBuilder.Configurations.Add(new PaisConfiguration());
            modelBuilder.Configurations.Add(new ProfissaoConfiguration());
            modelBuilder.Configurations.Add(new ReligiaoConfiguration());
            modelBuilder.Configurations.Add(new NascionalidadeConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()//Salvar Mudanças
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataDeCadastro") != null))
            {
                if(entry.State == EntityState.Added)
                {
                    entry.Property("DataDeCadastro").CurrentValue = DateTime.Now;
                }
                if(entry.State == EntityState.Modified)
                {
                    entry.Property("DataDeCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();  
        }
    }
}
