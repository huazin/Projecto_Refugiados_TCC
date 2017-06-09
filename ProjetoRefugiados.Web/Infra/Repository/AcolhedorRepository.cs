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
            add.Ativo = true;
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
            return Db.Acolhedores.Where(p => p.Ativo == true).ToList();
        }

        public void Remove(Acolhedor remove)
        {
            //Db.Acolhedores.Remove(remove);
            Db.Entry(remove).Property(p => p.Ativo).CurrentValue = false;
            Db.SaveChanges();
        }
        public void Remove(int remove)
        {
            //Db.Acolhedores.Remove(remove);
            Db.Entry(FindById(remove)).Property(p => p.Ativo).CurrentValue = false;
            Db.SaveChanges();
        }
        public void Ativar(int ativar)
        {
            Db.Entry(FindById(ativar)).Property(p => p.Ativo).CurrentValue = true;
            Db.SaveChanges();
        }

        public IEnumerable<Acolhedor> ListAll()
        {
            return Db.Acolhedores.ToList();
        }

        public IEnumerable<Acolhedor> ListNome(string nome)
        {
            return Db.Acolhedores.ToList().Where(p => p.Nome.ToLower().Contains(nome.ToLower()));
        }

        public IEnumerable<Acolhedor> ListCpf(string cpf)
        {
            return Db.Acolhedores.Where(p => p.Cpf.Contains(cpf)).ToList();
        }
    }
}