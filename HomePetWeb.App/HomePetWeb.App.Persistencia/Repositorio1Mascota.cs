using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomePetWeb.App.Dominio;

namespace HomePetWeb.App.Persistencia.AppRepositorios
{
    public class Repositorio1Mascota : IRepositorio1Mascota
    {
        List<Mascota> mascotas;

        public Repositorio1Mascota()
        {
            mascotas= new List<Mascota>()
            {
                new Mascota{Id=0,Nombre="NOMBRE",FechaNacimiento="FECHA NACIMIENTO",Color="COLOR",Raza="RAZA",EstadoSalud="ESTADO DE SALUD"},
                new Mascota{Id=1,Nombre="Douglas",FechaNacimiento="12/04/2005",Color="Negro",Raza="Labrador",EstadoSalud="Bueno"},
                new Mascota{Id=2,Nombre="Pinina",FechaNacimiento="29/11/2012",Color="Blanco",Raza="French Poodle",EstadoSalud="Regular"},
                new Mascota{Id=3,Nombre="Tigre",FechaNacimiento="16/02/2007",Color="Manchado",Raza="Criollo",EstadoSalud="En Observacion"},
                
            };
        }
        public Mascota Add(Mascota nuevoMascota)
        {
            nuevoMascota.Id=mascotas.Max(r=> r.Id) + 1;
            mascotas.Add(nuevoMascota);
            return nuevoMascota;
        }
        public IEnumerable<Mascota> GetAll()
        {
            return mascotas;
        }
        public Mascota GetMascotaPorId(int mascotaId)
        {
            return mascotas.SingleOrDefault(s=> s.Id==mascotaId);
        }
        public IEnumerable<Mascota> GetMascotaPorFiltro(string filtro=null)
        {
            var mascotas =GetAll();
            if (mascotas != null)
            {
                if (!String.IsNullOrEmpty(filtro))

                {
                  mascotas=mascotas.Where(s=> s.Nombre.Contains(filtro));  
                }
            }
            return mascotas;
        }

        public Mascota Update(Mascota MascotaActualizado)
        {
            var mascota = mascotas.SingleOrDefault(r=> r.Id==MascotaActualizado.Id);
            if (mascota !=null)
            {
                mascota.Nombre = MascotaActualizado.Nombre;
                mascota.FechaNacimiento = MascotaActualizado.FechaNacimiento;
                mascota.Color = MascotaActualizado.Color;
                mascota.Raza = MascotaActualizado.Raza;
                mascota.EstadoSalud = MascotaActualizado.EstadoSalud;
            
            }
            return mascota;
        }

        
    }
}
