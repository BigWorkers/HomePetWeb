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
    public class ListModel : PageModel
    {
        //private string[] InfoVeterinario = {"Nombre", "Apellido", "Telefono","Tarjeta Profesional"};

        //public List<string> ListaVeterinario {get; set;}
        private readonly IRepositorioVeterinario repositorioVeterinario;
        public IEnumerable<Veterinario> Veterinarios{get;set;}

        [BindProperty(SupportsGet =true)]
        public string FiltroBusqueda {get;set;}
        
        public ListModel(IRepositorioVeterinario repositorioVeterinario)
        {
            this.repositorioVeterinario=repositorioVeterinario;
        }

        public void OnGet(string filtroBusqueda)
        {
            //ListaVeterinario = new List<string>();
            //ListaVeterinario.AddRange(InfoVeterinario);
            FiltroBusqueda=filtroBusqueda;
            Veterinarios=repositorioVeterinario.GetVeterinarioPorFiltro(filtroBusqueda);
        }
    }
}
