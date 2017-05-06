using ProjetoRefugiados.Web.Domain.Models.Secudarias;
using ProjetoRefugiados.Web.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.Repository
{
    public class CidRepository : ICrud<Cid>
    {
        ProjetoRefugiadosContext Db = new ProjetoRefugiadosContext();
        public void Add(Cid add)
        {
            Db.Cids.Add(add);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public void Edit(Cid edit)
        {
            Db.Entry(edit).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }

        public Cid FindById(int key)
        {
            return Db.Cids.Find(key);
        }

        public IEnumerable<Cid> List()
        {
            return Db.Cids.ToList();
        }

        public IEnumerable<Cid> FindByDes(string desc)
        {
            return Db.Cids.Where(p => p.Descricao.Contains(desc)).ToList().DefaultIfEmpty();
        }

        public void Remove(Cid remove)
        {
            throw new NotImplementedException();
        }
    }
}