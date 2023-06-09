namespace WebApplicationDocker.Dominio.Interfaces
{
    public interface IEditar<in TEntidad>
    {
        void Editar(TEntidad entidad);
    }
}
