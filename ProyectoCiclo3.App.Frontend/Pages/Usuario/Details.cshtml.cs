using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
using Microsoft.AspNetCore.Authorization;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
     [Authorize]
    public class DetailsUsuarioModel : PageModel
    {
       private readonly RepositorioUsuarios repositorioUsuarios;
        public Usuario Usuario {get;set;}
 
        public DetailsUsuarioModel(RepositorioUsuarios repositorioUsuarios)
       {
            this.repositorioUsuarios=repositorioUsuarios;
       }
 
        public IActionResult OnGet(int UsuarioId)
        {
                Usuario=repositorioUsuarios.GetWithId(UsuarioId);
                return Page(); 
        }
    }
}

    
