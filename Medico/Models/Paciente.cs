using System.ComponentModel.DataAnnotations;

namespace Medico.Models
{
    public class Paciente
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="El nombre del paciente es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El primer apellido del paciente es requerido")]
        public string Apellido1 { get; set; }
        public string? Apellido2 { get; set; }
        [Required(ErrorMessage = "La {0} del paciente es requerida")]
        [MinLength(18, ErrorMessage = "La {0} del paciente debe tener {1} caracteres")]
        [MaxLength(18, ErrorMessage = "La {0} del paciente debe tener {1} caracteres")]
        public string CURP { get; set; }
        [Required(ErrorMessage = "El tipo de sangre del paciente es requerido")]
        public string Sangre { get; set; }
        public string? Observaciones { get; set; }
    }
}
