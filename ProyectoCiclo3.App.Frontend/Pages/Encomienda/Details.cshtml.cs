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
    public class DetailsEncomiendaModel : PageModel
    {
       private readonly RepositorioEncomiendas repositorioEncomiendas;
        public Encomienda Encomienda {get;set;}
 
        public DetailsEncomiendaModel(RepositorioEncomiendas repositorioEncomiendas)
       {
            this.repositorioEncomiendas=repositorioEncomiendas;
       }
 
        public IActionResult OnGet(int encomiendaId)
        {
                Encomienda=repositorioEncomiendas.GetWithId(encomiendaId);
                return Page(); 
        }
    }
}