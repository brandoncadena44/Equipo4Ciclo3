using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class FormEncomiendaModel : PageModel
    {
       private readonly RepositorioEncomiendas repositorioEncomiendas;
        [BindProperty]
        public Encomienda Encomienda {get;set;}
 
        public FormEncomiendaModel(RepositorioEncomiendas repositorioEncomiendas)
       {
            this.repositorioEncomiendas=repositorioEncomiendas;
       }
 
        public void OnGet()
        {
 
        }
 
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }            
            repositorioEncomiendas.Create(Encomienda);            
            return RedirectToPage("./List");
        }
    }
 
}