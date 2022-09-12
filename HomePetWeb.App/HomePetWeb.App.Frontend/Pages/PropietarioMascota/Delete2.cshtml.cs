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
    public class Delete2Model : PageModel
    {
        private readonly IRepositorioPropietarioMascota repositorioPropietarioMascota;
        public PropietarioMascota PropietarioMascota {get;set;}
        
        public Delete2Model(IRepositorioPropietarioMascota repositorioPropietarioMascota)
        {
            this.repositorioPropietarioMascota = repositorioPropietarioMascota;
            }
                public IActionResult OnGet(int propietarioMascotaId)
                {
                    PropietarioMascota= repositorioPropietarioMascota.GetPropietarioMascotaPorId(propietarioMascotaId);
                    if(PropietarioMascota==null)
                    {
                        return RedirectToPage("./NotFound");
                    }
                    else
                    return Page();
                }
            
        
    }
}
 
