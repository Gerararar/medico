using System.ComponentModel.DataAnnotations;

namespace Medico.Models
{
    public class Cita
    {
        public int ID { get; set; }
        [Range(0, int.MaxValue,ErrorMessage ="favor de elegir un paciente valido")]
        public int NombreID { get; set; }
        public Paciente? Paciente { get; set; }

        public DateTime Fecha { get; set; }
        public string? Observaciones { get; set; }

        ICollection<Paciente>Pacientes { get; set;}
    }
}
