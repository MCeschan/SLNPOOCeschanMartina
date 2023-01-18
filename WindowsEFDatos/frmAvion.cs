using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFDatos.Dac;
using WindowsEFDatos.Modelos;

namespace WindowsEFDatos
{
    public partial class frmAvion : Form
    {
        public frmAvion()
        {
            InitializeComponent();
        }

        private void frmAvion_Load(object sender, EventArgs e)
        {
            MostrarTodosLosAviones();
        }

        private void MostrarTodosLosAviones()
        {
            GridAviones.DataSource = AbmAvion.SelectAll();
        }

        private void btnInsertar_Click(object sender, EventArgs e)

        {
            LineaAerea linea = new LineaAerea() { Nombre = "Aerolineas Argentinas", FechaInicioActividades = new DateTime(1998, 02, 10) };
            Avion avion = new Avion() {  Denominación = "Flaubery", Capacidad = 100, LineaAerea = linea };
      
            int filasAfectadas = AbmAvion.Insert(avion);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Avión insertado correctamente");
                MostrarTodosLosAviones();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion() { Denominación = txtDenom.Text, IdAvion = Convert.ToInt32(txtID.Text) };
            int filasAfectadas = AbmAvion.Delete(avion);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Se eliminó correctamente");
                MostrarTodosLosAviones();

            }

        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);

            Avion avion = AbmAvion.SelectWhereById(id);
            MessageBox.Show(avion.Denominación);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion() { Denominación = txtDenom.Text, IdAvion = Convert.ToInt32(txtID.Text) };

            int filasAfectadas = AbmAvion.Update(avion);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Se pudo modificar con éxito");
                MostrarTodosLosAviones();

            }
        }
    }
}
