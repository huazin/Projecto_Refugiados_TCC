using ProjetoRefugiados.Domain;
using System;
using System.Collections.Generic;

namespace ProjetoRefugiados.Infra.Repository.Interfaces
{
    public interface IPaisRepository
    {
        void Incluir(Pais pais);

        void Editar(Pais pais);

        void Deletar(Pais pais);

        Pais ObterPorId(int id);

        IEnumerable<Pais> ListarPais();

        void Dispose();
    }
}
