using ProjetoRefugiados.Infra.Repository.Interfaces;
using System;
using System.Collections.Generic;
using ProjetoRefugiados.Domain;
using ProjetoRefugiados.Infra.Context;
using System.Data.Entity;
using System.Linq;

namespace ProjetoRefugiados.Infra.Repository
{
    public class PaisRepository : IPaisRepository, IDisposable
    {
        ProjetoContext Db = new ProjetoContext();

        public void Deletar(Pais pais)
        {
            Db.Paises.Remove(pais);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public void Editar(Pais pais)
        {
            Db.Entry(pais).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Incluir(Pais pais)
        {
            Db.Paises.Add(pais);
            Db.SaveChanges();
        }

        public IEnumerable<Pais> ListarPais()
        {
            return Db.Paises.ToList();
        }

        public Pais ObterPorId(int id)
        {
            return Db.Paises.Find(id);
        }
    }
}
