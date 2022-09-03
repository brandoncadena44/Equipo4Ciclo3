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
 
        public ListEncomiendaModel(RepositorioEncomiendas repositorioEncomiendas)
        {
            this.repositorioEncomiendas=repositorioEncomiendas;
        }
 
        public void OnGet()
        {
            Encomiendas=repositorioEncomiendas.GetAll();
        }
    }
}