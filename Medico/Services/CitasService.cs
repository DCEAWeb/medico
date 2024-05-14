using Medico.Data;
using Medico.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Medico.Services
{
    public class CitasService (ApplicationDbContext context) : ICitas
    {
        public async Task<List<Cita>> ObtenerCitasHoy()
        {
            List<Cita> citas = new List<Cita>();
            
            citas = await context.Citas.Include(p => p.Paciente)
                .OrderByDescending(f => f.Fecha).ToListAsync();
            
            return citas;
        }

        public async Task<List<Paciente>> Pacientes()
        {
            List<Paciente> pacientes = new List<Paciente>();

            pacientes = await context.Pacientes.ToListAsync();

            return pacientes;
        }

        public async Task<Cita> AgendarCita(Cita cita)
        {
            var respuesta = context.Citas.Add(cita);
            await context.SaveChangesAsync();
            return cita;
        }

        public async Task BorrarCita(int id)
        {
            var cita = await context.Citas.FindAsync(id);
            if(cita != null)
            {
                context.Citas.Remove(cita);
                await context.SaveChangesAsync();
            }
        }

        public async Task<Cita> ModificarCita(Cita cita)
        {
            context.Citas.Update(cita);
            await context.SaveChangesAsync();
            return cita;
        }

        public async Task<Cita> ObtenerCita(int id)
        {
            var cita = await context.Citas.FindAsync(id);
            return cita;
        }
    }
}
