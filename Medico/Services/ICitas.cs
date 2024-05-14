using Medico.Models;

namespace Medico.Services
{
    public interface ICitas
    {
        Task<List<Cita>> ObtenerCitasHoy();
        Task<List<Paciente>> Pacientes();
        Task<Cita> AgendarCita(Cita cita);
        Task BorrarCita(int id);
        Task<Cita> ModificarCita(Cita cita);
        Task<Cita> ObtenerCita(int id);
    }
}
