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
    public class List2Model : PageModel
    {
        //private string[] InfoPropietarioMascota = {"Nombre", "Apellido", "Telefono","Tarjeta Profesional"};

        //public List<string> ListaPropietarioMascota {get; set;}
        private readonly IRepositorioPropietarioMascota repositorioPropietarioMascota;
        public IEnumerable<PropietarioMascota> PropietarioMascotas{get;set;}

        [BindProperty(SupportsGet =true)]
        public string FiltroBusqueda {get;set;}
        
        public List2Model(IRepositorioPropietarioMascota repositorioPropietarioMascota)
        {
            this.repositorioPropietarioMascota=repositorioPropietarioMascota;
        }

        public void OnGet(string filtroBusqueda)
        {
            //ListaPropietarioMascota = new List<string>();
            //ListaPropietarioMascota.AddRange(InfoPropietarioMascota);
            FiltroBusqueda=filtroBusqueda;
            PropietarioMascotas=repositorioPropietarioMascota.GetPropietarioMascotaPorFiltro(filtroBusqueda);
        }
    }
}
