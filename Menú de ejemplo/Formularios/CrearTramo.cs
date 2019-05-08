using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menú_de_ejemplo.Formularios
{
    public partial class CrearTramo : Form
    {
        public CrearTramo()
        {
            InitializeComponent();
        }

        private void buttonAsignarVuelo_Click(object sender, EventArgs e)
        {
            Formularios.SeleccionDeVuelo vueloElegido = new Formularios.SeleccionDeVuelo();
            this.Close();
            vueloElegido.Show();
        }

        private void CrearTramo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aeropuertosDetinos.aeropuertos' Puede moverla o quitarla según sea necesario.
            this.aeropuertosTableAdapter1.Fill(this.aeropuertosDetinos.aeropuertos);
            // TODO: esta línea de código carga datos en la tabla 'aeropuertos._aeropuertos' Puede moverla o quitarla según sea necesario.
            this.aeropuertosTableAdapter.Fill(this.aeropuertos._aeropuertos);

        }
    }
}
