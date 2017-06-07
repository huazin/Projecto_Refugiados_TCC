using ProjetoRefugiados.Web.Domain.Models;
using ProjetoRefugiados.Web.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.Repository
{
    public class AcolhedorRepository : ICrud<Acolhedor>
    {
        ProjetoRefugiadosContext Db = new ProjetoRefugiadosContext();
        public void Add(Acolhedor add)
        {
            Db.Acolhedores.Add(add);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public void Edit(Acolhedor edit)
        {
            Db.Entry(edit).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }

        public Acolhedor FindById(int key)
        {
            return Db.Acolhedores.Find(key);
        }

        public IEnumerable<Acolhedor> List()
        {
            return Db.Acolhedores.ToList();
        }

        public void Remove(Acolhedor remove)
        {
            Db.Acolhedores.Remove(remove);
            Db.SaveChanges();
        }
    }
}