using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomePetWeb.App.Dominio;

namespace HomePetWeb.App.Persistencia.AppRepositorios
{
    public class RepositorioPropietarioMascota : IRepositorioPropietarioMascota
    {
        List<PropietarioMascota> propietarioMascotas;

        public RepositorioPropietarioMascota()
        {
            propietarioMascotas= new List<PropietarioMascota>()
            {
                new PropietarioMascota{Id=0,Nombre="NOMBRE",Apellido="APELLIDO",Documento="DOCUMENTO",Direccion="DIRECCION",Telefono="TELEFONO",Ciudad="CIUDAD",Correo="CORREO"},
                new PropietarioMascota{Id=1,Nombre="Karla",Apellido="Calderon",Documento="1028456024",Direccion="Calle 12 # 5-60",Telefono="8153376",Ciudad="Cajica",Correo="Calderon@gmail.com"},
                new PropietarioMascota{Id=2,Nombre="Michael",Apellido="Lopez",Documento="80547682",Direccion="Calle 5 # 3-18",Telefono="8631798",Ciudad="Cota",Correo="Lopez@hotmail.com"},
                new PropietarioMascota{Id=3,Nombre="Duvan",Apellido="Gomez",Documento="215748",Direccion="Carrera 14 # 18-20",Telefono="3105479968",Ciudad="Tabio",Correo="Gomez@yahoo.es"},
                
            };
        }
        public PropietarioMascota Add(PropietarioMascota nuevoPropietarioMascota)
        {
            nuevoPropietarioMascota.Id=propietarioMascotas.Max(r=> r.Id) + 1;
            propietarioMascotas.Add(nuevoPropietarioMascota);
            return nuevoPropietarioMascota;
        }
        public IEnumerable<PropietarioMascota> GetAll()
        {
            return propietarioMascotas;
        }
        public PropietarioMascota GetPropietarioMascotaPorId(int propietarioMascotaId)
        {
            return propietarioMascotas.SingleOrDefault(s=> s.Id==propietarioMascotaId);
        }
        public IEnumerable<PropietarioMascota> GetPropietarioMascotaPorFiltro(string filtro=null)
        {
            var propietarioMascotas =GetAll();
            if (propietarioMascotas != null)
            {
                if (!String.IsNullOrEmpty(filtro))

                {
                  propietarioMascotas=propietarioMascotas.Where(s=> s.Nombre.Contains(filtro));  
                }
            }
            return propietarioMascotas;
        }

        public PropietarioMascota Update(PropietarioMascota PropietarioMascotaActualizado)
        {
            var propietarioMascota = propietarioMascotas.SingleOrDefault(r=> r.Id==PropietarioMascotaActualizado.Id);
            if (propietarioMascota !=null)
            {
                propietarioMascota.Nombre = PropietarioMascotaActualizado.Nombre;
                propietarioMascota.Apellido = PropietarioMascotaActualizado.Apellido;
                propietarioMascota.Documento = PropietarioMascotaActualizado.Documento;
                propietarioMascota.Direccion =PropietarioMascotaActualizado.Direccion;
                propietarioMascota.Telefono = PropietarioMascotaActualizado.Telefono;
                propietarioMascota.Ciudad = PropietarioMascotaActualizado.Ciudad;
                propietarioMascota.Correo = PropietarioMascotaActualizado.Correo;
            
            }
            return propietarioMascota;
        }

        
    }
}
