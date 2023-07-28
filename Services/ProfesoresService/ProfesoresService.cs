using Microsoft.EntityFrameworkCore;
using UniversidadJCE1.Context;
using UniversidadJCE1.Models;
using UniversidadJCE1.Services.ProfesoresService;

namespace UniversidadJCE1.Services.IProfesoresServices
{
    public class ProfesoresService : IProfesoresService
    {
        private readonly DataContext _context;

        public ProfesoresService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Profesores>> AddProfesor(Profesores profesores)
        {
            _context.Profesores.Add(profesores);
            await _context.SaveChangesAsync();
            return await _context.Profesores.ToListAsync();

        }

        public async Task<List<Profesores>> Get()
        {
            var profesor = await _context.Profesores.ToListAsync();
            return profesor;
        }

        public async Task<Profesores> GetById(int id)
        {
            var profesor = await _context.Profesores.FindAsync(id);
            if (profesor is null)
                return null;

            return profesor;
        }

        public async Task<List<Profesores>> UpdateProfesor(int id, Profesores request)
        {
            var profesor = await _context.Profesores.FindAsync(id);
            if (profesor is null)
                return null;

            profesor.ProfesorId = id;
            profesor.Nombre = request.Nombre;
            profesor.Apellido = request.Apellido;
            profesor.Activo = request.Activo;
            profesor.CursoId = request.CursoId;



            await _context.SaveChangesAsync();

            return await _context.Profesores.ToListAsync();
        }

        public List<Profesores> UpdateProfesor(Profesores request)
        {
            throw new NotImplementedException();
        }

        List<Profesores> IProfesoresService.AddProfesor(Profesores profesores)
        {
            throw new NotImplementedException();
        }

        List<Profesores> IProfesoresService.Get()
        {
            throw new NotImplementedException();
        }

        Profesores IProfesoresService.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
