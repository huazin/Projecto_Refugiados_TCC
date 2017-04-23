using ProjetoRefugiados.Web.Domain.Models;
using ProjetoRefugiados.Web.Domain.Models.Secudarias;
using ProjetoRefugiados.Web.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.Repository
{
    public class ReligiaoRepository : ICrud<Religiao>
    {
        public ProjetoRefugiadosContext Db = new ProjetoRefugiadosContext();
        public void Add(Religiao add)
        {
            Db.Religoes.Add(add);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public void Edit(Religiao edit)
        {
            Db.Entry(edit).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }

        public Religiao FindById(int key)
        {
            return Db.Religoes.Find(key);
        }

        public IEnumerable<Religiao> List()
        {
            return Db.Religoes.ToList();
        }

        public void Remove(Religiao remove)
        {
            Db.Religoes.Remove(remove);
            Db.SaveChanges();
        }
    }
}