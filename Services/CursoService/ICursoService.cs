using UniversidadJCE1.Models;

namespace UniversidadJCE1.Services.CursoService
{
    public interface ICursoService
    {
        List<Curso> Get();
        Curso GetById(int id);
        List<Curso> Addcurso(Curso cursos);
        List<Curso> Updatecurso(Curso request);

    }
}
