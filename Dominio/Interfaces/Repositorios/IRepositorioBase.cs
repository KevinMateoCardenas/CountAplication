namespace WebApplicationDocker.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioBase<TEntidad, TEntidadID>
        : IAgregar<TEntidad>, IEditar<TEntidad>, IListar<TEntidad, TEntidadID>, ITransaccion, ISalvarTodo
    {
    }
}
