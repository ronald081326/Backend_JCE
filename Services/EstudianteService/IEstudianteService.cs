using UniversidadJCE1.Models;

namespace UniversidadJCE1.Services.ProfesoresService
{
    public interface IEstudianteService
    {
        List<Estudiantes> Get();
        Estudiantes Get(int Id);
        List<Estudiantes> AddEstudiante(Estudiantes Estudiante);
        List<Estudiantes> UpdateEstudiante(Estudiantes request);
    }
}
