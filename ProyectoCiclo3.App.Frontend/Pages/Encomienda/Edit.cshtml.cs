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
    public class EditEncomiendaModel : PageModel
    {
       private readonly RepositorioEncomiendas repositorioEncomiendas;
       [BindProperty]
        public Encomienda Encomienda {get;set;}
 
        public EditEncomiendaModel(RepositorioEncomiendas repositorioEncomiendas)
       {
            this.repositorioEncomiendas=repositorioEncomiendas;
       }
 
        public IActionResult OnGet(int encomiendaId)
        {
            Encomienda=repositorioEncomiendas.GetWithId(encomiendaId);
            return Page(); 
        }
 
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Encomienda.id>0)
            {
             Encomienda = repositorioEncomiendas.Update(Encomienda);
            }
            return RedirectToPage("./List");
        }
 
    }
}