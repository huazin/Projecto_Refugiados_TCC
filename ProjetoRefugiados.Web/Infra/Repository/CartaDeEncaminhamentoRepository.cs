using ProjetoRefugiados.Web.Domain.Models;
using ProjetoRefugiados.Web.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.Repository
{
    public class CartaDeEncaminhamentoRepository : ICrud<CartaDeEncaminhamento>
    {
        ProjetoRefugiadosContext Db = new ProjetoRefugiadosContext();
        public void Add(CartaDeEncaminhamento add)
        {
            Db.CartaoDeEncaminhamento.Add(add);
            Db.Entry(add).Property(p => p.ativo).CurrentValue = true;
            Db.Entry(add).Property(p => p.resultado).CurrentValue = 0;
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public void Resultado(int id, int flag) // 1 Ativo -- 2 Reprovado
        {
            Db.Entry(FindById(id)).Property(p => p.resultado).CurrentValue = flag;
        }

        public void Edit(CartaDeEncaminhamento edit)
        {
            Db.Entry(edit).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }

        public CartaDeEncaminhamento FindById(int key)
        {
            return Db.CartaoDeEncaminhamento.Find(key);
        }

        public IEnumerable<CartaDeEncaminhamento> List()
        {
            return Db.CartaoDeEncaminhamento.ToList();
        }

        public void Remove(CartaDeEncaminhamento remove)
        {
            Db.Entry(remove).Property(p => p.ativo).CurrentValue = false;
            Db.SaveChanges();
        }
    }
}