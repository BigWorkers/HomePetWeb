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
    public class Details3Model : PageModel
    {
        private readonly IRepositorioVisitaDomicilio repositorioVisitaDomicilio;
        public VisitaDomicilio VisitaDomicilio {get;set;}
        
        public Details3Model(IRepositorioVisitaDomicilio repositorioVisitaDomicilio)
        {
            this.repositorioVisitaDomicilio = repositorioVisitaDomicilio;
            }
                public IActionResult OnGet(int visitaDomicilioId)
                {
                    VisitaDomicilio= repositorioVisitaDomicilio.GetVisitaDomicilioPorId(visitaDomicilioId);
                    if(VisitaDomicilio==null)
                    {
                        return RedirectToPage("./NotFound");
                    }
                    else
                    return Page();
                }
            
        
    }
}