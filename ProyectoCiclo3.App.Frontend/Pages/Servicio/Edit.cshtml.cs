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
    public class EditServicioModel : PageModel
    {
        
        private readonly RepositorioServicios repositorioServicio;
        private readonly RepositorioUsuarios repositorioUsuario;
        private readonly RepositorioEncomiendas repositorioEncomienda;
        public IEnumerable<Usuario> Usuarios {get;set;}
        public IEnumerable<Encomienda> Encomiendas {get;set;}       
        [BindProperty]
        public Servicio Servicio {get;set;}
 
        public EditServicioModel(RepositorioServicios repositorioServicio, RepositorioUsuarios repositorioUsuario, RepositorioEncomiendas repositorioEncomienda)
       {
            this.repositorioServicio=repositorioServicio;
            this.repositorioUsuario=repositorioUsuario;
            this.repositorioEncomienda=repositorioEncomienda;
       }
 
        public IActionResult OnGet(int servicioId)
        {
            Servicio=repositorioServicio.GetWithId(servicioId);
            Usuarios=repositorioUsuario.GetAll();
            Encomiendas=repositorioEncomienda.GetAll();
            return Page(); 
        }

        public IActionResult OnPost(int id, int origen, int destino, string fecha, string hora, int encomienda)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            Servicio = repositorioServicio.Update(id, origen, destino, fecha, hora, encomienda);            
            return RedirectToPage("./List");
        }

    }
}