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
    public class EditUsuarioModel : PageModel
    {
       private readonly RepositorioUsuarios repositorioUsuarios;
       [BindProperty]
        public Usuario Usuario {get;set;}
 
        public EditUsuarioModel(RepositorioUsuarios repositorioUsuarios)
       {
            this.repositorioUsuarios=repositorioUsuarios;
       }
 
        public IActionResult OnGet(int usuarioId)
        {
            Usuario=repositorioUsuarios.GetWithId(usuarioId);
            return Page(); 
        }
 
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Usuario.id>0)
            {
             Usuario = repositorioUsuarios.Update(Usuario);
            }
            return RedirectToPage("./List");
        }
 
    }
}