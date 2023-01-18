using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public class AutoElectrico:Vehiculo
    {
        public float CantidadKW { get; set; }
        public string Color { get; set; }
        public AutoElectrico(string Nombre, string Modelo, float CantidadKW, string Color) : base(Nombre, Modelo)
        {
            this.CantidadKW = CantidadKW;
            this.Color = Color;
        }
        public override string Acelerar()
        {
            return "Acelera rápido";
        }
        public override string Frenar()
        {
            return "Frena rápido";
        }
    }
}
