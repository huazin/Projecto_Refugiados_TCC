using ProjetoRefugiados.Web.Domain.Models.Secudarias;
using ProjetoRefugiados.Web.Infra.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.Repository
{
    public class EnderecoRepository : ICrud<Endereco>
    {
        public ProjetoRefugiadosContext Db = new ProjetoRefugiadosContext();
        public void Add(Endereco add)
        {
            Db.Enderecos.Add(add);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public void Edit(Endereco edit)
        {
            Db.Entry(edit).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public Endereco FindById(int key)
        {
            return Db.Enderecos.Find(key);
        }

        public IEnumerable<Endereco> List()
        {
            return Db.Enderecos.ToList();
        }

        public void Remove(Endereco remove)
        {
            Db.Enderecos.Remove(remove);
            Db.SaveChanges();
        }
    }
}