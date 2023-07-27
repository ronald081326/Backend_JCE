using Microsoft.EntityFrameworkCore;
using UniversidadJCE1.Models;
using UniversidadJCE1.Controllers;
using System.Reflection.Metadata;

namespace UniversidadJCE1.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Estudiantes>()
            .HasOne(e => e.CursoDetalles)
            .WithOne(e => e.Estudiante)
            .HasForeignKey<CursoDetalle>(e => e.EstudianteId)
            .OnDelete(DeleteBehavior.ClientCascade);
    }
    public DbSet<Profesores> Profesores { get; set; }
    public DbSet<Estudiantes> Estudiantes { get; set; }
    public DbSet<CursoDetalle> CursoDetalles { get; set; }
    public DbSet<Curso> Cursos { get; set; }
}
