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
    public partial class formVuelosVueltaDisponibles : Form
    {

        private DateTime fecha_salida_vuelo;
        private int aeropuertoOrigen;
        private int aeropuertoDestino;
        private int id_vuelo_salida;
        private int id_vuelo_vuelta;

        public formVuelosVueltaDisponibles(DateTime fecha_salida, int aeropuertoOrigen, int aeropuertoDestino)
        private DateTime fecha_salida_ida;
        private int cantidad;
        private String NombreAeropuertoOrigen;
        private String NombreAeropuertoDestino;
        private int precioVuelta;
        private int precioida;


        public formVuelosVueltaDisponibles(DateTime fecha_salida, int aeropuertoOrigen, int aeropuertoDestino, DateTime fecha_salida_ida,int cantidad,int precioIda)
        {
            InitializeComponent();
            this.fecha_salida_vuelo = fecha_salida;
            this.aeropuertoOrigen = aeropuertoOrigen;
            this.aeropuertoDestino = aeropuertoDestino;
            this.fecha_salida_ida = fecha_salida_ida;
            this.cantidad = cantidad;
            this.precioida= precioIda;
            formVuelosIdaVueltaDisponibles_Load();
        }

        private void formVuelosIdaVueltaDisponibles_Load()
        {

            String vuelos = String.Format("SELECT aeropuertos.nombre_aeropuerto,vuelos.id_vuelo , vuelos.nro_vuelo" +
                ",vuelos.id_avion ,vuelos.fecha_salida_vuelo ,tarifas.clase_tarifa , " +
                "tarifas.precio_tarifa FROM [LAFAST_gestor_de_reservas].[dbo].[vuelos]" +
              "  join [LAFAST_gestor_de_reservas].[dbo].[tramos] on vuelos.id_vuelo=tramos.id_vuelo" +
              "  join [LAFAST_gestor_de_reservas].[dbo].[tarifas] on vuelos.id_tarifa_vuelo= tarifas.id_tarifa " +
              "  join [LAFAST_gestor_de_reservas].[dbo].[aeropuertos] on aeropuertos.id_aeropuerto = tramos.id_aeropuerto_origen " +
              "   where tramos.id_aeropuerto_destino ={1} and tramos.id_aeropuerto_origen ={0} and vuelos.fecha_salida_vuelo ='{2}';", propertyAeropuertoOrigen, propertyAeropuertoDestino, propertyFecha_salida_vuelo.ToString("yyyy-MM-dd"));

            DataSet dt = Utilidades.Ejecutar(vuelos);


            DataTable customerTable = dt.Tables["Table"];

            customerTable.Columns[0].ColumnName = "Aeropuerto de Origen";
            customerTable.Columns[2].ColumnName = "Nro de Vuelo";
            customerTable.Columns[3].ColumnName = "Nro de Avion";
            customerTable.Columns[4].ColumnName = "Fecha de Salida";
            customerTable.Columns[5].ColumnName = "Clase";
            customerTable.Columns[6].ColumnName = "Precio";
            vuelosVuelta.DataSource = customerTable;
            vuelosVuelta.Columns[1].Visible = false;
            if (vuelosVuelta.Rows.Count>0)
            {

                this.id_vuelo_vuelta = int.Parse(vuelosVuelta.Rows[0].Cells["Nro de Vuelo"].Value.ToString());
                this.propertyNombreAeropuertoDestino = vuelosVuelta.Rows[0].Cells["Aeropuerto de Origen"].Value.ToString();
                this.precioVuelta = int.Parse(vuelosVuelta.Rows[0].Cells["Precio"].Value.ToString());

            }


        
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            
            formSeleccionAsientos formAsiento = new formSeleccionAsientos(propertyFecha_salida_vuelo, propertyAeropuertoOrigen, propertyAeropuertoDestino, propertyId_vuelo_salida, propertyId_vuelo_vuelta);
            formSeleccionAsientos formAsiento = new formSeleccionAsientos(propertyFecha_salida_vuelo, propertyAeropuertoOrigen, propertyAeropuertoDestino, propertyId_vuelo_salida, propertyId_vuelo_vuelta, propertyFecha_salida_ida,propertyPrecioVuelta, propertyCantidad,this.precioida);
            formAsiento.propertyNombreAeropuertoOrigen = propertyNombreAeropuertoOrigen;
            formAsiento.propertyNombreAeropuertoDestino = propertyNombreAeropuertoDestino;
            formAsiento.Show();

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

        public String propertyNombreAeropuertoOrigen
        {
            get { return NombreAeropuertoOrigen; }

            set { NombreAeropuertoOrigen = value; }
        }

        public String propertyNombreAeropuertoDestino
        {
            get { return NombreAeropuertoDestino; }

            set { NombreAeropuertoDestino = value; }
        }


        public int propertyAeropuertoDestino
        {
            get { return aeropuertoDestino; }

            set { aeropuertoDestino = value; }
        }

        public int propertyId_vuelo_salida
        {
            get { return id_vuelo_salida; }

            set { id_vuelo_salida = value; }
        }

        public int propertyId_vuelo_vuelta
        {
            get { return id_vuelo_vuelta; }

            set { id_vuelo_vuelta = value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public int propertyPrecioVuelta
        {
            get { return precioVuelta; }

            set { precioVuelta = value; }
        }
        private void vuelosVuelta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id_vuelo_vuelta = int.Parse(vuelosVuelta.Rows[e.RowIndex].Cells["Nro de Vuelo"].Value.ToString());
            this.propertyNombreAeropuertoDestino = vuelosVuelta.Rows[e.RowIndex].Cells["Aeropuerto de Origen"].Value.ToString();
            this.precioVuelta = int.Parse(vuelosVuelta.Rows[e.RowIndex].Cells["Precio"].Value.ToString());
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
