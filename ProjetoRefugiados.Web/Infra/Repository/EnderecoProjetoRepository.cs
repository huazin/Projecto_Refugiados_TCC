using ProjetoRefugiados.Web.Domain.Models.Secudarias;
using ProjetoRefugiados.Web.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.Repository
{
    public class EnderecoProjetoRepository : ICrud<EnderecoProjeto>
    {
        ProjetoRefugiadosContext Db = new ProjetoRefugiadosContext();
        public void Add(EnderecoProjeto add)
        {
            Db.EnderecosProjeto.Add(add);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public void Edit(EnderecoProjeto edit)
        {
            Db.Entry(edit).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }

        public EnderecoProjeto FindById(int key)
        {
            return Db.EnderecosProjeto.Find(key);

        }

        public IEnumerable<EnderecoProjeto> List()
        {
            return Db.EnderecosProjeto.ToList();
        }

        public void Remove(EnderecoProjeto remove)
        {
            Db.EnderecosProjeto.Remove(remove);
            Db.SaveChanges();
        }
    }
}