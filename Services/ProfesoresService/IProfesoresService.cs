using UniversidadJCE1.Models;
using UniversidadJCE1.Controllers;
using UniversidadJCE1.Services;

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
