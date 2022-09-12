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
    public class Delete1Model : PageModel
    {
        private readonly IRepositorio1Mascota repositorio1Mascota;
        public Mascota Mascota {get;set;}
        
        public Delete1Model(IRepositorio1Mascota repositorio1Mascota)
        {
            this.repositorio1Mascota = repositorio1Mascota;
            }
                public IActionResult OnGet(int mascotaId)
                {
                    Mascota= repositorio1Mascota.GetMascotaPorId(mascotaId);
                    if(Mascota==null)
                    {
                        return RedirectToPage("./NotFound");
                    }
                    else
                    return Page();
                }
            
        
    }
}
  