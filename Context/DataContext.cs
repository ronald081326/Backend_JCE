global using Microsoft.EntityFrameworkCore;
using BackendApi.Models;

namespace BackendApi.Context;

public class DataContext : DbContext
{
    private const string ConnectionString = "server=DESKTOP-7EH32N5\\SQLEXPRESS;Database=UNIVERSIDAD; Integrated Security=true; TrustServerCertificate=true;";
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {


    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Profesor>()
         .HasMany(p => p.Cursos) // Un profesor tiene muchos cursos
         .WithOne(c => c.Profesor) // Un curso pertenece a un profesor
         .HasForeignKey(c => c.ProfesorId);

        modelBuilder.Entity<Curso>()
        .HasMany(c => c.Estudiantes) // Un curso tiene muchos estudiantes
        .WithOne(e => e.Curso) // Un estudiante pertenece a un curso
        .HasForeignKey(e => e.CursoId);

        // Call the base OnModelCreating to apply any other configurations
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(ConnectionString);
    }
    public DbSet<Profesor> Profesores { get; set; }
    public DbSet<Curso> Cursos { get; set; }

    public DbSet<Estudiante> Estudiantes { get; set; }


}
