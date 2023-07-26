using UniversidadJCE1.Controllers;
using UniversidadJCE1.Models;
using UniversidadJCE1.Services.ProfesoresService;

namespace UniversidadJCE1.Services.ProfesoresService
{
    public class ProfesoresService : IProfesoresService
    {
        private static List<Profesores> Profesor = new List<Profesores>
        {
          new Profesores {
            ProfesorId = 1,
            Nombre = "Dostin",
            Apellido = "Santana",
            Activo = "Yes",
          },
           new Profesores { 
           ProfesorId = 1,
            Nombre = "Dostin",
            Apellido = "Santana",
            Activo = "Yes",
           }
        };
        public List<Profesores> Get(Profesores Profesor)
        {
            throw new NotImplementedException();
        }

        public List<Profesores> AddProfesor(Profesores Profesor)
        {
            throw new NotImplementedException();
        }

        public List<Profesores> Get()
        {
            throw new NotImplementedException();
        }

        public Profesores Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Profesores> UpdateProfesor(Profesores request)
        {
            var profesor = Profesor.Find(c => c.ProfesorId == request.Id);
            if (profesor == null)
                return null;

            profesor.ProfesorId = request.ProfesorId;
            profesor.Nombre = request.Nombre;   
            profesor.Apellido = request.Apellido;
            profesor.Activo = request.Activo;

            return Profesor;
        }
        List<Profesores> IProfesoresService.Get()
        {
            throw new NotImplementedException();
        }
         List<Profesores> IProfesoresService.Get(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
