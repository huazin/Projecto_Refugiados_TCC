using ProjetoRefugiados.Domain;
using System.Collections.Generic;

namespace ProjetoRefugiados.Infra.Repository.Interfaces
{
    interface IReligiaoRepository
    {
        void Incluir(Religiao religiao);

        void Editar(Religiao religiao);

        void Deletar(Religiao religiao);

        Religiao ObterPorId(int id);

        IEnumerable<Religiao> ListarReligiao();

        void Dispose();
    }
}
