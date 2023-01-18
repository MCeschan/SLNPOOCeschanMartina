using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public class Remolque
    {
        public Remolque(string Nombre, string Modelo)
        {
            this.Nombre = Nombre;
            this.Modelo = Modelo;
        }
        public string Nombre { get; set; }
        public string Modelo { get; set; }

        public Camion Camion { get; set; }
    }
}
