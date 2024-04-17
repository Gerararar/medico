using Medico.Data;
using Medico.Models;
using Microsoft.EntityFrameworkCore;

namespace Medico.Services
{
    public class CitasServices(ApplicationDbContext context) : ICitas
    {
        public async Task<List<Cita>> ObtenerCitashoy()
        {
            List<Cita> citas = new List<Cita>();
            citas= await context.Citas.Include(p=>p.Paciente).OrderByDescending(f=>f.Fecha).ToListAsync();
            return citas;
        }

        public async Task<List<Paciente>> Pacientes()
        {
            List<Paciente> pacientes = new List<Paciente>();
            pacientes = await context.Pacientes.ToListAsync();
            return pacientes;

        }
    }
}
