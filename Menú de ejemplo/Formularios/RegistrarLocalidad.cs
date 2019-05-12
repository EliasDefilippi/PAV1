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
    public partial class RegistrarLocalidad : Form
    {
        public RegistrarLocalidad()
        {
            InitializeComponent();


        }
        private void buttonConfirmarLocalidad_Click(object sender, EventArgs e)
        {
            String nombreLocalidad = textBoxNombreLocalidad.Text;
           
            int idPais = int.Parse(comboBoxPaises.SelectedValue.ToString());
            insertarLocalidad(nombreLocalidad, idPais);
        }

        private void RegistrarLocalidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'combox_localidad.paises' Puede moverla o quitarla según sea necesario.
            this.paisesTableAdapter.Fill(this.combox_localidad.paises);

        }


        private void insertarLocalidad(String nombre,int idPais)
        {
          
            try
            {

                string insertLocalidad = string.Format("INSERT INTO [LAFAST_gestor_de_reservas].[dbo].[localidades] (nombre_localidad, id_pais) VALUES ('{0}' , {1} );", nombre, idPais);

                MessageBox.Show(insertLocalidad);

                Utilidades.Ejecutar(insertLocalidad);

                MessageBox.Show("Se registro la localidad");

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al insertar la localidad ");
            }
        }

    }
}
