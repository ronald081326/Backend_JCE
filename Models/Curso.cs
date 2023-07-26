using UniversidadJCE1.Models;
using System.ComponentModel.DataAnnotations;


namespace UniversidadJCE1.Models
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Descripcion { get; set; }
        public List<Profesores>? Profesors { get; set; }
        public int ProfesorId { get; set; }
        public DateTime Fecha { get; set; }

    }
}
