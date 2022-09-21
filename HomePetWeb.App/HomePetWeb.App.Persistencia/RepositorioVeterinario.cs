using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomePetWeb.App.Dominio;

namespace HomePetWeb.App.Persistencia.AppRepositorios
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {
        List<Veterinario> veterinarios;

        public RepositorioVeterinario()
        {
            veterinarios= new List<Veterinario>()
            {
                new Veterinario{Id=0,Nombre="Mayrin",Apellido="Henao Gomez",Telefono="3113111111",TarjetaProfesional="2345"},
                new Veterinario{Id=1,Nombre="Maria Andrea",Apellido="Sanchez",Telefono="3102145687",TarjetaProfesional="3461"},
                new Veterinario{Id=2,Nombre="Camilo",Apellido="Isaza",Telefono="30054757452",TarjetaProfesional="8547"},
                new Veterinario{Id=3,Nombre="Maria Fernanda",Apellido="Lopez",Telefono="3208547961",TarjetaProfesional="2647"},
                
            };
        }
        public Veterinario Add(Veterinario nuevoVeterinario)
        {
            nuevoVeterinario.Id=veterinarios.Max(r=> r.Id) + 1;
            veterinarios.Add(nuevoVeterinario);
            return nuevoVeterinario;
        }
        public IEnumerable<Veterinario> GetAll()
        {
            return veterinarios;
        }
        public Veterinario GetVeterinarioPorId(int veterinarioId)
        {
            return veterinarios.SingleOrDefault(s=> s.Id==veterinarioId);
        }
        public IEnumerable<Veterinario> GetVeterinarioPorFiltro(string filtro=null)
        {
            var veterinarios =GetAll();
            if (veterinarios != null)
            {
                if (!String.IsNullOrEmpty(filtro))

                {
                  veterinarios=veterinarios.Where(s=> s.Nombre.Contains(filtro));  
                }
            }
            return veterinarios;
        }

        public Veterinario Update(Veterinario VeterinarioActualizado)
        {
            var veterinario = veterinarios.SingleOrDefault(r=> r.Id==VeterinarioActualizado.Id);
            if (veterinario !=null)
            {
                veterinario.Nombre = VeterinarioActualizado.Nombre;
                veterinario.Apellido = VeterinarioActualizado.Apellido;
                veterinario.Telefono = VeterinarioActualizado.Telefono;
                veterinario.TarjetaProfesional = VeterinarioActualizado.TarjetaProfesional;
            
            }
            return veterinario;
        }

        
    }
}
