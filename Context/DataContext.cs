global using Microsoft.EntityFrameworkCore;
using UniversidadJCE1.Migrations;
using UniversidadJCE1.Models;

namespace UniversidadJCE1.Context;

public class DataContext : DbContext
{
    private const string ConnectionString = "server=LDEVELOPER24\\SQLEXPRESS;Database=Universidad1JCEdb;User=JCE\\Dostin_Santana;Trusted_connection=true;TrustServerCertificate=true;";
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {


    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Curso>()
            .HasOne(c => c.Profesor)
            .WithOne(p => p.Curso)
            .HasForeignKey<Profesor>(p => p.CursoId)
            .HasPrincipalKey<Curso>(c => c.CursoId);

        _ = modelBuilder.Entity<Curso>()
          .HasOne(c => c.Estudiantes)
          .WithOne(e => e.Curso)
            .HasForeignKey<Estudiantes>(p => p.EstudianteId)
           //.HasPrincipalKey(c => c.ProfesorId)
            .OnDelete(DeleteBehavior.Restrict);

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(ConnectionString);
    }

    public DbSet<Curso> Cursos { get; set; }
    public DbSet<Profesor> Profesores { get; set; }
    public DbSet<Estudiantes> Estudiantes { get; set; }
    public DbSet<CursoDetalle> CursoDetalles { get; set; }
}
