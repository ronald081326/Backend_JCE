using UniversidadJCE1.Models;
using Microsoft.EntityFrameworkCore;

namespace UniversidadJCE1.Dto
{
    public class EstudiantesDto
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public bool Activo { get; set; }
       
    }
}
