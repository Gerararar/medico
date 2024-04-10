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
            citas= await context.Citas.ToListAsync();
            return citas;
        }
    }
}
