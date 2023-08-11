using Microsoft.EntityFrameworkCore;
using UniversidadJCE1.Models;

namespace UniversidadJCE1.Dto
{
    public class CursoDto
    {
        public int CursoId { get; set; }
        public string? Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public int ProfesorId { get; set; }
    }
}
