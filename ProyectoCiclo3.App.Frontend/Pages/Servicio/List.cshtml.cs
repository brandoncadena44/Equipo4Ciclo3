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
    public class ListServicioModel : PageModel
    {
       
        private readonly RepositorioServicios repositorioServicio;
        [BindProperty]
        public Servicio Servicio {get;set;}
        public IEnumerable<Servicio> Servicios {get;set;}
 
    public ListServicioModel(RepositorioServicios repositorioServicio)
    {
        this.repositorioServicio=repositorioServicio;
     }
 
    public void OnGet()
    {
        Servicios=repositorioServicio.GetAll();
    }
    public IActionResult OnPost()
    {
        if(Servicio.id>0)
        {
        repositorioServicio.Delete(Servicio.id);
        }
        return RedirectToPage("./List");
    }

    }
}