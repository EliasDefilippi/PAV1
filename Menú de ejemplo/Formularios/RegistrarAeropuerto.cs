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
    public partial class RegistrarAeropuerto : Form
    {
        public RegistrarAeropuerto()
        {
            InitializeComponent();
        }

        private void linkLabelRegistrarLocalidad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Formularios.RegistrarLocalidad newCity = new Formularios.RegistrarLocalidad();
            newCity.Show();
            this.Close();
           
        }

        private void buttonConfirmarRegistroAeropuerto_Click(object sender, EventArgs e)
        {
            String nombreAeropuerto = textBoxNombreAeropuerto.Text;

            int idPais = int.Parse(comboBoxLocalidad.SelectedValue.ToString());

            insertarAeropuerto(nombreAeropuerto, idPais);

        }


        private void insertarAeropuerto(String nombre, int idPais)
        {
            try
            {

                string insertLocalidad = string.Format("INSERT INTO [LAFAST_gestor_de_reservas].[dbo].[aeropuertos] (nombre_aeropuerto, id_localidad_aeropuerto) VALUES ('{0}' , {1} );", nombre, idPais);

                Utilidades.Ejecutar(insertLocalidad);

                MessageBox.Show("Se registro nuevo aeropuerto");

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al insertar aeropuerto ");
            }
        }




        private void RegistrarAeropuerto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'combox_localidad.localidades' Puede moverla o quitarla según sea necesario.
            this.localidadesTableAdapter.Fill(this.combox_localidad.localidades);

        }
    }
}
