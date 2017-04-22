using ProjetoRefugiados.Web.Domain.Models.Secudarias;
using ProjetoRefugiados.Web.Infra.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.Repository
{
    public class PaisRepository : ICrud<Pais>
    {
        public ProjetoRefugiadosContext Db = new ProjetoRefugiadosContext();
        public void Add(Pais add)
        {
            Db.Paises.Add(add);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public void Edit(Pais edit)
        {
            Db.Entry(edit).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public Pais FindById(int key)
        {
            return Db.Paises.Find(key);       
        }

        public IEnumerable<Pais> List()
        {
            return Db.Paises.ToList();
        }

        public void Remove(Pais remove)
        {
            Db.Paises.Remove(remove);
            Db.SaveChanges();
        }
    }
}