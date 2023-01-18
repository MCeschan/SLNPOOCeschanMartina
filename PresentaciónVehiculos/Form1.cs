using LibTransportes.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentaciónVehiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCamion_Click(object sender, EventArgs e)
        {
            Camion camion = new Camion("Pauny", "AA23", "Sancor", 25634);
            MessageBox.Show("El nuevo camión que has creado es " + camion.Nombre + ", su modelo es " + camion.Modelo + ". La marca asociada es " + camion.MarcaAsociada + " y su capacidad es de " + camion.Capacidad);
            MessageBox.Show(camion.Acelerar());
            MessageBox.Show(camion.Frenar());
            MessageBox.Show(camion.QuitarRemolque());
        }

        private void btnRemolque_Click(object sender, EventArgs e)
        {
            Remolque remolque = new Remolque("Ajax", "AA78");
            MessageBox.Show("El nuevo remolque que has creado es " + remolque.Nombre + " y su modelo es " + remolque.Modelo);

        }
    }
}
