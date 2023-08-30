using UniversidadJCE1.Dto;
using UniversidadJCE1.Models;

namespace UniversidadJCE1.Services.EstudianteService;

public interface IEstudianteService
{
    Task<List<Estudiantes>> Get();
    Task<Estudiantes?> GetSingleId(int id);
    Task<List<Estudiantes>> AddEstudiante(Estudiantes estudiantes);
    Task<List<Estudiantes>?> UpdateEstudiante(int id, Estudiantes request);
}
