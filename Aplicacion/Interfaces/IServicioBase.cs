using WebApplicationDocker.Dominio.Interfaces;

namespace WebApplicationDocker.Aplicacion.Interfaces
{
    public interface IServicioBase<TEntidad, TEntidadID>
        : IAgregar<TEntidad>, IListar<TEntidad, TEntidadID>
    {
    }
}
