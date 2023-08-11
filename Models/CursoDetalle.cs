using System.ComponentModel.DataAnnotations;

namespace UniversidadJCE1.Models
{
    public class CursoDetalle
    {
        public int CursoDetalleId { get; set; }
        public Curso? Curso { get; set; }
        public int CursoId { get; set; }
        public Estudiantes? Estudiante { get; set; }
        public int EstudianteId { get; set; }
    }
}
