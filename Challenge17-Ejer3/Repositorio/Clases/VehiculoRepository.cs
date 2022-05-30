using Challenge17_Ejer3.Data;
using Challenge17_Ejer3.Entity;

namespace Challenge17_Ejer3.Repositorio.Clases
{
    public class VehiculoRepository : GenericRepository<Vehiculo>, IVehiculoRepository
    {
        public VehiculoRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
