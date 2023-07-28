using UniversidadJCE1.Models;
using UniversidadJCE1.Services.CursoService;
using UniversidadJCE1.Controllers;

namespace UniversidadJCE1.Services.CursoService
{
    public interface ICursoService
    {
        object Detalle { get; }

        List<Curso> Get();
        Curso GetById(int id);
        List<Curso> Addcurso(Curso cursos);
        List<Curso> Updatecurso(Curso request);

    }
}
