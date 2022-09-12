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
    public class List1Model : PageModel
    {
        //private string[] InfoMascota = {"Nombre", "Fecha de Nacimiento", "Color","Raza","Estado de Salud"};

        //public List<string> ListaMascota {get; set;}
        private readonly IRepositorio1Mascota repositorio1Mascota;
        public IEnumerable<Mascota> Mascotas{get;set;}

        [BindProperty(SupportsGet =true)]
        public string FiltroBusqueda {get;set;}
        
        public List1Model(IRepositorio1Mascota repositorio1Mascota)
        {
            this.repositorio1Mascota=repositorio1Mascota;
        }

        public void OnGet(string filtroBusqueda)
        {
            //ListaMascota = new List<string>();
            //ListaMascota.AddRange(InfoMascota);
            FiltroBusqueda=filtroBusqueda;
            Mascotas=repositorio1Mascota.GetMascotaPorFiltro(filtroBusqueda);
        }
    }
}
