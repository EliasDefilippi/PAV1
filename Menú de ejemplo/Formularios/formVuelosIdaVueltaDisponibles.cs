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
    public partial class formVuelosIdaVueltaDisponibles : Form
    {

        private DateTime fecha_salida_vuelo;
        private int aeropuertoOrigen;
        private int aeropuertoDestino;
        private DateTime fecha_salida_vuelta;
        private Boolean tieneVuelta;
        private int idVuelo;
        private int cantidad;
        private String NombreAeropuertoOrigen;
        private int precioIda;



        public formVuelosIdaVueltaDisponibles(DateTime fecha_salida, int aeropuertoOrigen, int aeropuertoDestino, DateTime fecha_salida_vuelta,Boolean tieneVuelta)
        {
            InitializeComponent();
            this.fecha_salida_vuelo = fecha_salida;
            this.aeropuertoOrigen = aeropuertoOrigen;
            this.aeropuertoDestino = aeropuertoDestino;
            this.fecha_salida_vuelta = fecha_salida_vuelta;
            this.tieneVuelta = tieneVuelta;
            formVuelosIdaVueltaDisponibles_Load();
        }
        
        private void formVuelosIdaVueltaDisponibles_Load()
        {

            String vuelos = String.Format("SELECT aeropuertos.nombre_aeropuerto,vuelos.id_vuelo , vuelos.nro_vuelo" +
                ",vuelos.id_avion ,vuelos.fecha_salida_vuelo ,tarifas.clase_tarifa , "+
                "tarifas.precio_tarifa FROM [LAFAST_gestor_de_reservas].[dbo].[vuelos]" + 
              "  join [LAFAST_gestor_de_reservas].[dbo].[tramos] on vuelos.id_vuelo=tramos.id_vuelo"+
              "  join [LAFAST_gestor_de_reservas].[dbo].[tarifas] on vuelos.id_tarifa_vuelo= tarifas.id_tarifa "+
              "  join [LAFAST_gestor_de_reservas].[dbo].[aeropuertos] on aeropuertos.id_aeropuerto = tramos.id_aeropuerto_origen " +
              "  where tramos.id_aeropuerto_destino ={1} and tramos.id_aeropuerto_origen ={0} and vuelos.fecha_salida_vuelo ='{2}';", propertyAeropuertoOrigen, propertyAeropuertoDestino,propertyFecha_salida_vuelo.ToString("yyyy-MM-dd"));

            
             DataSet dt = Utilidades.Ejecutar(vuelos);
            if (dt.Tables["Table"].Rows.Count > 0)
            {

                DataTable customerTable = dt.Tables["Table"];


                customerTable.Columns[0].ColumnName = "Aeropuerto de Origen";
                customerTable.Columns[2].ColumnName = "Nro de Vuelo";
                customerTable.Columns[3].ColumnName = "Nro de Avion";
                customerTable.Columns[4].ColumnName = "Fecha de Salida";
                customerTable.Columns[5].ColumnName = "Clase";
                customerTable.Columns[6].ColumnName = "Precio";
                vuelosIda.DataSource = customerTable;

                vuelosIda.Columns[1].Visible = false;

                if (vuelosIda.Rows.Count > 0)
                {
                    this.idVuelo = int.Parse(vuelosIda.Rows[0].Cells["id_vuelo"].Value.ToString());
                    this.NombreAeropuertoOrigen = vuelosIda.Rows[0].Cells["Aeropuerto de Origen"].Value.ToString();
                    this.precioIda = int.Parse(vuelosIda.Rows[0].Cells["Precio"].Value.ToString());
                }
                if (tieneVuelta)
                {
                    buttonVuelta.Text = "Seleccionar Asientos";
                }
            }
            else
            {
                MessageBox.Show("No Existen vuelos para la fecha asignada, por favor ingrese otra fecha");
               

            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {


            if (!tieneVuelta)
            {
                Formularios.formVuelosVueltaDisponibles vuelosDisponiblesVuelta = new Formularios.formVuelosVueltaDisponibles(propertyFecha_salida_vuelta, propertyAeropuertoDestino, propertyAeropuertoOrigen);
                Formularios.formVuelosVueltaDisponibles vuelosDisponiblesVuelta = new Formularios.formVuelosVueltaDisponibles(propertyFecha_salida_vuelta, propertyAeropuertoDestino, propertyAeropuertoOrigen, fecha_salida_vuelo,propertyCantidad,propertyPrecioIda);
                vuelosDisponiblesVuelta.propertyId_vuelo_salida = idVuelo;
                vuelosDisponiblesVuelta.propertyNombreAeropuertoOrigen = this.NombreAeropuertoOrigen;
                vuelosDisponiblesVuelta.Show();
            }
            else
            {
                MessageBox.Show("Por el momento solo se puede reservar pasajes de idea y vuelta..intente mas tarde");

            }

            this.Close();
        }

        public DateTime propertyFecha_salida_vuelo
        {
            get { return fecha_salida_vuelo; }

            set { fecha_salida_vuelo = value; }
        }

        public int propertyAeropuertoOrigen
        {
            get { return aeropuertoOrigen; }

            set { aeropuertoOrigen = value; }
        }

        public int propertyAeropuertoDestino
        {
            get { return aeropuertoDestino; }

            set { aeropuertoDestino = value; }
        }

        public int propertyPrecioIda
        {
            get { return precioIda; }

            set { precioIda = value; }
        }

        public Boolean propertyTieneVuelta
        {
            get { return tieneVuelta; }

            set { tieneVuelta = value; }
        }


        public DateTime propertyFecha_salida_vuelta
        {
        get { return fecha_salida_vuelta; }

        set { fecha_salida_vuelta = value; }
    }

    private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vuelosIda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            this.idVuelo = int.Parse(vuelosIda.Rows[e.RowIndex].Cells["id_vuelo"].Value.ToString());
            this.NombreAeropuertoOrigen = vuelosIda.Rows[e.RowIndex].Cells["Aeropuerto de Origen"].Value.ToString();
            this.precioIda = int.Parse(vuelosIda.Rows[e.RowIndex].Cells["Precio"].Value.ToString());
           

    }


        }
        public String propertyNombreAeropuertoOrigen
        {
            get { return NombreAeropuertoOrigen; }

            set { NombreAeropuertoOrigen = value; }
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
