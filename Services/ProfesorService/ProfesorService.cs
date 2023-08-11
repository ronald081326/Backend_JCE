using UniversidadJCE1.Context;
using UniversidadJCE1.Models;

namespace UniversidadJCE1.Services.ProfesoresService
{
    public class ProfesorService : IProfesorService
    {
        private readonly DataContext _context;

        public ProfesorService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Profesor>?> AddProfesor(Profesor profesores)
        {
            _context.Profesores.Add(profesores);
            await _context.SaveChangesAsync();
            return await _context.Profesores.ToListAsync();
        }

        public async Task<List<Profesor>> Get()
        {
            var profesores = await _context.Profesores.ToListAsync();
            return profesores;
        }
        public async Task<Profesor?> GetById(int id)
        {
            var profesor = await _context.Profesores.FindAsync(id);
            if (profesor is null)
                return null;

            return(profesor);
        }

        public async Task<List<Profesor>?> UpdateProfesor(int id, Profesor request)
        {
            var profesor = await _context.Profesores.FindAsync(id);
            if (profesor == null)
                return null;

            profesor.Nombre = request.Nombre;
            profesor.Apellido = request.Apellido;
            profesor.Activo = request.Activo;
           

            await _context.SaveChangesAsync();

            return await _context.Profesores.ToListAsync();
        }

        Task<List<Profesor?>> IProfesorService.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
