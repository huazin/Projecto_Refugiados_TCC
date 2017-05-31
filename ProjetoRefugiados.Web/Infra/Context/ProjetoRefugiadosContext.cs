using ProjetoRefugiados.Web.Domain.Models;
using ProjetoRefugiados.Web.Domain.Models.Secudarias;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ProjetoRefugiados.Web.Infra.EntityConfig.Secundarios;
using ProjetoRefugiados.Web.Infra.EntityConfig;
using System;
using System.Linq;

namespace ProjetoRefugiados.Web.Infra.Context
{
    public class ProjetoRefugiadosContext : DbContext
    {
        public ProjetoRefugiadosContext()
            : base("ProjetoRefugiadosContext")
        {

        }

        //Principais
        public DbSet<Refugiado> Refugiados { get; set; }
        public DbSet<Triagem> Triagens { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Oportunidade> Oportunidades { get; set; }

        //Secundarias
        public DbSet<Nascionalidade> Nacionalidades { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Profissao> Profissoes { get; set; }
        public DbSet<Religiao> Religoes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<EnderecoProjeto> EnderecosProjeto { get; set; }
        public DbSet<Cid> Cids { get; set; }

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

            //Cria configurações proprias para cada Entidade
            //Principais
            modelBuilder.Configurations.Add(new RefugiadoConfiguration());
            modelBuilder.Configurations.Add(new TriagemConfiguration());
            modelBuilder.Configurations.Add(new ProjetoConfiguration());
            modelBuilder.Configurations.Add(new OportunidadeConfiguration());

            //Secundarias
            modelBuilder.Configurations.Add(new NascionalidadeConfiguration());
            modelBuilder.Configurations.Add(new PaisConfiguration());
            modelBuilder.Configurations.Add(new ProfissaoConfiguration());
            modelBuilder.Configurations.Add(new ReligiaoConfiguration());
            modelBuilder.Configurations.Add(new EnderecoConfiguration());
            modelBuilder.Configurations.Add(new EnderecoProjetoConfiguration());
            modelBuilder.Configurations.Add(new CidConfiguration());

            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges()//Salvar Mudanças
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataDeModificacao") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataDeModificacao").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataDeModificacao").IsModified = false;
                }
            }
            return base.SaveChanges();
        }

    }
}