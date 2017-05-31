using ProjetoRefugiados.Web.Domain.Models;
using ProjetoRefugiados.Web.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.Infra.Repository
{
    public class OportunidadeRepository : ICrud<Oportunidade>
    {
        ProjetoRefugiadosContext Db = new ProjetoRefugiadosContext();
        public void Add(Oportunidade add)
        {
            Db.Oportunidades.Add(add);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public void Edit(Oportunidade edit)
        {
            Db.Entry(edit).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }

        public Oportunidade FindById(int key)
        {
            return Db.Oportunidades.Find(key);
        }

        public IEnumerable<Oportunidade> List()
        {
            return Db.Oportunidades.ToList();
        }
        public IEnumerable<Oportunidade> ListVagos()
        {
            return Db.Oportunidades.Where(p => p.Quantidade > p.Associados.Count).ToList();
        }

        public IEnumerable<Oportunidade> ListEmpresa(string nome)
        {
            return Db.Oportunidades.Where(p => p.projeto.Nome == nome).ToList();
        }
        public IEnumerable<Oportunidade> ListTitulo(string nome)
        {
            return Db.Oportunidades.Where(p => p.Titulo == nome).ToList();
        }

        public void Remove(Oportunidade remove)
        {
            Db.Oportunidades.Remove(remove);
            Db.SaveChanges();
        }
    }
}