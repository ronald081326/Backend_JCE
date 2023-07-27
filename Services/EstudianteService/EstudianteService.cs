using Microsoft.EntityFrameworkCore;
using UniversidadJCE1.Context;
using UniversidadJCE1.Models;

namespace UniversidadJCE1.Services.ProfesoresService
{  
        public class EstudianteService : IEstudianteService
        {
        private readonly DataContext _context;

        public EstudianteService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Estudiantes>> AddEstudiante(Estudiantes estudiantes)
        {
            _context.Estudiantes.Add(estudiantes);
            await _context.SaveChangesAsync();
            return await _context.Estudiantes.ToListAsync();
        }

        public async Task<List<Estudiantes>> Get()
        {
            var students = await _context.Estudiantes.ToListAsync();
            return students;
        }

        public async Task<Estudiantes> GetById(int id)
        {
            var students = await _context.Estudiantes.FindAsync(id);
            if (students is null)
                return null;

            return students;
        }

        public async Task<List<Estudiantes>> UpdateEstudiante(int id,Estudiantes request)
        {
            var student = await _context.Estudiantes.FindAsync(id);
            if (student is null)
                return null;

            student.Nombre = request.Nombre;
            student.Apellido = request.Apellido;
            student.Activo = request.Activo;
            student.FechaNacimiento = request.FechaNacimiento;
            student.CursoId = request.CursoId;

            await _context.SaveChangesAsync();

            return await _context.Estudiantes.ToListAsync();
        }
    }
}

