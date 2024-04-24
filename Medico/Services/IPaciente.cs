using Medico.Models;

namespace Medico.Services
{
    public interface IPaciente
    {
        Task<Paciente> RegistrarPaciente(Paciente paciente);
        Task<List<Paciente>> ListarPacientes();
    }
}
