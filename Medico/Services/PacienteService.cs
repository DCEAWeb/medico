using Medico.Data;
using Medico.Models;
using Microsoft.EntityFrameworkCore;

namespace Medico.Services
{
    public class PacienteService(ApplicationDbContext context) : IPaciente
    {
        public async Task<Paciente> RegistrarPaciente(Paciente paciente)
        {
            context.Pacientes.Add(paciente);
            await context.SaveChangesAsync();
            return paciente;
        }

        public async Task<List<Paciente>> ListarPacientes()
        {
            List<Paciente> pacientes = new List<Paciente>();
            pacientes= await context.Pacientes.ToListAsync();
            return pacientes;
        }
    }
}
