using Challenge17_Ejer3.Data;
using Challenge17_Ejer3.Entity;

namespace Challenge17_Ejer3.Repositorio.Clases
{
    public class VentaRepository : GenericRepository<Venta>, IVentaRepository
    {
        public VentaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
