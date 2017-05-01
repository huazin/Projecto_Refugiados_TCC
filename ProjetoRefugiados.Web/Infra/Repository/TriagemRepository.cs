using ProjetoRefugiados.Web.Domain.Models;
using ProjetoRefugiados.Web.Infra.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.Repository
{
    public class TriagemRepository : ICrud<Triagem>
    {
        ProjetoRefugiadosContext Db = new ProjetoRefugiadosContext();
        public void Add(Triagem add)
        {
            Db.Triagens.Add(add);
            Db.Entry(add).Property(p => p.Ativo).CurrentValue = true;
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public void Edit(Triagem edit)
        {
            Db.Entry(edit).State = EntityState.Modified;
            Db.Entry(edit).Property(p => p.Ativo).CurrentValue = true;
            Db.SaveChanges();
        }

        public Triagem FindById(int key)
        {
            return Db.Triagens.Find(key);
        }

        public IEnumerable<Triagem> List()
        {
            return Db.Triagens.Where(p => p.Ativo == true).ToList();
        }

        public void Remove(Triagem remove)
        {
            
            Db.Entry(remove).Property(p => p.Ativo).CurrentValue = false;
            //Db.Triagens.Remove(remove);
            Db.SaveChanges();
        }
    }
}