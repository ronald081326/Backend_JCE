using UniversidadJCE1.Models;

namespace UniversidadJCE1.Services.ProfesoresService
{
    public interface IProfesorService
    {
        Task<List<Profesor>> Get();
        Task<List<Profesor?>> GetById(int id);
        Task<List<Profesor>?> AddProfesor(Profesor profesores);
        Task<List<Profesor>?> UpdateProfesor(int id, Profesor request);
    }
}
