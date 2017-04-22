using ProjetoRefugiados.Domain;
using System.Collections.Generic;

namespace ProjetoRefugiados.Infra.Repository.Interfaces
{
    public interface IPacientesRepository
    {
        void Incluir(Paciente paciente);

        void Editar(Paciente paciente);

        void Deletar(Paciente paciente);

        Paciente ObterPorId(int id);

        IEnumerable<Paciente> ListarPacientes();

        void Dispose();
    }
}
