using ProjetoRefugiados.Web.Domain.Models.Secudarias;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.EntityConfig.Secundarios
{
    public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            HasKey(p => p.RefugiadoId);
        }
    }
}