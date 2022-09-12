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
    public class Edit3Model : PageModel
    {
 private readonly IRepositorioVisitaDomicilio repositorioVisitaDomicilio;
        [BindProperty]
        public VisitaDomicilio VisitaDomicilio {get;set;}
        
        public Edit3Model(IRepositorioVisitaDomicilio repositorioVisitaDomicilio)
        {
            this.repositorioVisitaDomicilio = repositorioVisitaDomicilio;
            }
                public IActionResult OnGet(int? visitaDomicilioId)
                {
                    if (visitaDomicilioId.HasValue)
                    {
                    VisitaDomicilio= repositorioVisitaDomicilio.GetVisitaDomicilioPorId(visitaDomicilioId.Value);
                    }
                    else
                    {
                        VisitaDomicilio = new VisitaDomicilio();
                    }
                   
                    if(VisitaDomicilio==null)
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
                    if (VisitaDomicilio.Id>0)
                    {
                    VisitaDomicilio = repositorioVisitaDomicilio.Update(VisitaDomicilio);
                    }
                    else
                    {
                        repositorioVisitaDomicilio.Add(VisitaDomicilio);
                    }
                    return Page();
                }
        }
}