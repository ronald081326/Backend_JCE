using System.ComponentModel.DataAnnotations;
using UniversidadJCE1.Models;



namespace UniversidadJCE1.Models
{
    public class Estudiantes
    {
        public int Id { get; set; }
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Activo { get; set; }
    }
}
