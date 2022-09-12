using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HomePetWeb.App.Dominio;
using HomePetWeb.App.Persistencia.AppRepositorios;

namespace HomePetWeb.App.Frontend.Pages
{
    public class List3Model : PageModel
    {
  //private string[] InfoVisitaDomicilio = {"Nombre", "Apellido", "Telefono","Tarjeta Profesional"};

        //public List<string> ListaVisitaDomicilio {get; set;}
        private readonly IRepositorioVisitaDomicilio repositorioVisitaDomicilio;
        public IEnumerable<VisitaDomicilio> VisitaDomicilio{get;set;}

        [BindProperty(SupportsGet =true)]
        public string FiltroBusqueda {get;set;}
        
        public List3Model(IRepositorioVisitaDomicilio repositorioVisitaDomicilio)
        {
            this.repositorioVisitaDomicilio=repositorioVisitaDomicilio;
        }

        public void OnGet(string filtroBusqueda)
        {
            //ListaVisitaDomicilio = new List<string>();
            //ListaVisitaDomicilio.AddRange(InfoVisitaDomicilio);
            FiltroBusqueda=filtroBusqueda;
            VisitaDomicilio=repositorioVisitaDomicilio.GetVisitaDomicilioPorFiltro(filtroBusqueda);
        }
    }
}
