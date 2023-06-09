using WebApplicationDocker.Aplicacion.Interfaces;
using WebApplicationDocker.Dominio.Entidades;
using WebApplicationDocker.Dominio.Interfaces.Repositorios;

namespace WebApplicationDocker.AppAplicacion.Servicios
{
    public interface IEstudianteServicio : IServicioBase<Estudiante, String>
    {
        string? VerificadorUnicidadCedula(string cedula);
    }
    public class EstudianteServicio : IEstudianteServicio

    {
        private readonly IRepositorioBase<Estudiante, String> repoEstudiante;
        public EstudianteServicio(IRepositorioBase<Estudiante, String> _repoEstudiante)
        {
            repoEstudiante = _repoEstudiante;
        }
        public void Actualizar(Estudiante entidad)
        {
            if (entidad.numeroIdentificacion == null)
                throw new ArgumentNullException(nameof(entidad), "La Identificacion es requerida");

            repoEstudiante.Editar(entidad);
            repoEstudiante.SalvarTodo();
        }
        public Estudiante Agregar(Estudiante entidad)
        {
            if (entidad.numeroIdentificacion == null)
                throw new ArgumentNullException(nameof(entidad), "La Identificacion es requerida");

            var resultEstudiante = repoEstudiante.Agregar(entidad);
            repoEstudiante.SalvarTodo();
            return resultEstudiante;
        }
        public string? VerificadorUnicidadCedula(string cedula)
        {
            string mensaje = "";
            var cliente_id = (from entidad in repoEstudiante.Listar()
                              where entidad.numeroIdentificacion == cedula
                              select new
                              {
                                  nombre = entidad.nombre
                              }).FirstOrDefault();
            mensaje = cliente_id?.nombre ?? string.Empty;
            return mensaje;
        }
        public List<Estudiante> Listar()
        {
            return repoEstudiante.Listar();
        }

        public Estudiante? SeleccionarPorID(String entidadId)
        {
            return repoEstudiante.SeleccionarPorID(entidadId);
        }
    }
}