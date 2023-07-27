using UniversidadJCE1.Models;

namespace UniversidadJCE1.Services.ProfesoresService
{
    public interface IEstudianteService
    {
        Task<List<Estudiantes>> Get();
        Task<Estudiantes> GetById(int id);
        Task<List<Estudiantes>> AddEstudiante(Estudiantes estudiantes);
        Task<List<Estudiantes>> UpdateEstudiante(int id, Estudiantes request);
    }
}
