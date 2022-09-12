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
    public class Edit2Model : PageModel
    {
        private readonly IRepositorioPropietarioMascota repositorioPropietarioMascota;
        [BindProperty]
        public PropietarioMascota PropietarioMascota {get;set;}
        
        public Edit2Model(IRepositorioPropietarioMascota repositorioPropietarioMascota)
        {
            this.repositorioPropietarioMascota = repositorioPropietarioMascota;
            }
                public IActionResult OnGet(int? propietarioMascotaId)
                {
                    if (propietarioMascotaId.HasValue)
                    {
                    PropietarioMascota= repositorioPropietarioMascota.GetPropietarioMascotaPorId(propietarioMascotaId.Value);
                    }
                    else
                    {
                        PropietarioMascota = new PropietarioMascota();
                    }
                   
                    if(PropietarioMascota==null)
                    {
                        return RedirectToPage("./NotFound");
                    }
                    else
                    return Page();
                }
                public IActionResult OnPost()
                {
                    if(!ModelState.IsValid)
                    {
                        return Page();
                    }
                    if (PropietarioMascota.Id>0)
                    {
                    PropietarioMascota = repositorioPropietarioMascota.Update(PropietarioMascota);
                    }
                    else
                    {
                        repositorioPropietarioMascota.Add(PropietarioMascota);
                    }
                    return Page();
                }
        }
}
