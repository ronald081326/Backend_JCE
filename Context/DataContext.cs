global using Microsoft.EntityFrameworkCore;
using UniversidadJCE1.Models;

namespace UniversidadJCE1.Context;

public class DataContext : DbContext
{
    private const string ConnectionString = "Initial Catalog=UniversidadJdb;Server=LDEVELOPER24\\SQLEXPRESS;User=JCE\\Dostin_Santana;Encrypt=False;";
                                            
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

        modelBuilder.Entity<Curso>()
                    .HasMany(c => c.Estudiantes)
                    .WithOne(e => e.Curso)
                    .HasForeignKey(e => e.CursoId)
                    .HasPrincipalKey(c => c.CursoId)
                    .OnDelete(DeleteBehavior.Restrict);


    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(ConnectionString);
        

    }

    public DbSet<Profesor> Profesores { get; set; }
    public DbSet<Estudiantes> Estudiantes { get; set; }
    public DbSet<CursoDetalle> CursoDetalles { get; set; }
    public DbSet<Curso> Cursos { get; set; }
}
