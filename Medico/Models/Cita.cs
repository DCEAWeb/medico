using System.ComponentModel.DataAnnotations;

namespace Medico.Models
{
    public class Cita
    {
        public int Id { get; set; }

        [Range(1, int.MaxValue, ErrorMessage ="Favor de elegir el paciente")]
        public int PacienteId { get; set; }
        public Paciente? Paciente { get; set; }
        public DateTime Fecha { get; set; }
        public string? Observaciones { get; set; }

        ICollection<Paciente> Pacientes { get; set;}
    }
}
