using ProjetoRefugiados.Domain;
using ProjetoRefugiados.Infra.Context;
using ProjetoRefugiados.Infra.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ProjetoRefugiados.Infra.Repository
{
    public class ProfissaoRepository : IProfissaoRepository, IDisposable
    {
        public ProjetoContext Db = new ProjetoContext();

    public void Deletar(Profissao profissao)
    {
        Db.Profissoes.Remove(profissao);
        Db.SaveChanges();
    }

    public void Dispose()
    {
        Db.Dispose();
    }

    public void Editar(Profissao profissao)
    {
        Db.Entry(profissao).State = EntityState.Modified;
        Db.SaveChanges();
    }

    public void Incluir(Profissao profissao)
    {
        Db.Profissoes.Add(profissao);
        Db.SaveChanges();
    }

    public IEnumerable<Profissao> ListarProfissao()
    {
        return Db.Profissoes.ToList();
    }

    public Profissao ObterPorId(int id)
    {
        return Db.Profissoes.Find(id);
    }
}
}
