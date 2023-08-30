using UniversidadJCE1.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace UniversidadJCE1.Dto
{
    public class CursoDto
    {
        [Key]
        public string? Descripcion { get; set; }
        public int ProfesorId { get; set; }
    }
}
