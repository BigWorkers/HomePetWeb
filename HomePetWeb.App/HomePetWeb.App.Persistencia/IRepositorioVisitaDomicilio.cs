using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomePetWeb.App.Dominio;


namespace HomePetWeb.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVisitaDomicilio
   
    {
        IEnumerable<VisitaDomicilio> GetAll();
        IEnumerable<VisitaDomicilio> GetVisitaDomicilioPorFiltro(string filtro);
        VisitaDomicilio GetVisitaDomicilioPorId(int visitaDomicilioId);
        VisitaDomicilio Update(VisitaDomicilio VisitaDomicilioActualizado);
        VisitaDomicilio Add(VisitaDomicilio nuevoVisitaDomicilio);
    }
}
