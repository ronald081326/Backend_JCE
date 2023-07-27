using UniversidadJCE1.Models;

namespace UniversidadJCE1.Services.ProfesoresService
{
    public interface IProfesoresService
    {
        List<Profesores> Get();
        Profesores GetById(int id);
        List<Profesores> AddProfesor(Profesores profesores);
        List<Profesores> UpdateProfesor(Profesores request);
    }
}
