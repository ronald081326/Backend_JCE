using UniversidadJCE1.Models;
using Microsoft.EntityFrameworkCore;

namespace UniversidadJCE1.Dto
{
    public class ProfesoresDto
    {
        public int ProfesorId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public bool Activo { get; set; }
        
    }
}
