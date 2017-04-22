using ProjetoRefugiados.Infra.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoRefugiados.Domain;
using System.Data.Entity;
using ProjetoRefugiados.Infra.Context;

namespace ProjetoRefugiados.Infra.Repository
{
    public class NascionalidadeRepository : INascionalidadeRepository, IDisposable
    {
        ProjetoContext Db = new ProjetoContext();
        public void Deletar(Nascionalidade nascionalidade)
        {
            Db.Nascionalidades.Remove(nascionalidade);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public void Editar(Nascionalidade nascionalidade)
        {
            Db.Entry(nascionalidade).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Incluir(Nascionalidade nascionalidade)
        {
            Db.Nascionalidades.Add(nascionalidade);
            Db.SaveChanges();
        }

        public IEnumerable<Nascionalidade> ListarNascionalidade()
        {
            return Db.Nascionalidades.ToList();
        }

        public Nascionalidade ObterPorId(int id)
        {
            return Db.Nascionalidades.Find(id);
        }

    }
}
