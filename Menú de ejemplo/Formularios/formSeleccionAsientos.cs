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


        public formSeleccionAsientos(DateTime fecha_salida, int aeropuertoOrigen, int aeropuertoDestino, int id_vuelo_salida, int id_vuelo_vuelta)

        private DateTime fecha_salida_ida;
        private int cantidad;
        private String NombreAeropuertoOrigen;
        private String NombreAeropuertoDestino;
        private int precioVuelta;
        private int precioIda;


        public formSeleccionAsientos(DateTime fecha_salida, int aeropuertoOrigen, int aeropuertoDestino, int id_vuelo_salida, int id_vuelo_vuelta, DateTime fecha_salida_ida, int precioVuelta, int cantidad, int  precioIda)
        {
            InitializeComponent();
            this.fecha_salida_vuelo = fecha_salida;
            this.aeropuertoOrigen = aeropuertoOrigen;
            this.aeropuertoDestino = aeropuertoDestino;
            this.id_vuelo_salida = id_vuelo_salida;
            this.id_vuelo_vuelta = id_vuelo_vuelta;
            this.fecha_salida_ida = fecha_salida_ida;
            this.cantidad = cantidad;
            this.precioIda = precioIda;
            this.precioVuelta = precioVuelta;
            formAsientos_Load();
        }

        private void formAsientos_Load()
        {

            String vuelos = String.Format("select asientos.fila,asientos.letra,asientos.id_asiento from asientos  where asientos.id_asiento not in (select asientos.id_asiento from detalle_reserva " +
                " join asientos on detalle_reserva.id_asiento = asientos.id_asiento " +
                 " where detalle_reserva.id_vuelo ='{0}') order by asientos.fila ;", id_vuelo_salida);

            DataSet dt = Utilidades.Ejecutar(vuelos);

            DataTable customerTable = dt.Tables["Table"];

            customerTable.Columns[0].ColumnName = "Fila";
            customerTable.Columns[1].ColumnName = "Letra";


            asientosIda.DataSource = customerTable;
            asientosIda.Columns[2].Visible = false;

            String asientovuelta = String.Format("select asientos.fila,asientos.letra,asientos.id_asiento from asientos  where asientos.id_asiento not in (select asientos.id_asiento from detalle_reserva " +
               " join asientos on detalle_reserva.id_asiento = asientos.id_asiento " +
                " where detalle_reserva.id_vuelo ='{0}') order by asientos.fila;", id_vuelo_vuelta);

            dt = Utilidades.Ejecutar(asientovuelta);

            customerTable = dt.Tables["Table"];

            customerTable.Columns[0].ColumnName = "Fila";
            customerTable.Columns[1].ColumnName = "Letra";

            asientosVueta.DataSource = customerTable;
            asientosVueta.Columns[2].Visible = false;
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(""+propertyIdAsientoIda);
            MessageBox.Show("" + propertyIdAsientoVuelta);
            this.Close();
          

            DataGridViewSelectedRowCollection asientosVueltaSelected = asientosVueta.SelectedRows;

            DataGridViewSelectedRowCollection asientosIdaSelected = asientosIda.SelectedRows;


            mostrarDatosDeVuelo titular = new mostrarDatosDeVuelo (propertyFecha_salida_vuelo, propertyAeropuertoOrigen, propertyAeropuertoDestino, propertyId_vuelo_salida, propertyId_vuelo_vuelta, asientosVueltaSelected, asientosIdaSelected, propertyFecha_salida_ida, this.precioIda, propertyPrecioVuelta, propertyNombreAeropuertoDestino, propertyNombreAeropuertoOrigen);


            titular.Show();

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

        public int propertyIdAsientoVuelta
        {
            get { return idAsientoVuelta; }

            set { idAsientoVuelta = value; }
        }

        public int propertyPrecioVuelta
        {
            get { return precioVuelta; }

            set { precioVuelta = value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vuelosVuelta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            propertyIdAsientoIda = int.Parse(asientosIda.Rows[e.RowIndex].Cells["Fila"].Value.ToString());
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void asientosVueta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            propertyIdAsientoVuelta = int.Parse(asientosVueta.Rows[e.RowIndex].Cells["Fila"].Value.ToString());
            propertyIdAsientoVuelta = int.Parse(asientosVueta.Rows[e.RowIndex].Cells["Fila"].Value.ToString());

        if(e.RowIndex+cantidad <= asientosVueta.RowCount) {

            for (int i = 0; i < this.cantidad; i++)
            {
                asientosVueta.Rows[e.RowIndex + i].Selected = true;
            }

            if (this.cantidad == 1)
            {

            }
            else
            {
                String asientos = "";
                for (int j = 0; j < this.cantidad; j++)
                {
                    asientos = asientos + asientosVueta.Rows[e.RowIndex + j].Cells["Fila"].Value.ToString() + asientosVueta.Rows[e.RowIndex + j].Cells["Letra"].Value.ToString() + Environment.NewLine;

                }
             


            }

            }
            else {
                MessageBox.Show("Debe seleccionar otras asientos");

            }

        }


        private void asientosIda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            propertyIdAsientoIda = int.Parse(asientosIda.Rows[e.RowIndex].Cells["Fila"].Value.ToString());

            if (e.RowIndex + cantidad <= asientosIda.RowCount)
            {
                for (int i = 0; i < this.cantidad; i++)
                {
                    asientosIda.Rows[e.RowIndex + i].Selected = true;
                }

                if (this.cantidad == 1)
                {


                }
                else
                {
                    String asientos = "";
                    for (int j = 0; j < this.cantidad; j++)
                    {
                        asientos = asientos + asientosIda.Rows[e.RowIndex + j].Cells["Fila"].Value.ToString() + asientosIda.Rows[e.RowIndex + j].Cells["Letra"].Value.ToString() + Environment.NewLine;

                    }


                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar otras asientos");

            }
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

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
