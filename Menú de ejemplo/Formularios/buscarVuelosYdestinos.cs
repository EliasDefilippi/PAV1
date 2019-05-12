using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menú_de_ejemplo
{
    public partial class buscarVuelosYdestinos : Form
    {
        public buscarVuelosYdestinos()
        {
            InitializeComponent();
           
            //SelectedValue("id_aeropuerto");

        }

        private void botonCerrarVuelosDestinos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {//SelectionChangeCommitted

            if (comboBoxOrigen.SelectedValue.Equals
                (comboBoxDestino.SelectedValue))
            {
                MessageBox.Show("No se puede seleccionar una pais del mismo origen que destino");
                comboBoxDestino.SelectedValue = 0;
            }
        }

        private void buscarVuelosYdestinos_Load(object sender, EventArgs e)
        {
           // TODO: esta línea de código carga datos en la tabla 'localidades2.localidades' Puede moverla o quitarla según sea necesario.
            this.localidadesTableAdapter1.Fill(this.localidades2.localidades);
            // TODO: esta línea de código carga datos en la tabla 'combox_localidad.categoria_pasajero' Puede moverla o quitarla según sea necesario.

            comboBoxOrigen.SelectedValue = 0;
            comboBoxDestino.SelectedValue = 2;
            this.categoria_pasajeroTableAdapter.Fill(this.combox_localidad.categoria_pasajero);
            // TODO: esta línea de código carga datos en la tabla 'combox_localidad.localidades' Puede moverla o quitarla según sea necesario.
            this.localidadesTableAdapter.Fill(this.combox_localidad.localidades);
          

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
