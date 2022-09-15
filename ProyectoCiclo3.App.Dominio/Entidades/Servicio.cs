using System;
namespace ProyectoCiclo3.App.Dominio{
    
    public class Servicio{
        public int id { get; set; }
        public Usuario origen { get; set; }
        public Usuario destino { get; set;}
        public DateTime fecha { get; set;}
        public string hora { get; set; }
        public Encomienda encomienda { get; set; }
    }
}