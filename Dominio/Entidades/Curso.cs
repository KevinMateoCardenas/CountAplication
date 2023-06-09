namespace WebApplicationDocker.Dominio.Entidades
{
    public class Curso
    {
        public Guid cursoId { get; set; }
        public string? nombre { get; set; }
        public List<Estudiante>? estudiantes { get; set; }
    }
}