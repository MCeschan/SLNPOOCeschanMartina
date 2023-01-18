using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Data;
using WindowsEFDatos.Modelos;

namespace WindowsEFDatos.Dac
{
    public static class AbmAvion
    {
        private static DBLineaAereaContext context = new DBLineaAereaContext();

        public static List<Avion> SelectAll() 
        {
            return context.Aviones.ToList();
        }
        public static int Insert(Avion avion) 
        {
            context.Aviones.Add(avion);
            return context.SaveChanges();
        }
        public static Avion SelectWhereById(int id)
        {
            return context.Aviones.Find(id);

        }
        public static int Update(Avion avion)
        {
            Avion avionOrigen = context.Aviones.Find(avion.IdAvion);
            avionOrigen.Capacidad = avion.Capacidad;
            avionOrigen.Denominación = avion.Denominación;
            avionOrigen.LineaId = avion.LineaId;

            return context.SaveChanges();
        }


        public static int Delete(Avion avion)
        {
            Avion avionOrigen = context.Aviones.Find(avion.IdAvion);
            if (avionOrigen != null)
            {
                context.Aviones.Remove(avionOrigen);
                return context.SaveChanges();
            }
            return 0;
        }
    }
}
