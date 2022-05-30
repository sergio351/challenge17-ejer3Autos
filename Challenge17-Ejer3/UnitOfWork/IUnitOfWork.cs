using Challenge17_Ejer3.Data;
using Challenge17_Ejer3.Repositorio;
using Challenge17_Ejer3.Repositorio.Clases;

namespace Challenge17_Ejer3.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IClienteRepository ClienteRepo { get; }
        IVentaRepository VentaRepo { get; }
        IVehiculoRepository VehiculoRepo { get; }
        void Save();
    }
    
}
