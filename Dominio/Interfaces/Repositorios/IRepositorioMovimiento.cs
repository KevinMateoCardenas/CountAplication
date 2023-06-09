namespace WebApplicationDocker.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioMovimiento<TEntidad, TEntidadID>
        : IAgregar<TEntidad>, IListar<TEntidad, TEntidadID>, ITransaccion
    {
    }
}
