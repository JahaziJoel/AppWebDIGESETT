using AppDIGESETT.Models;
using AppDIGESETT.Data;
using Microsoft.EntityFrameworkCore;


namespace AppDIGESETT.Services
{
    public class MultaService
    {
        private readonly DataContext _context;

        public MultaService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Multa>> ObtenerMultasAsync()
        {
            return await _context.Multas.ToListAsync();
        }

        public async Task AgregarMultaAsync(Multa multa)
        {
            _context.Multas.Add(multa);
            await _context.SaveChangesAsync();
        }
    }
}
