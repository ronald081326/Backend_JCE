using UniversidadJCE1.Models;
using UniversidadJCE1.Services.ProfesoresService;

namespace UniversidadJCE1.Services.ProfesoresService
{
    public interface IProfesoresService
    {
        List<Profesores> Get();
        List<Profesores> Get(int Id);
        List<Profesores> AddProfesor(Profesores Profesor);
        List<Profesores> UpdateProfesor(Profesores request);
    }
}
