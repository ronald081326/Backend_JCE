using System.ComponentModel.DataAnnotations;


namespace UniversidadJCE1.Models
{
    public class Profesor
    {
        public int ProfesorId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Apellido { get; set; } = null!;
        public bool Activo { get; set; }
        public int CursoId { get; set; }
        public Curso? Curso { get; set; }
    }

}

