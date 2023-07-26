using UniversidadJCE1.Controllers;
using UniversidadJCE1.Models;
using UniversidadJCE1.Services.ProfesoresService;

namespace UniversidadJCE1.Services.ProfesoresService
{  
        public class EstudianteService : IEstudianteService
        {
        private static List<Estudiantes> Estudiante = new List<Estudiantes>
        {
          new Estudiantes
          { EstudianteId = 1,
            Nombre = "Dostin",
            Apellido = "Santana",
            FechaNacimiento = new DateTime(),
            Activo = "Yes"
          },
           new Estudiantes
           { EstudianteId = 2,
             Nombre = "Claudio",
             Apellido = "Ferreira",
             FechaNacimiento = new DateTime(),
             Activo = "No"
           }
        };
            public List<Estudiantes> Get(Estudiantes Estudiante)
            {
                throw new NotImplementedException();
            }

            public List<Estudiantes> AddEstudiante(Estudiantes Estudiante)
            {
                throw new NotImplementedException();
            }

            public List<Estudiantes> Get()
            {
                throw new NotImplementedException();
            }

            public Estudiantes Get(int Id)
            {
                throw new NotImplementedException();
            }

            public List<Estudiantes> UpdateEstudiante(Estudiantes request)
            {
                var estudiante = Estudiante.Find(c => c.EstudianteId == request.Id);
                if (estudiante == null)
                    return null;

                estudiante.EstudianteId = request.EstudianteId;
                estudiante.Nombre = request.Nombre;
                estudiante.Apellido = request.Apellido;
                estudiante.FechaNacimiento = request.FechaNacimiento;
                
                return Estudiante;
            }
            List<Estudiantes> IEstudianteService.Get()
            {
                throw new NotImplementedException();
            }
             Estudiantes IEstudianteService.Get(int Id)
             {
                 throw new NotImplementedException();
             }
        }
}

