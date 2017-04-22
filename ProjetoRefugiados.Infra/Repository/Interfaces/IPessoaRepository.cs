using ProjetoRefugiados.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRefugiados.Infra.Repository.Interfaces
{
    public interface IPessoaRepository
    {
        void Incluir(Pessoa pessoa);

        void Editar(Pessoa pessoa);

        void Deletar(Pessoa pessoa);

        Pessoa ObterPorId(int id);

        IEnumerable<Pessoa> ListarPessoas();

        void Dispose();
    }
}
