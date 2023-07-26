using UniversidadJCE1.Models;
using UniversidadJCE1.Services.ICursoService;

namespace UniversidadJCE1.Services.CursoService
{
    public class CursoDetalleService : ICursoDetalleService
    {
        private static List<CursoDetalle> Cursodetalle = new List<CursoDetalle>
        {
          new CursoDetalle
          { CursoId = 1,
            EstudianteId = 2
          }
        };
        public List<CursoDetalle> Addcurso(CursoDetalle detalle)
        {
            throw new NotImplementedException();
        }

        public List<CursoDetalle> Get()
        {
            throw new NotImplementedException();
        }

        public CursoDetalle Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<CursoDetalle> Updatecurso(CursoDetalle request)
        {
            var detalles = Cursodetalle.Find(p => p.CursoId == request.CursoId);
            if (detalles == null)
                return null;

            detalles.CursoId = request.CursoId;
            detalles.EstudianteId = request.EstudianteId;

            return Cursodetalle;
        }

        List<CursoDetalle> ICursoDetalleService.Get(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
