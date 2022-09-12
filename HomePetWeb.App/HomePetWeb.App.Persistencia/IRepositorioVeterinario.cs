using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomePetWeb.App.Dominio;


namespace HomePetWeb.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVeterinario
   
    {
        IEnumerable<Veterinario> GetAll();
        IEnumerable<Veterinario> GetVeterinarioPorFiltro(string filtro);
        Veterinario GetVeterinarioPorId(int veterinarioId);
        Veterinario Update(Veterinario VeterinarioActualizado);
        Veterinario Add(Veterinario nuevoVeterinario);
    }
}
