using UniversidadJCE1.Models;
using UniversidadJCE1.Services.ICursoService;

namespace UniversidadJCE1.Services.CursoService
{
    public class CursoDetalleService : ICursoDetalleService
    {
        private static List<CursoDetalle> Cursodetalle = new List<CursoDetalle>
        {
          new CursoDetalle
          { CursoDetalleId = 1,
             CursoId = 1,
             EstudianteId = 1,
          },
          new CursoDetalle
            {
                CursoDetalleId = 12,
                CursoId = 12,
                EstudianteId = 12,
            }
        };

        public List<CursoDetalle> Addcurso(CursoDetalle cursoDetalle)
        {
            throw new NotImplementedException();
        }

        public List<CursoDetalle> Get()
        {
            throw new NotImplementedException();
        }

        public CursoDetalle GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CursoDetalle> Updatecurso(CursoDetalle request)
        {
            throw new NotImplementedException();
        }
    }
}
