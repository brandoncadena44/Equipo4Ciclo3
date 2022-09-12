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
    public class FormServicioModel : PageModel
    {
       private readonly RepositorioServicios repositorioServicios;
        [BindProperty]
        public Servicio Servicio {get;set;}
 
        public FormServicioModel(RepositorioServicios repositorioServicios)
       {
            this.repositorioServicios=repositorioServicios;
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
            repositorioServicios.Create(Servicio);            
            return RedirectToPage("./List");
        }
    }

}