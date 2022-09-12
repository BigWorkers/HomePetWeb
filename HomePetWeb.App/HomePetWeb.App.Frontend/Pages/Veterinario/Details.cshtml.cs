using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomePetWeb.App.Dominio;
using HomePetWeb.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomePetWeb.App.Frontend.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario;
        public Veterinario Veterinario {get;set;}
        
        public DetailsModel(IRepositorioVeterinario repositorioVeterinario)
        {
            this.repositorioVeterinario = repositorioVeterinario;
            }
                public IActionResult OnGet(int veterinarioId)
                {
                    Veterinario= repositorioVeterinario.GetVeterinarioPorId(veterinarioId);
                    if(Veterinario==null)
                    {
                        return RedirectToPage("./NotFound");
                    }
                    else
                    return Page();
                }
            
        
    }
}
  