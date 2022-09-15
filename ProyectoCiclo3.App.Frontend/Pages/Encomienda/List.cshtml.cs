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
    public class ListEncomiendaModel : PageModel
    {
        
        private readonly RepositorioEncomiendas repositorioEncomiendas;
        public IEnumerable<Encomienda> Encomiendas {get;set;}
        [BindProperty]
        public Encomienda Encomienda {get;set;}
<<<<<<< HEAD
=======
 
>>>>>>> 8af84f49efcb847559b595e063b7763ed3141392
        public ListEncomiendaModel(RepositorioEncomiendas repositorioEncomiendas)
        {
            this.repositorioEncomiendas=repositorioEncomiendas;
        }

        public void OnGet()
        {
            Encomiendas=repositorioEncomiendas.GetAll();
        }
<<<<<<< HEAD
=======

>>>>>>> 8af84f49efcb847559b595e063b7763ed3141392
        public IActionResult OnPost()
        {
            if(Encomienda.id>0)
            {
                repositorioEncomiendas.Delete(Encomienda.id);
            }
            return RedirectToPage("./List");
        }
<<<<<<< HEAD
=======

>>>>>>> 8af84f49efcb847559b595e063b7763ed3141392
    }
}