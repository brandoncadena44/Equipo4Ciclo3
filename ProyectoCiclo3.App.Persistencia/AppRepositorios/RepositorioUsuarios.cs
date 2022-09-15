using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuarios
    { 
        
        private readonly AppContext _appContext = new AppContext();   

        public IEnumerable<Usuario> GetAll()
        {
           return _appContext.Usuarios;
        }
 
        public Usuario GetWithId(int id){
            return _appContext.Usuarios.Find(id);
        }

        public Usuario Update(Usuario newUsuario){
            var usuario = _appContext.Usuarios.Find(newUsuario.id);
            if(usuario != null){
                usuario.nombre = newUsuario.nombre;
                usuario.apellidos = newUsuario.apellidos;
                usuario.direccion = newUsuario.direccion;
                usuario.telefono = newUsuario.telefono;
                //Guardar en base de datos
                 _appContext.SaveChanges();
            }
        return usuario;
        }

        public Usuario Create(Usuario newUsuario)
        {
           var addUsuario = _appContext.Usuarios.Add(newUsuario);
            //Guardar en base de datos
            _appContext.SaveChanges();
            return addUsuario.Entity;
        }

        public Usuario Delete(int id)
        {
            var usuario = _appContext.Usuarios.Find(id);
        if (usuario != null){
            _appContext.Usuarios.Remove(usuario);
            //Guardar en base de datos
            _appContext.SaveChanges();
        }
         return null;  
        }

    }
}