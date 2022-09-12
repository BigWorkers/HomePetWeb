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
    public class DeleteModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario;
        public Veterinario Veterinario {get;set;}
        
        public DeleteModel(IRepositorioVeterinario repositorioVeterinario)
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
  