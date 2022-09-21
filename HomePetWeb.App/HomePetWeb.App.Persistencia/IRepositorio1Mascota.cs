using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomePetWeb.App.Dominio;

namespace HomePetWeb.App.Persistencia.AppRepositorios
{
    public interface IRepositorio1Mascota
   
    {
        IEnumerable<Mascota> GetAll();
        IEnumerable<Mascota> GetMascotaPorFiltro(string filtro);
        Mascota GetMascotaPorId(int mascotaId);
        Mascota Update(Mascota MascotaActualizado);
        void DeleteMascota(int idMascota);
        Mascota Add(Mascota nuevoMascota);
    }
}
