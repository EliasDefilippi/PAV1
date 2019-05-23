using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menú_de_ejemplo.Formularios
{
    public partial class mostrarDatosDeVuelo : Form
    {
        private DateTime fecha_salida_vuelo;
        private int aeropuertoOrigen;
        private int aeropuertoDestino;
        private int id_vuelo_salida;
        private int id_vuelo_vuelta;
        private int idAsientoIda;
        private int idAsientoVuelta;
        private DateTime fecha_salida_ida;


        public mostrarDatosDeVuelo(DateTime fecha_salida, int aeropuertoOrigen, int aeropuertoDestino, int id_vuelo_salida, int id_vuelo_vuelta, int id_asiento_ida, int id_asiento_vuelta, DateTime fecha_salida_ida,int  cantidad)
        {



            InitializeComponent();

            this.fecha_salida_vuelo = fecha_salida;
            this.aeropuertoOrigen = aeropuertoOrigen;
            this.aeropuertoDestino = aeropuertoDestino;
            this.id_vuelo_salida = id_vuelo_salida;
            this.id_vuelo_vuelta = id_vuelo_vuelta;
            this.idAsientoIda = id_asiento_ida;
            this.idAsientoVuelta = id_asiento_vuelta;
            this.fecha_salida_ida=fecha_salida_ida;

            for(int i = 0; i < cantidad; i++) {
                nroVuelo.Text = nroVuelo.Text + id_vuelo_salida;
                nroVuelo.Text += Environment.NewLine;

                nroVueloVuelta.Text = nroVueloVuelta.Text + id_vuelo_vuelta;
                nroVueloVuelta.Text += Environment.NewLine;

                aeroOrigen.Text = aeroOrigen.Text + aeropuertoOrigen;
                aeroOrigen.Text += Environment.NewLine;

                aeroOrigenVuelta.Text = aeroOrigenVuelta.Text + aeropuertoDestino;
                aeroOrigenVuelta.Text += Environment.NewLine;

                aeroDestino.Text = aeroDestino.Text + aeropuertoDestino;
                aeroDestino.Text += Environment.NewLine;

                fechaSalida.Text = fechaSalida.Text + fecha_salida_ida.ToShortDateString();
                fechaSalida.Text += Environment.NewLine;


                aeroDestinoVuelta.Text = aeroDestinoVuelta.Text + aeropuertoOrigen;
                aeroDestinoVuelta.Text += Environment.NewLine;

                fechaVuelta.Text = fechaVuelta.Text + fecha_salida_vuelo.ToShortDateString();
                fechaVuelta.Text += Environment.NewLine;

          

                idAsiento.Text = idAsiento.Text + (idAsientoIda + i);
                idAsiento.Text += Environment.NewLine;

                asientoVuelta.Text = asientoVuelta.Text + (id_asiento_vuelta + i);
                asientoVuelta.Text += Environment.NewLine;


                Precio.Text = Precio.Text + (300);
                Precio.Text += Environment.NewLine;

                precioVuelta.Text = precioVuelta.Text + (300);
                precioVuelta.Text += Environment.NewLine;

                
            }
            int m = cantidad * 300 * 2 ;
            lbltotal.Text = Convert.ToString(m);
            InitializeComponent();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mostrarDatosDeVuelo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'localidades.tipo_documento' Puede moverla o quitarla según sea necesario.
            this.tipo_documentoTableAdapter1.Fill(this.localidades.tipo_documento);
            // TODO: esta línea de código carga datos en la tabla 'combox_localidad.tipo_documento' Puede moverla o quitarla según sea necesario.
            this.tipo_documentoTableAdapter.Fill(this.combox_localidad.tipo_documento);

        }

        private void label5_Click(object sender, EventArgs e)
        {

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

        public int propertyIdAsientoVuelta
        {
            get { return idAsientoVuelta; }

            set { idAsientoVuelta = value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
