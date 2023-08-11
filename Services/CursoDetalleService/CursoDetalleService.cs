using Microsoft.EntityFrameworkCore;
using UniversidadJCE1.Context;
using UniversidadJCE1.Models;
using UniversidadJCE1.Services.ICursoService;

namespace UniversidadJCE1.Services.CursoDetalleService
{
    public class CursoDetalleService : ICursoDetalleService
    {
       private readonly DataContext _context;

        public CursoDetalleService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<CursoDetalle>?> Addcurso(CursoDetalle cursoDetalle)
        {
            _context.CursoDetalles.Add(cursoDetalle);
            await _context.SaveChangesAsync();
            return await _context.CursoDetalles.ToListAsync();
        }

        public async Task<List<CursoDetalle>> Get()
        {
            var cursoDetalle = await _context.CursoDetalles.ToListAsync();
            return cursoDetalle;
        }

        public async Task<CursoDetalle?> GetById(int id)
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
