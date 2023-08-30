using UniversidadJCE1.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace UniversidadJCE1.Dto
{
    public class ProfesoresDto
    {
        public string? Nombre { get; set; } = string.Empty;
        public string? Apellido { get; set; } = string.Empty;
        public bool Activo { get; set; } = false;
        
    }
}
