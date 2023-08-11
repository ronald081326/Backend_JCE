using System.ComponentModel.DataAnnotations;
using UniversidadJCE1.Models;



namespace UniversidadJCE1.Models
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        public string? Nombre { get; set; } = null!;
        public string? Apellido { get; set; } = null!;
        public DateTime FechaNacimiento { get; set; }
        public bool Activo { get; set; }
        public Curso? Curso { get; set; }
        public int CursoId { get; set; }
    }
}
