using UniversidadJCE1.Dto;
using UniversidadJCE1.Models;

namespace UniversidadJCE1.Services.CursoService
{
    public interface ICursoService
    {
        Task<List<Curso>> Get();
        Task<Curso?> GetSingleId(int id);
        Task<List<Curso>> Addcurso(Curso cursos);
        Task<List<Curso>?> Updatecurso(int id, Curso request);
    }
}
