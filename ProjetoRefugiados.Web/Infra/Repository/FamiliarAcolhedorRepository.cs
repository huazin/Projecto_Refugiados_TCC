using ProjetoRefugiados.Web.Domain.Models;
using ProjetoRefugiados.Web.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.Repository
{
    public class FamiliarAcolhedorRepository : ICrud<FamiliarAcolhedor>
    {
        ProjetoRefugiadosContext Db = new ProjetoRefugiadosContext();
        public void Add(FamiliarAcolhedor add)
        {
            Db.FamiliarAcolhedores.Add(add);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public void Edit(FamiliarAcolhedor edit)
        {
            Db.Entry(edit).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }

        public FamiliarAcolhedor FindById(int key)
        {
            return Db.FamiliarAcolhedores.Find(key);
        }

        public IEnumerable<FamiliarAcolhedor> List()
        {
            return Db.FamiliarAcolhedores.ToList();
        }

        public void Remove(FamiliarAcolhedor remove)
        {
            Db.FamiliarAcolhedores.Remove(remove);
            Db.SaveChanges();
        }
    }
}