using Challenge17_Ejer3.Entity;
using Microsoft.EntityFrameworkCore;

namespace Challenge17_Ejer3.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options)
        {

        }
        public DbSet<Venta>? Venta { get; set; }
        public DbSet<Cliente>? Cliente { get; set; }
        public DbSet<Vehiculo>? Vehiculo { get; set; }

    }
}
