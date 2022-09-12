using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomePetWeb.App.Dominio;

namespace HomePetWeb.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPropietarioMascota
   
    {
        IEnumerable<PropietarioMascota> GetAll();
        IEnumerable<PropietarioMascota> GetPropietarioMascotaPorFiltro(string filtro);
        PropietarioMascota GetPropietarioMascotaPorId(int propietarioMascotaId);
        PropietarioMascota Update(PropietarioMascota PropietarioMascotaActualizado);
        PropietarioMascota Add(PropietarioMascota nuevoPropietarioMascota);
    }
}
