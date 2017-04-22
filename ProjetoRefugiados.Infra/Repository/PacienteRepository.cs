using ProjetoRefugiados.Infra.Repository.Interfaces;
using System;
using System.Collections.Generic;
using ProjetoRefugiados.Domain;
using ProjetoRefugiados.Infra.Context;
using System.Data.Entity;
using System.Linq;

namespace ProjetoRefugiados.Infra.Repository
{
    public class PacienteRepository : IPacientesRepository, IDisposable
    {
        ProjetoContext Db = new ProjetoContext();
        public void Deletar(Paciente paciente)
        {
            Db.Pacientes.Remove(paciente);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public void Editar(Paciente paciente)
        {
            Db.Entry(paciente).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Incluir(Paciente paciente)
        {
            //Db.Pessoas.Add(paciente.Pessoa);
            Db.Pacientes.Add(paciente);
            Db.SaveChanges();
        }

        public IEnumerable<Paciente> ListarPacientes()
        {
            return Db.Pacientes.ToList();
        }

        public Paciente ObterPorId(int id)
        {
            return Db.Pacientes.Find(id);
        }
    }
}
