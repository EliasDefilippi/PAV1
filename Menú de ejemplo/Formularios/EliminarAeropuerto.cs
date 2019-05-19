using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mi_Liberia_LF;

namespace Menú_de_ejemplo.Formularios
{
    public partial class EliminarAeropuerto : Form
    {
        public EliminarAeropuerto()
        {
            InitializeComponent();
        }

        private void EliminarAeropuerto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lAFAST_gestor_de_reservas.aeropuertos' Puede moverla o quitarla según sea necesario.
            this.aeropuertosTableAdapter.Fill(this.lAFAST_gestor_de_reservas.aeropuertos);

        }

        private void buttonConfirmarElimAero_Click(object sender, EventArgs e)
        {
            string aeropuerto = comboBoxElimAero.Text.Trim();
            deleteAirport(aeropuerto);
        }

        public void deleteAirport(string aeropuerto)
        {
            try
            {
                string eliminarAeropuerto = string.Format("EXEC EliminarAeropuerto '{0}'", aeropuerto);

                Utilidades.Ejecutar(eliminarAeropuerto);
                MessageBox.Show("Se eliminó el aeropuerto seleccionado exitosamente.");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar el aeropuerto seleccionado. Intente nuevamente más tarde.");

                
            }
        }

        private void buttonCancelarElimAero_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
