using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public abstract class Vehiculo
    {
        public Vehiculo(string Nombre, string Modelo)
        {
            this.Nombre = Nombre;
            this.Modelo = Modelo;
        }
        public string Nombre { get; set; }
        public string Modelo { get; set; }
        public abstract string Acelerar();
        public abstract string Frenar();


    }
}
