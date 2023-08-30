using UniversidadJCE1.Dto;
using UniversidadJCE1.Models;
using UniversidadJCE1.Services.CursoService;

namespace UniversidadJCE1.Services.CursoService;
public class CursoService : ICursoService
{

    private readonly DataContext _context;

    public CursoService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<Curso>> Get()
    {
       var curso = await _context.Cursos.ToListAsync();
       return curso;
    }

    public async Task<List<Curso>> Addcurso(Curso cursos)
    {
        _context.Cursos.Add(cursos);
        await _context.SaveChangesAsync();
        return await _context.Cursos.ToListAsync();
    }


    public async Task<List<Curso>?> Updatecurso(int id, Curso request)
    {
        var curso = await _context.Cursos.FindAsync(id);
        if (curso is null)
            return null;

        curso.Descripcion = request.Descripcion;
        curso.Fecha = request.Fecha;
        curso.EstudianteId = request.EstudianteId;

        await _context.SaveChangesAsync();

        return await _context.Cursos.ToListAsync();
    }

    public async Task<Curso?> GetSingleId(int id)
    {
        var curso = await _context.Cursos.FindAsync(id);
        if (curso is null)
            return null;

        return curso;
    }
}

