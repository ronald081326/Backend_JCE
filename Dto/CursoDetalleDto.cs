using Microsoft.EntityFrameworkCore;
using UniversidadJCE1.Models;

namespace UniversidadJCE1.Dto
{
    public class CursoDetalleDto
    {
        public int CursoId { get; set; }
        public int EstudianteId { get; set; }

    }
}
