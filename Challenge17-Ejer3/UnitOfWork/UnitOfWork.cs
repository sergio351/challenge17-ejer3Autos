using Challenge17_Ejer3.Data;
using Challenge17_Ejer3.Repositorio;
using Challenge17_Ejer3.Repositorio.Clases;

namespace Challenge17_Ejer3.UnitOfWork
{
  
        public class UnitOfWork : IUnitOfWork
        {
            private readonly ApplicationDbContext _context;

            public IClienteRepository ClienteRepo { get; private set; }

            public IVentaRepository VentaRepo { get; private set; }

            public IVehiculoRepository VehiculoRepo { get; private set; }

      
        public UnitOfWork(ApplicationDbContext context)
            {
                _context = context;
                ClienteRepo = new ClienteRepository(context);
                VentaRepo = new VentaRepository(context);
                VehiculoRepo = new VehiculoRepository(context);
            }

            public void Dispose()
            {
                _context.Dispose();
            }

            public void Save()
            {
                _context.SaveChanges();
            }
        }
    }

