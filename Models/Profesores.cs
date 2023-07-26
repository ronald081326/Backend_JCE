using System.ComponentModel.DataAnnotations;


namespace UniversidadJCE1.Models
{
    public class Profesores
    {
        public int Id { get; set; }
        public int ProfesorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Activo { get; set; }
        public Curso? Curso { get; set; }
    }
}
