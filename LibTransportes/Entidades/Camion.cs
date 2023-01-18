using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public class Camion:Vehiculo
    {
        public string MarcaAsociada { get; set; }
        public int Capacidad { get; set; }

        public Camion(string Nombre, string Modelo, string MarcaAsociada, int Capacidad) : base(Nombre, Modelo)
        {
            this.MarcaAsociada = MarcaAsociada;
            this.Capacidad = Capacidad;
        }
        public Remolque Remolque { get; set; }
        public override string Acelerar()
        {
            return "Acelera presionando fuerte";
        }
        public override string Frenar()
        {
            return "Frena presionando fuerte";
        }
        public string QuitarRemolque() 
        {
            Remolque = null;
            return "Se ha quitado el remolque";
        }
    }
}
