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
    public partial class SeleccionDeVuelo : Form
    {

       private int id_aeropuerto_destino;
       private int id_aeropuerto_origen;
       private int duracion;
       private int distancia;
        private int id_vuelo;
        private int id_avion;
        private DateTime fecha_salida_vuelo;
        public SeleccionDeVuelo()
        {
            InitializeComponent();
        }



        public DateTime propertyFecha_salida_vuelo
        {
            get
            {
                return fecha_salida_vuelo;
            }
            set
            {
                fecha_salida_vuelo = value;
            }
        }

        public int propertyId_avion
        {
            get
            {
                return id_avion;
            }
            set
            {
                id_avion = value;
            }
        }


        public int propertyId_vuelo
        {
            get
            {
                return id_vuelo;
            }
            set
            {
                id_vuelo = value;
            }
        }
        public int propertyDistancia
        {
            get
            {
                return distancia;
            }
            set
            {
                distancia = value;
            }
        }

        public int propertyDuracion
        {
            get
            {
                return duracion;
            }
            set
            {
                duracion = value;
            }
        }


        public int propertyId_aeropuerto_destino
        {
            get
            {
                return id_aeropuerto_destino;
            }
            set
            {
                id_aeropuerto_destino = value;
            }
        }

        public int propertyId_aeropuerto_origen
        {
            get
            {
                return id_aeropuerto_origen;
            }
            set
            {
                id_aeropuerto_origen = value;
            }
        }

        private void SeleccionDeVuelo_Load(object sender, EventArgs e)
        {

             DataSet ds;

            string cmd = string.Format("select id_vuelo, nro_vuelo, id_avion, fecha_salida_vuelo FROM [LAFAST_gestor_de_reservas].[dbo].[vuelos]; ");
            ds = Utilidades.Ejecutar(cmd);

            dataGridView1.DataSource = ds.Tables[0];
           
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;
                    string cmd = "select id_vuelo , nro_vuelo , id_avion , fecha_salida_vuelo FROM vuelos WHERE id_avion LIKE ('%" + textBox1.Text.Trim() + "%')";

                    ds = Utilidades.Ejecutar(cmd);

                    dataGridView1.DataSource = ds.Tables[0];
                   


                }
                catch (Exception error)
                {

                    MessageBox.Show("Se produjo un error: " + error.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            id_vuelo = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id_vuelo"].Value.ToString());
            id_avion = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id_avion"].Value.ToString());
            fecha_salida_vuelo = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells["fecha_salida_vuelo"].Value.ToString());

           


            string insertVuelo = string.Format("INSERT INTO [LAFAST_gestor_de_reservas].[dbo].[tramos] (id_aeropuerto_origen ,id_aeropuerto_destino, distancia_tramo , id_vuelo,id_avion , fecha_salida_vuelo , duracion) VALUES (  {0} , {1} , {2} , {3} , {4} , '{5}' , {6} );", id_aeropuerto_origen, id_aeropuerto_destino, distancia, id_vuelo, id_avion, fecha_salida_vuelo.ToString("yyyy-MM-dd"), duracion);

            Utilidades.Ejecutar(insertVuelo);

            MessageBox.Show("Se asigno el vuelo al tramo correspondiete ");

            this.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
