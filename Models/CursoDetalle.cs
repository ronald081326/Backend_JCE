using System.ComponentModel.DataAnnotations;
using UniversidadJCE1.Models;

namespace UniversidadJCE1.Models
{
    public class CursoDetalle
    {
        [Key]
        public int CursoDetalleId { get; set; }
        public Curso? Curso { get; set; }
        public int CursoId { get; set; }
        public Estudiantes? Estudiante { get; set; }
        public int EstudianteId { get; set; }
    }
}
