using Microsoft.EntityFrameworkCore;
using UniversidadJCE1.Context;
using UniversidadJCE1.Models;
using UniversidadJCE1.Controllers;


namespace UniversidadJCE1.Services.CursoService;

public class CursoService : ICursoService
{
    private readonly DataContext _context;

    public CursoService(DataContext context)
    { 
      _context = context;
    }

    public object Detalle => throw new NotImplementedException();

    public async Task<List<Curso>> Addcurso(Curso cursos)
    {
        _context.Cursos.Add(cursos);
        await _context.SaveChangesAsync();
        return await _context.Cursos.ToListAsync();
    }

    public async Task<List<Curso>> Get()
    {
        var curso = await _context.Cursos.ToListAsync();
        return curso;
    }

    public async Task<Curso> GetById(int id)
    {
        var curso = await _context.Cursos.FindAsync(id);
        if (curso is null)
            return null;

        return curso;
    }

    public async Task<List<Curso>> Updatecurso(int id, Curso request)
    {
        var curso = await _context.Cursos.FindAsync(id);
        if (curso is null)
            return null;

        curso.CursoId = id;
        curso.Descripcion = request.Descripcion;
        curso.Fecha = request.Fecha;
        curso.ProfesorId = request.ProfesorId;
        curso.CursoDetalleId = request.CursoDetalleId;
        curso.EstudianteId = request.EstudianteId;

        await _context.SaveChangesAsync();

        return await _context.Cursos.ToListAsync();
    }

    public List<Curso> Updatecurso(Curso request)
    {
        throw new NotImplementedException();
    }

    List<Curso> ICursoService.Addcurso(Curso cursos)
    {
        throw new NotImplementedException();
    }

    List<Curso> ICursoService.Get()
    {
        throw new NotImplementedException();
    }

    Curso ICursoService.GetById(int id)
    {
        throw new NotImplementedException();
    }
}
