using WebApplicationDocker.Dominio.Interfaces;

namespace WebApplicationDocker.Aplicacion.Interfaces
{
    public interface IServicioMovimiento<TEntidad, TEntidadID>
        : IAgregar<TEntidad>, IListar<TEntidad, TEntidadID>
    {
    }
}
