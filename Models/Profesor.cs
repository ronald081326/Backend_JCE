using UniversidadJCE1.Models;
using System.ComponentModel.DataAnnotations;
using UniversidadJCE1.Dto;

namespace UniversidadJCE1.Models
{
    public class Profesor
    {
        [Key]
        public int ProfesorId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Apellido { get; set; } = null!;
        public bool Activo { get; set; }
        public Curso? Curso { get; set; }
        public int CursoId { get; set; }
    }

}

