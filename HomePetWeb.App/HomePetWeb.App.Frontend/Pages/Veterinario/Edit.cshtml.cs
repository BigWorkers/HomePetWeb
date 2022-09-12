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
    public class EditModel : PageModel
    {
       private readonly IRepositorioVeterinario repositorioVeterinario;
        [BindProperty]
        public Veterinario Veterinario {get;set;}
        
        public EditModel(IRepositorioVeterinario repositorioVeterinario)
        {
            this.repositorioVeterinario = repositorioVeterinario;
            }
                public IActionResult OnGet(int? veterinarioId)
                {
                    if (veterinarioId.HasValue)
                    {
                    Veterinario= repositorioVeterinario.GetVeterinarioPorId(veterinarioId.Value);
                    }
                    else
                    {
                        Veterinario = new Veterinario();
                    }
                   
                    if(Veterinario==null)
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
                    if (Veterinario.Id>0)
                    {
                    Veterinario = repositorioVeterinario.Update(Veterinario);
                    }
                    else
                    {
                        repositorioVeterinario.Add(Veterinario);
                    }
                    return Page();
                }
        }
}

