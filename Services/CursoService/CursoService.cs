using UniversidadJCE1.Controllers;
using UniversidadJCE1.Models;

namespace UniversidadJCE1.Services.CursoService
{
    public class CursoService : ICursoService
    {
        private static List<Curso> curso = new List<Curso>
        {
          new Curso
          { CursoId = 1,
            Descripcion = "Software",
            ProfesorId = 2,
            Fecha = new DateTime(),
          }
        };
        public List<Curso> Getcurso(Curso curso)
        {
            throw new NotImplementedException();
        }

        public List<Curso> Addcurso(Curso curso)
        {
            throw new NotImplementedException();
        }

        public List<Curso> Get()
        {
            throw new NotImplementedException();
        }

        public Curso Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Curso> Updatecurso(Curso request)
        {
            var course = curso.Find(c => c.CursoId == request.CursoId);
            if (course == null)
                return null;

            course.CursoId = request.CursoId;
            course.Descripcion = request.Descripcion;
            course.ProfesorId = request.ProfesorId;
            course.Fecha = request.Fecha;

            return curso;
        }
        List<Curso> ICursoService.Get()
        {
            throw new NotImplementedException();
        }

        Curso ICursoService.Get(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
