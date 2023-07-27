using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UniversidadJCE1.Models;



namespace UniversidadJCE1.Models
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Activo { get; set; }
        public Curso? Curso { get; set; }
        public int CursoId { get; set; }
        public CursoDetalle? CursoDetalles { get; set; }

    }
}
