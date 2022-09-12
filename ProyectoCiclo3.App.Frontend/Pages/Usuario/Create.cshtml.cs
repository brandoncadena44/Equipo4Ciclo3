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
    public class FormUsuarioModel : PageModel
    {
       private readonly RepositorioUsuarios repositorioUsuarios;
        [BindProperty]
        public Usuario Usuario {get;set;}
 
        public FormUsuarioModel(RepositorioUsuarios repositorioUsuarios)
       {
            this.repositorioUsuarios=repositorioUsuarios;
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
            repositorioUsuarios.Create(Usuario);            
            return RedirectToPage("./List");
        }
    }

}