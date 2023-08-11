global using UniversidadJCE1.Models;
global using UniversidadJCE1.Context;
using UniversidadJCE1.Services.CursoService;
using UniversidadJCE1.Services.ICursoService;
using UniversidadJCE1.Services.ProfesoresService;
using UniversidadJCE1.Services.CursoDetalleService;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICursoDetalleService, CursoDetalleService>();
builder.Services.AddScoped<ICursoService, CursoService>();
builder.Services.AddScoped<IEstudianteService, EstudianteService>();
builder.Services.AddScoped<IProfesorService, ProfesorService>();

builder.Services.AddDbContext<DataContext>(options =>
  options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
