namespace UniversidadJCE1.Models
{
    public class CursoDetalle
    {
        public int CursoId { get; set; }
        public Curso? Curso { get; set; }
        public List<Estudiantes>? Estudiantes { get; set; }
        public int EstudianteId { get; set; }
    }
}
