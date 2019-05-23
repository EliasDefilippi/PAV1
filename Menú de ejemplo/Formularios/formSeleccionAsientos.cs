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
    public partial class formSeleccionAsientos : Form
    {

        private DateTime fecha_salida_vuelo;
        private int aeropuertoOrigen;
        private int aeropuertoDestino;
        private int id_vuelo_salida;
        private int id_vuelo_vuelta;
        private int idAsientoIda;
        private int idAsientoVuelta;
        private DateTime fecha_salida_ida;
        private int cantidad;
        

        public formSeleccionAsientos(DateTime fecha_salida, int aeropuertoOrigen, int aeropuertoDestino, int id_vuelo_salida, int id_vuelo_vuelta, DateTime fecha_salida_ida,int  cantidad)
        {
            InitializeComponent();
            this.fecha_salida_vuelo = fecha_salida;
            this.aeropuertoOrigen = aeropuertoOrigen;
            this.aeropuertoDestino = aeropuertoDestino;
            this.id_vuelo_salida = id_vuelo_salida;
            this.id_vuelo_vuelta = id_vuelo_vuelta;
            this.fecha_salida_ida = fecha_salida_ida;
            this.cantidad = cantidad;
            formAsientos_Load();
        }
        
        private void formAsientos_Load()
        {

            String vuelos = String.Format("select asientos.fila,asientos.letra from asientos  where not exists (select asientos.id_asiento from vuelos " +
                " join asientos on vuelos.id_asiento = asientos.id_asiento " +
                 " where vuelos.id_vuelo ='{0}');", id_vuelo_salida);

            DataSet dt = Utilidades.Ejecutar(vuelos);

            DataTable customerTable = dt.Tables["Table"];

            customerTable.Columns[0].ColumnName = "Fila";
            customerTable.Columns[1].ColumnName = "Letra";
            
            asientosIda.DataSource = customerTable;

            String asientovuelta = String.Format("select asientos.fila,asientos.letra from asientos  where not exists (select asientos.id_asiento from vuelos " +
               " join asientos on vuelos.id_asiento = asientos.id_asiento " +
                " where vuelos.id_vuelo ='{0}');", id_vuelo_vuelta);

            dt = Utilidades.Ejecutar(asientovuelta);

            customerTable = dt.Tables["Table"];

            customerTable.Columns[0].ColumnName = "Fila";
            customerTable.Columns[1].ColumnName = "Letra";

            asientosVueta.DataSource = customerTable;

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

            mostrarDatosDeVuelo titular = new mostrarDatosDeVuelo (propertyFecha_salida_vuelo, propertyAeropuertoOrigen, propertyAeropuertoDestino, propertyId_vuelo_salida, propertyId_vuelo_vuelta, propertyIdAsientoIda, propertyIdAsientoVuelta, propertyFecha_salida_ida,propertyCantidad);


            titular.Show();


            // MessageBox.Show(""+propertyIdAsientoIda);
            //MessageBox.Show("" + propertyIdAsientoVuelta);
             this.Close();
        }


        

             public DateTime propertyFecha_salida_ida
        {
            get { return fecha_salida_ida; }

            set { fecha_salida_ida = value; }
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

        public int propertyIdAsientoIda
        {
            get { return idAsientoIda; }

            set { idAsientoIda = value; }
        }

        
            public int propertyCantidad
        {
            get { return cantidad; }

            set { cantidad = value; }
        }
        public int propertyIdAsientoVuelta
        {
            get { return idAsientoVuelta; }

            set { idAsientoVuelta = value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void asientosVueta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            propertyIdAsientoVuelta = int.Parse(asientosVueta.Rows[e.RowIndex].Cells["Fila"].Value.ToString());
       
            MessageBox.Show("Se selecciono el asiento : " + propertyIdAsientoVuelta + asientosVueta.Rows[e.RowIndex].Cells["Letra"].Value.ToString());
        }

        private void asientosIda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            propertyIdAsientoIda = int.Parse(asientosIda.Rows[e.RowIndex].Cells["Fila"].Value.ToString());
            MessageBox.Show("Se selecciono el asiento : " + propertyIdAsientoIda + asientosIda.Rows[e.RowIndex].Cells["Letra"].Value.ToString());
       
        }
    }

}
