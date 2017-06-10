using ProjetoRefugiados.Web.Domain.Models;
using ProjetoRefugiados.Web.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.Repository
{
    public class ExameRepository : ICrud<Exame>
    {
        ProjetoRefugiadosContext Db = new ProjetoRefugiadosContext();
        public void Add(Exame add)
        {
            Db.Exames.Add(add);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public void Edit(Exame edit)
        {
            Db.Entry(edit).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }

        public Exame FindById(int key)
        {
           return Db.Exames.Find(key);

        }

        public IEnumerable<Exame> List()
        {
            return Db.Exames.ToList();
        }

        public void Remove(Exame remove)
        {
            Db.Exames.Remove(remove);
            Db.SaveChanges();
        }
    }
}