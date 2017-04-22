using ProjetoRefugiados.Web.Domain.Models.Secudarias;
using ProjetoRefugiados.Web.Infra.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.Repository
{
    public class ProfissaoRepository : ICrud<Profissao>
    {
        public ProjetoRefugiadosContext Db = new ProjetoRefugiadosContext();
        public void Add(Profissao add)
        {
            Db.Profissoes.Add(add);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public void Edit(Profissao edit)
        {
            Db.Entry(edit).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public Profissao FindById(int key)
        {
            return Db.Profissoes.Find(key);
        }

        public IEnumerable<Profissao> List()
        {
            return Db.Profissoes.ToList();
        }

        public void Remove(Profissao remove)
        {
            Db.Profissoes.Remove(remove);
            Db.SaveChanges();
        }
    }
}