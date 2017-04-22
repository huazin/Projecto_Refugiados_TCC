using ProjetoRefugiados.Infra.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoRefugiados.Domain;
using System.Data.Entity;
using ProjetoRefugiados.Infra.Context;

namespace ProjetoRefugiados.Infra.Repository
{
    public class ReligiaoRepository : IReligiaoRepository, IDisposable
    {
        ProjetoContext Db = new ProjetoContext();
        public void Deletar(Religiao religiao)
        {
            Db.Religioes.Remove(religiao);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public void Editar(Religiao religiao)
        {
            Db.Entry(religiao).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Incluir(Religiao religiao)
        {
            Db.Religioes.Add(religiao);
            Db.SaveChanges();
        }

        public IEnumerable<Religiao> ListarReligiao()
        {
            return Db.Religioes.ToList();
        }


        public Religiao ObterPorId(int id)
        {
            return Db.Religioes.Find(id);
        }
    }
}
