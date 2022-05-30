using Challenge17_Ejer3.Data;
using Challenge17_Ejer3.Entity;

namespace Challenge17_Ejer3.Repositorio.Clases
{
    public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ApplicationDbContext context) : base(context)
        {
        }
   
    }
}
