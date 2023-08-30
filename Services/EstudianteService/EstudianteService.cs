using UniversidadJCE1.Models;
using UniversidadJCE1.Services.EstudianteService;


namespace UniversidadJCE1.Services.EstudianteService
{
    public class EstudianteService : IEstudianteService
    {

        private readonly DataContext _context;

        public EstudianteService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Estudiantes>> Get()
        {
            var estudiantes = await _context.Estudiantes.ToListAsync();
            return estudiantes;
        }

        public async Task<Estudiantes?> GetSingleId(int id)
        {
            var students = await _context.Estudiantes.FindAsync(id);
            if (students is null)
                return null;

            return(students);
        }

        public async Task<List<Estudiantes>> AddEstudiante(Estudiantes estudiantes)
        {
            _context.Estudiantes.Add(estudiantes);
            await _context.SaveChangesAsync();
            return await _context.Estudiantes.ToListAsync();

        }

        public async Task<List<Estudiantes>?> UpdateEstudiante(int id,Estudiantes request)
        {
            var student = await _context.Estudiantes.FindAsync(id);
            if (student is null)
                return null;


            student.Nombre = request.Nombre;
            student.Apellido = request.Apellido;
            student.Activo = request.Activo;
           

            await _context.SaveChangesAsync();                    

            return await _context.Estudiantes.ToListAsync();
        }
    }
}

