using Microsoft.EntityFrameworkCore;
using UniversidadJCE1.Models;
using UniversidadJCE1.Controllers;

namespace UniversidadJCE1.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    
    public DbSet<Profesores> Profesores { get; set; }
    public DbSet<Estudiantes> Estudiantes { get; set; }
    public DbSet<CursoDetalle> CursoDetalles { get; set; }
    public DbSet<Curso> Cursos { get; set; }
}
