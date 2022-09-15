using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEncomiendas
    { 
        
        private readonly AppContext _appContext = new AppContext();   
 
        public IEnumerable<Encomienda> GetAll()
        {
           return _appContext.Encomiendas;
        }
 
        public Encomienda GetWithId(int id){
            return _appContext.Encomiendas.Find(id);
        }
 
        public Encomienda Update(Encomienda newEncomienda){
            var encomienda = _appContext.Encomiendas.Find(newEncomienda.id);
            if(encomienda != null){
                encomienda.descripcion = newEncomienda.descripcion;
                encomienda.peso = newEncomienda.peso;
                encomienda.tipo = newEncomienda.tipo;
                encomienda.presentacion = newEncomienda.presentacion;
                //Guardar en base de datos
                 _appContext.SaveChanges();
            }
        return encomienda;
        }
<<<<<<< HEAD
 
        public Encomienda Create(Encomienda newEncomienda)
        {
           var addEncomienda = _appContext.Encomiendas.Add(newEncomienda);
            //Guardar en base de datos
            _appContext.SaveChanges();
            return addEncomienda.Entity;
        }
 
        public Encomienda Delete(int id)
        {
            var encomienda = _appContext.Encomiendas.Find(id);
        if (encomienda != null){
            _appContext.Encomiendas.Remove(encomienda);
            //Guardar en base de datos
            _appContext.SaveChanges();
        }
         return null;  
        }
 
=======
        public Encomienda Delete(int id)
        {
            var encomienda = encomiendas.SingleOrDefault(e => e.id == id);
            encomiendas.Remove(encomienda);
            return encomienda;
        }
>>>>>>> 8af84f49efcb847559b595e063b7763ed3141392
    }
}