using System.ComponentModel.DataAnnotations;

namespace Medico.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage ="El nombre del paciente es requerido")]
        public string Nombre { get; set; }
        
        [Required(ErrorMessage = "El primer apellido del paciente es requerido")]
        public string PrimerApellido { get; set; }
        
        public string? SegundoApellido { get; set; }

        [Required(ErrorMessage = "La {0} del paciente es requerida")]
        [MinLength(18,ErrorMessage = "La {0} debe de tener {1} caracteres")]
        [MaxLength(18,ErrorMessage = "La {0} debe de tener {1} caracteres")]
        public string CURP { get; set; }

        [Required(ErrorMessage = "El tipo de sangre del paciente es requerido")]
        public string TipoSangre { get; set; }
        public string? Observaciones { get; set; }
    }
}
