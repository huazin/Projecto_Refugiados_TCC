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

        public void Ativar(int id)
        {
            Refugiado refu = FindById(id);
            var verificador = Db.Refugiados.Where(p => p.CPF == refu.CPF && p.Ativo == true).FirstOrDefault();
            if (verificador == null)
            {
                Db.Entry(refu).Property(p => p.Ativo).CurrentValue = true;
            }
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public void Edit(Refugiado edit)
        {
            Db.Entry(edit).State = EntityState.Modified;
            Db.Entry(edit).Property(p => p.Ativo).CurrentValue = true;
            Db.SaveChanges();
        }

        public Refugiado FindById(int key)
        {
            return Db.Refugiados.Find(key);
        }

        public IEnumerable<Refugiado> List()
        {
            return Db.Refugiados.Where(p => true == p.Ativo).ToList();
        }
        public IEnumerable<Refugiado> ListAll()
        {
            return Db.Refugiados.ToList();
        }

        public IEnumerable<Refugiado> ListNome(string nome)
        {
            return Db.Refugiados.ToList().Where(p => p.Nome.ToLower().Contains(nome.ToLower()));
        }

        public IEnumerable<Refugiado> ListCpf(string cpf)
        {
            return Db.Refugiados.Where(p => p.CPF.Contains(cpf)).ToList();
        }

        public void Remove(Refugiado remove)
        {
            Db.Entry(remove).Property(p => p.Ativo).CurrentValue = false;
            //Db.Refugiados.Remove(remove);
            Db.SaveChanges();
        }
        public void Remove(int id)
        {
            Db.Entry(FindById(id)).Property(p => p.Ativo).CurrentValue = false;
            //Db.Refugiados.Remove(remove);
            Db.SaveChanges();
        }

        public Refugiado FindByCPF(string key)
        {
            return Db.Refugiados.Where(p => p.CPF == key).SingleOrDefault();
        }
    }
}