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

            int id_aeropuerto_destino = int.Parse(comboBoxAeropuertoDestino.SelectedValue.ToString());
            int id_aeropuerto_origen = int.Parse(comboBoxAeropuertoOrigen.SelectedValue.ToString());
            int duracion = int.Parse(textBoxDuracionTramo.Text);
            int distancia = int.Parse(tbx_distancia.Text);

            Formularios.SeleccionDeVuelo vueloElegido = new Formularios.SeleccionDeVuelo();
            vueloElegido.propertyId_aeropuerto_destino = id_aeropuerto_destino;
            vueloElegido.propertyId_aeropuerto_origen = id_aeropuerto_origen;
            vueloElegido.propertyDuracion = duracion;
            vueloElegido.propertyDistancia = distancia;

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
