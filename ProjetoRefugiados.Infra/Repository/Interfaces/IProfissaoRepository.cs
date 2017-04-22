using ProjetoRefugiados.Domain;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoRefugiados.Infra.Repository.Interfaces
{
    interface IProfissaoRepository
    {
        void Incluir(Profissao profissao);

        void Editar(Profissao profissao);

        void Deletar(Profissao profissao);

        Profissao ObterPorId(int id);

        IEnumerable<Profissao> ListarProfissao();

        void Dispose();
    }
}
