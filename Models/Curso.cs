using UniversidadJCE1.Models;
using System.ComponentModel.DataAnnotations;


namespace UniversidadJCE1.Models
{
    public class Curso
    {

        [Key]
        public int CursoId { get; set; }
        public string? Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public Profesor? Profesor { get; set; }
        public int ProfesorId { get; set; }
        public List<CursoDetalle>? CursoDetalle { get; set; }
        public int CursoDetalleId { get; set; }
        public List<Estudiantes>? Estudiantes { get; set; }
        public int EstudianteId { get; set; }

    }
}
