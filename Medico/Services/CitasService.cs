using Medico.Data;
using Medico.Models;
using Microsoft.EntityFrameworkCore;

namespace Medico.Services
{
    public class CitasService (ApplicationDbContext context) : ICitas
    {
        public async Task<List<Cita>> ObtenerCitasHoy()
        {
            List<Cita> citas = new List<Cita>();
            citas = await context.Citas.ToListAsync();
            return citas;
        }
    }
}
