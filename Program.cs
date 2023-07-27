using Microsoft.EntityFrameworkCore;
using UniversidadJCE1.Services;
using UniversidadJCE1.Context;
using UniversidadJCE1.Services.CursoService;
using UniversidadJCE1.Services.ICursoService;
using UniversidadJCE1.Services.ProfesoresService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICursoDetalleService,CursoDetalleService>();
builder.Services.AddScoped<ICursoService, CursoService>();
builder.Services.AddScoped<IEstudianteService, EstudianteService>();
builder.Services.AddScoped<IProfesoresService, ProfesoresService>();

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

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
