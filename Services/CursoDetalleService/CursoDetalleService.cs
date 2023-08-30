using UniversidadJCE1.Models;
using UniversidadJCE1.Services.CursoDetalleService;

namespace UniversidadJCE1.Services.CursoDetalleService
{
    public class CursoDetalleService : ICursoDetalleService
    {

       private readonly DataContext _context;

        public CursoDetalleService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<CursoDetalle>> Get()
        {
            var cursoDetalles = await _context.CursoDetalles.ToListAsync();
            return cursoDetalles;
        }

        public async Task<List<CursoDetalle>> Addcurso(CursoDetalle cursoDetalle)
        {
            _context.CursoDetalles.Add(cursoDetalle);
            await _context.SaveChangesAsync();
            return await _context.CursoDetalles.ToListAsync();
        }

        public async Task<CursoDetalle?> GetSingleId(int id)
        {
            var cursoDetalle = await _context.CursoDetalles.FindAsync(id);
            if (cursoDetalle is null)
                return null;

            return cursoDetalle;
        }

        public async Task<List<CursoDetalle>?> Updatecurso(int id, CursoDetalle request)
        {
            var cursoDetalle = await _context.CursoDetalles.FindAsync(id);
            if (cursoDetalle is null)
                return null;

            cursoDetalle.CursoDetalleId = id;
            cursoDetalle.CursoId = request.CursoId;
            cursoDetalle.EstudianteId = request.EstudianteId;

            await _context.SaveChangesAsync();

            return await _context.CursoDetalles.ToListAsync();
        }

    }
}
