using Medico.Models;

namespace Medico.Services
{
    public interface ICitas
    {
        Task<List<Cita>> ObtenerCitasHoy();
    }
}
