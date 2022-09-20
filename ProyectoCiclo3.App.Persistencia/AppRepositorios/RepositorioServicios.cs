using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioServicios
    { 
        
        private readonly AppContext _appContext = new AppContext();   
 
        public IEnumerable<Servicio> GetAll()
        {
           return _appContext.Servicios.Include(u => u.origen)
                                    .Include(u => u.destino)
                                    .Include(e => e.encomienda);
        }
 
        public Servicio GetWithId(int id){
            return _appContext.Servicios.Find(id);
        }
 
        public Servicio Update(int id, int origen, int destino, string fecha, string hora, int encomienda){
            var servicio = _appContext.Servicios.Find(id);
            if(servicio != null){
                servicio.destino = _appContext.Usuarios.Find(destino);
                servicio.origen = _appContext.Usuarios.Find(origen);  
                servicio.encomienda = _appContext.Encomiendas.Find(encomienda); 
                servicio.fecha = DateTime.Parse(fecha);
                servicio.hora = hora;
                //Guardar en base de datos
                 _appContext.SaveChanges();
            }
        return servicio;
        }
 
        public Servicio Create(int origen, int destino, string fecha, string hora, int encomienda)
        {
            var newServicio = new Servicio();
            newServicio.destino = _appContext.Usuarios.Find(destino);
            newServicio.origen = _appContext.Usuarios.Find(origen);  
            newServicio.encomienda = _appContext.Encomiendas.Find(encomienda);         
            newServicio.fecha = DateTime.Parse(fecha);
            newServicio.hora = hora;
 
           var addServicio = _appContext.Servicios.Add(newServicio);
            //Guardar en base de datos
            _appContext.SaveChanges();
            return addServicio.Entity;
        }
 
        public Servicio Delete(int id)
        {
            var encomienda = _appContext.Servicios.Find(id);
        if (encomienda != null){
            _appContext.Servicios.Remove(encomienda);
            //Guardar en base de datos
            _appContext.SaveChanges();
        }
         return null;  
        }
 
    }
}