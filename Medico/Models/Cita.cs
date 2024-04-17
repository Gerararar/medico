using System.ComponentModel.DataAnnotations;

namespace Medico.Models
{
    public class Cita
    {
        public int ID { get; set; }
        [Range(1, int.MaxValue,ErrorMessage ="favor de elegir un paciente valido")]
        public int PacienteID { get; set; }
        public Paciente? Paciente { get; set; }

        public DateTime Fecha { get; set; }
        public string? Observaciones { get; set; }

        ICollection<Paciente>Pacientes { get; set;}
    }
}
