using Microsoft.EntityFrameworkCore;
using AppDIGESETT.Data;
using AppDIGESETT.Models;

namespace AppDIGESETT.Services
{
    public class AdminService
    {
        private readonly DataContext _context;

        public AdminService(DataContext context)
        {
            _context = context;
        }

        // Método para obtener los agentes
        public async Task<List<Agente>> GetAgentesAsync()
        {
            return await _context.Agentes.ToListAsync();
        }

        // Método para crear un nuevo agente
        public async Task CrearAgenteAsync(Agente agente)
        {
            _context.Agentes.Add(agente);
            await _context.SaveChangesAsync();
        }

        // Método para obtener los conceptos de multas
        public async Task<List<Multa>> GetMultasAsync()
        {
            return await _context.Multas.ToListAsync();
        }

        // Método para crear un nuevo concepto de multa
        public async Task CrearMultaAsync(Multa multa)
        {
            _context.Multas.Add(multa);
            await _context.SaveChangesAsync();
        }

        // Método para obtener los conceptos de multas que se mostrarán a los agentes
        public async Task<List<Multa>> GetConceptosAsync()
        {
            return await _context.Multas.ToListAsync();
        }
    }
}
