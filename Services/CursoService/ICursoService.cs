using UniversidadJCE1.Models;
using UniversidadJCE1.Services.CursoService;
using UniversidadJCE1.Controllers;

namespace UniversidadJCE1.Services.CursoService
{
    public interface ICursoService
    {
        Task<List<Curso>> Get();
        Task<Curso?> GetById(int id);
        Task<List<Curso>> Addcurso(Curso cursos);
        Task<List<Curso>?> Updatecurso(int id, Curso request);
    }
}
