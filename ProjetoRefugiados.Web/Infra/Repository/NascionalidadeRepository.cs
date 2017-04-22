using ProjetoRefugiados.Web.Domain.Models.Secudarias;
using ProjetoRefugiados.Web.Infra.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.Repository
{
    public class NascionalidadeRepository : ICrud<Nascionalidade>
    {
        public ProjetoRefugiadosContext Db = new ProjetoRefugiadosContext();
        public void Add(Nascionalidade add)
        {
            Db.Nacionalidades.Add(add);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public void Edit(Nascionalidade edit)
        {
            Db.Entry(edit).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public Nascionalidade FindById(int key)
        {
            return Db.Nacionalidades.Find(key);
        }

        public IEnumerable<Nascionalidade> List()
        {
            return Db.Nacionalidades.ToList();
        }

        public void Remove(Nascionalidade remove)
        {
            Db.Nacionalidades.Remove(remove);
            Db.SaveChanges();
        }
    }
}