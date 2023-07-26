using UniversidadJCE1.Controllers;
using UniversidadJCE1.Models;
using UniversidadJCE1.Services.ICursoService;

namespace UniversidadJCE1.Services.CursoService
{
    public interface ICursoService
    {
        List<Curso> Get();
        Curso Get(int Id);
        List<Curso> Addcurso(Curso curso);
        List<Curso> Updatecurso(Curso request);
    }
}
