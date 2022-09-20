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
    public class DetailsServicioModel : PageModel
    {
       private readonly RepositorioServicios repositorioServicios;
        public Servicio Servicio {get;set;}
 
        public DetailsServicioModel(RepositorioServicios repositorioServicios)
       {
            this.repositorioServicios=repositorioServicios;
       }
 
        public IActionResult OnGet(int servicioId)
        {
            Servicio=repositorioServicios.GetWithId(servicioId);
            return Page(); 
        }
    }
}