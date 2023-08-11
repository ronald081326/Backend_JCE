using UniversidadJCE1.Models;
using Microsoft.EntityFrameworkCore;

namespace UniversidadJCE1.Dto
{
    public class EstudiantesDto
    {
        public int EstudianteId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Activo { get; set; }
       
    }
}
