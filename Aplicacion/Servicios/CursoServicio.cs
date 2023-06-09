using WebApplicationDocker.Aplicacion.Interfaces;
using WebApplicationDocker.Dominio.Entidades;
using WebApplicationDocker.Dominio.Interfaces.Repositorios;

namespace WebApplicationDocker.Aplicacion.Servicios
{
    public interface ICursoServicio : IServicioMovimiento<Curso, Guid>
    {
    }
    public class CursoServicio : ICursoServicio
    {
        private readonly IRepositorioMovimiento<Curso, Guid> repoCurso;

        public CursoServicio(IRepositorioMovimiento<Curso, Guid> _repoCurso)
        {
            repoCurso = _repoCurso;
        }
        public Curso Agregar(Curso entidad)
        {
            //Regla 1
            if (entidad.nombre == null)
                throw new ArgumentNullException(nameof(entidad), "El 'nombre' es requerido");

            repoCurso.Agregar(entidad);
            repoCurso.GuardarTodosLosCambios();
            return entidad;
        }

        public List<Curso> Listar()
        {
            return repoCurso.Listar().ToList();
        }

        public Curso? SeleccionarPorID(Guid entidadId)
        {
            return repoCurso.SeleccionarPorID(entidadId);
        }
    }
}