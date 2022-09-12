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
    public class Edit1Model : PageModel
    {
       private readonly IRepositorio1Mascota repositorio1Mascota;
        [BindProperty]
        public Mascota Mascota {get;set;}
        
        public Edit1Model(IRepositorio1Mascota repositorio1Mascota)
        {
            this.repositorio1Mascota = repositorio1Mascota;
            }
                public IActionResult OnGet(int? mascotaId)
                {
                    if (mascotaId.HasValue)
                    {
                    Mascota= repositorio1Mascota.GetMascotaPorId(mascotaId.Value);
                    }
                    else
                    {
                        Mascota = new Mascota();
                    }
                   
                    if(Mascota==null)
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
                    if (Mascota.Id>0)
                    {
                    Mascota = repositorio1Mascota.Update(Mascota);
                    }
                    else
                    {
                        repositorio1Mascota.Add(Mascota);
                    }
                    return Page();
                }
        }
}

