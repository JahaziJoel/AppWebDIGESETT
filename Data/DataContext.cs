using Microsoft.EntityFrameworkCore;
using AppDIGESETT.Models;

namespace AppDIGESETT.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Multa> Multas { get; set; } 
        public DbSet<Agente> Agentes { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Agente>().HasData(
            new Agente { Id = 1, Cedula = "12345678", Nombre = "Agente 1", Clave = "clave123", Rol = "Agente", Activo = true },
            new Agente { Id = 2, Cedula = "87654321", Nombre = "Oficina Central", Clave = "clave456", Rol = "Oficina", Activo = true },
            new Agente { Id = 3, Cedula = "adamix", Nombre = "Administrador", Clave = "estoesfacil", Rol = "Administrador", Activo = true }
        );
    }


    }
}
