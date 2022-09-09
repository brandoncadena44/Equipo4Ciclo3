using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioServicios
    {
        List<Servicio> servicios;
 
    public RepositorioServicios()
        {
            servicios= new List<Servicio>()
            {
                new Servicio{id=1,origen="Tunja",destino= "Bogota",fecha= "02/10/2022",hora= "11:00",encomienda= "Caja"},
                new Servicio{id=2,origen="Raquira",destino= "Bogota",fecha= "03/10/2022",hora= "12:00",encomienda= "Caja"},
                new Servicio{id=3,origen="Villa de Leiva",destino= "Bogota",fecha= "11/10/2022",hora= "12:10",encomienda= "Caja"}
                
            };
        }
 
        public IEnumerable<Servicio> GetAll()
        {
            return servicios;
        }
 
        public Servicio GetWithId(int id){
            return servicios.SingleOrDefault(e => e.id == id);
        }
        public Servicio Update(Servicio newServicio){
            var servicio= servicios.SingleOrDefault(e => e.id == newServicio.id);
            if(servicio!= null){
                servicio.origen = newServicio.origen;
                servicio.destino = newServicio.destino;
                servicio.fecha = newServicio.fecha;
                servicio.hora = newServicio.hora;
                servicio.encomienda = newServicio.encomienda;
            }
            
        return servicio;
        }
    }
}