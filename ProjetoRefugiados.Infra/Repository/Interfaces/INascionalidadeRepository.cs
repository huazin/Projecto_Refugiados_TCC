using ProjetoRefugiados.Domain;
using System.Collections.Generic;

namespace ProjetoRefugiados.Infra.Repository.Interfaces
{
    interface INascionalidadeRepository
    {
        void Incluir(Nascionalidade nascionalidade);

        void Editar(Nascionalidade nascionalidade);

        void Deletar(Nascionalidade nascionalidade);

        Nascionalidade ObterPorId(int id);

        IEnumerable<Nascionalidade> ListarNascionalidade();

        void Dispose();

    }
}
