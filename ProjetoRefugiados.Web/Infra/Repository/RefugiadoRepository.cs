using ProjetoRefugiados.Web.Domain.Models;
using ProjetoRefugiados.Web.Infra.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.Repository
{
    public class RefugiadoRepository : ICrud<Refugiado>
    {
        public ProjetoRefugiadosContext Db = new ProjetoRefugiadosContext();

        public void Add(Refugiado add)
        {
            Db.Refugiados.Add(add);
            Db.Entry(add).Property(p => p.Ativo).CurrentValue = true;
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public void Edit(Refugiado edit)
        {
            Db.Entry(edit).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public Refugiado FindById(int key)
        {
            return Db.Refugiados.Find(key);
        }

        public IEnumerable<Refugiado> List()
        {
            return Db.Refugiados.ToList();
        }

        public void Remove(Refugiado remove)
        {
            Db.Entry(remove).Property(p => p.Ativo).CurrentValue = false;
            //Db.Refugiados.Remove(remove);
            Db.SaveChanges();
        }
    }
}