using ProjetoRefugiados.Web.Domain.Models;
using ProjetoRefugiados.Web.Infra.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.Repository
{
    public class ProjetoRepository : ICrud<Projeto>
    {
        ProjetoRefugiadosContext Db = new ProjetoRefugiadosContext();
        public void Add(Projeto add)
        {
            add.Ativo = true;
            Db.Projetos.Add(add);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public void Edit(Projeto edit)
        {
            Db.Entry(edit).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public Projeto FindById(int key)
        {
            return Db.Projetos.Find(key);
        }

        public IEnumerable<Projeto> List()
        {
            return Db.Projetos.Where(p => p.Ativo == true).ToList();
        }
        public IEnumerable<Projeto> ListAll()
        {
            return Db.Projetos.ToList();
        }

        public void Remove(Projeto remove)
        {
            Db.Entry(remove).Property(p => p.Ativo).CurrentValue = false;
            Db.SaveChanges();
        }
        public void Remove(int remove)
        {
            Db.Entry(this.FindById(remove)).Property(p => p.Ativo).CurrentValue = false;
            Db.SaveChanges();
        }

        public void Ativar(int ativa)
        {
            Db.Entry(this.FindById(ativa)).Property(p => p.Ativo).CurrentValue = true;
            Db.SaveChanges();
        }

        public IEnumerable<Projeto> ListNome(string nome)
        {
            return Db.Projetos.ToList().Where(p => p.Nome.ToLower().Contains(nome.ToLower()));
        }

        public IEnumerable<Projeto> ListCnpj(string cnpj)
        {
            return Db.Projetos.Where(p => p.CNPJ.Contains(cnpj)).ToList();
        }

    }
}