using ProjetoRefugiados.Infra.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoRefugiados.Domain;
using ProjetoRefugiados.Infra.Context;
using System.Data.Entity;

namespace ProjetoRefugiados.Infra.Repository
{

    public class PessoaRepository : IPessoaRepository, IDisposable
    {
        public ProjetoContext Db = new ProjetoContext();

        public void Deletar(Pessoa pessoa)
        {
            Db.Pessoas.Remove(pessoa);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public void Editar(Pessoa pessoa)
        {
            Db.Entry(pessoa).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Incluir(Pessoa pessoa)
        {
            Db.Pessoas.Add(pessoa);
            Db.SaveChanges();
        }

        public IEnumerable<Pessoa> ListarPessoas()
        {
            return Db.Pessoas.ToList();
        }

        public Pessoa ObterPorId(int id)
        {
            return Db.Pessoas.Find(id);
        }

    }
}
