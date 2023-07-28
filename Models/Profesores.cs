using System.ComponentModel.DataAnnotations;


namespace UniversidadJCE1.Models
{
    public class Profesores
    {
        internal readonly object?[]? id;

        [Key]
        public int ProfesorId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public bool Activo { get; set; }
        public List<Curso>? Curso { get; set; }
        public int CursoId { get; set; } 
    }
}
