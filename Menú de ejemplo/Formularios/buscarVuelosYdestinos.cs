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

namespace Menú_de_ejemplo
{
    public partial class buscarVuelosYdestinos : Form
    {
        public buscarVuelosYdestinos()
        {
            InitializeComponent();

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
                MessageBox.Show("No se puede seleccionar un pais del mismo origen que destino");
                comboBoxDestino.SelectedValue = 0;
            }
        }

        private void buscarVuelosYdestinos_Load(object sender, EventArgs e)
        {
           // TODO: esta línea de código carga datos en la tabla 'localidades2.localidades' Puede moverla o quitarla según sea necesario.
            this.localidadesTableAdapter1.Fill(this.localidades2.localidades);
            // TODO: esta línea de código carga datos en la tabla 'combox_localidad.categoria_pasajero' Puede moverla o quitarla según sea necesario.
            comboBoxAdultos.SelectedIndex = 0;
            comboBoxOrigen.SelectedValue = 0;
            comboBoxDestino.SelectedValue = 2;
            this.categoria_pasajeroTableAdapter.Fill(this.combox_localidad.categoria_pasajero);
            // TODO: esta línea de código carga datos en la tabla 'combox_localidad.localidades' Puede moverla o quitarla según sea necesario.
            this.localidadesTableAdapter.Fill(this.combox_localidad.localidades);
          

        }

        private void botonBuscarVuelos_Click(object sender, EventArgs e)
        {


            Formularios.formVuelosIdaVueltaDisponibles vuelosDisponibles = new Formularios.formVuelosIdaVueltaDisponibles();
            vuelosDisponibles.Show();
            /*String vuelos = String.Format("SELECT vuelos.id_vuelo ,vuelos.nro_vuelo ,vuelos.id_avion ,vuelos.fecha_salida_vuelo ,tarifas.clase_tarifa, tarifas.precio_tarifa FROM[LAFAST_gestor_de_reservas].[dbo].[vuelos] join[LAFAST_gestor_de_reservas].[dbo].[tramos] on vuelos.id_vuelo=tramos.id_vuelo join [LAFAST_gestor_de_reservas].[dbo].[tarifas] on vuelos.id_tarifa_vuelo= tarifas.id_tarifa where tramos.id_aeropuerto_destino ={1} and tramos.id_aeropuerto_origen ={0} and vuelos.fecha_salida_vuelo ='{2}';",comboBoxOrigen.SelectedValue,comboBoxDestino.SelectedValue, dateTimeIDA.Value.ToString("yyyy-MM-dd"));

            int origen = int.Parse(comboBoxOrigen.SelectedValue.ToString());
            int destino = int.Parse(comboBoxDestino.SelectedValue.ToString());

            DataSet dt = Utilidades.Ejecutar(vuelos);

            DataTable customerTable = dt.Tables["Table"];
            for (int i = 0; i < customerTable.Rows.Count; i++)
            {
                String s = dt.Tables["Table"].Rows[i]["id_vuelo"].ToString();

                MessageBox.Show(s);

            }*/
        }



            Formularios.formVuelosIdaVueltaDisponibles vuelosDisponibles = new Formularios.formVuelosIdaVueltaDisponibles(dateTimeIDA.Value, int.Parse(comboBoxOrigen.SelectedValue.ToString()), int.Parse(comboBoxDestino.SelectedValue.ToString()), dateTimeVUELTA.Value, checkBoxIda.Checked);


        Formularios.formVuelosIdaVueltaDisponibles vuelosDisponibles = new Formularios.formVuelosIdaVueltaDisponibles(dateTimeIDA.Value, int.Parse(comboBoxOrigen.SelectedValue.ToString()), int.Parse(comboBoxDestino.SelectedValue.ToString()), dateTimeVUELTA.Value, checkBoxIda.Checked, int.Parse(comboBoxAdultos.Text));


            Formularios.formVuelosIdaVueltaDisponibles vuelosDisponibles = new Formularios.formVuelosIdaVueltaDisponibles();
            vuelosDisponibles.Show();
            /*String vuelos = String.Format("SELECT vuelos.id_vuelo ,vuelos.nro_vuelo ,vuelos.id_avion ,vuelos.fecha_salida_vuelo ,tarifas.clase_tarifa, tarifas.precio_tarifa FROM[LAFAST_gestor_de_reservas].[dbo].[vuelos] join[LAFAST_gestor_de_reservas].[dbo].[tramos] on vuelos.id_vuelo=tramos.id_vuelo join [LAFAST_gestor_de_reservas].[dbo].[tarifas] on vuelos.id_tarifa_vuelo= tarifas.id_tarifa where tramos.id_aeropuerto_destino ={1} and tramos.id_aeropuerto_origen ={0} and vuelos.fecha_salida_vuelo ='{2}';",comboBoxOrigen.SelectedValue,comboBoxDestino.SelectedValue, dateTimeIDA.Value.ToString("yyyy-MM-dd"));

            int origen = int.Parse(comboBoxOrigen.SelectedValue.ToString());
            int destino = int.Parse(comboBoxDestino.SelectedValue.ToString());

            DataSet dt = Utilidades.Ejecutar(vuelos);

            DataTable customerTable = dt.Tables["Table"];
            for (int i = 0; i < customerTable.Rows.Count; i++)
            {
                String s = dt.Tables["Table"].Rows[i]["id_vuelo"].ToString();

                MessageBox.Show(s);

            }*/
        }



            Formularios.formVuelosIdaVueltaDisponibles vuelosDisponibles = new Formularios.formVuelosIdaVueltaDisponibles(dateTimeIDA.Value, int.Parse(comboBoxOrigen.SelectedValue.ToString()), int.Parse(comboBoxDestino.SelectedValue.ToString()), dateTimeVUELTA.Value, checkBoxIda.Checked);

            vuelosDisponibles.Show();
            


            if (!checkBoxIda.Checked) { 
            Formularios.formVuelosIdaVueltaDisponibles vuelosDisponibles = new Formularios.formVuelosIdaVueltaDisponibles(dateTimeIDA.Value, int.Parse(comboBoxOrigen.SelectedValue.ToString()), int.Parse(comboBoxDestino.SelectedValue.ToString()), dateTimeVUELTA.Value, checkBoxIda.Checked, int.Parse(comboBoxAdultos.Text));

            vuelosDisponibles.Show();
            }
            else { 
            MessageBox.Show("Por el momento solo se puede reservar pasajes de idea y vuelta..intente mas tarde");
            }
        }

        private void checkBoxIda_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIda.Checked)
            {
                dateTimeVUELTA.Enabled = false;
            }
            else
            {
                dateTimeVUELTA.Enabled = true;
            }
        }
    }
}
