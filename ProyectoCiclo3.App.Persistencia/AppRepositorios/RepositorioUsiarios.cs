using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuarios
    {
        List<Usuario> usuarios;
 
    public RepositorioUsuarios()
        {
            usuarios= new List<Usuario>()
            {
                new Usuario{id=1,nombre ="Armando",apellidos= "Salinas",direccion= "calle 200",telefono= "7113703"},
                new Usuario{id=2,nombre ="Clemencia",apellidos= "Rodriguez",direccion= "calle 63 sur",telefono= "32145654"},
                new Usuario{id=3,nombre ="Dionicio",apellidos= "Rangel",direccion= "cra 36 norte",telefono= "23456897"}
            };
        }
 
        public IEnumerable<Usuario> GetAll()
        {
            return usuarios;
        }
 
        public Usuario GetWithId(int id){
            return usuarios.SingleOrDefault(e => e.id == id);
        }
        public Usuario Update(Usuario newUsuario){
            var usuario= usuarios.SingleOrDefault(e => e.id == newUsuario.id);
            if(usuario!= null){
                usuario.nombre = newUsuario.nombre;
                usuario.apellidos = newUsuario.apellidos;
                usuario.direccion = newUsuario.direccion;
                usuario.telefono = newUsuario.telefono;
            }
            
        return usuario;
        }
    
    }
}