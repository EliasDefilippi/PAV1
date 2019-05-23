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
    public partial class formRegistrarReservaDatosTitular : Form
    {

        private DateTime fecha_salida_vuelo;
        private int aeropuertoOrigen;
        private int aeropuertoDestino;
        private int id_vuelo_salida;
        private int id_vuelo_vuelta;
        private int idAsientoIda;
        private int idAsientoVuelta;



        public formRegistrarReservaDatosTitular(DateTime fecha_salida, int aeropuertoOrigen, int aeropuertoDestino, int id_vuelo_salida, int id_vuelo_vuelta,int id_asiento_ida,int id_asiento_vuelta)
        {

            InitializeComponent();
            this.fecha_salida_vuelo= fecha_salida;
            this.aeropuertoOrigen= aeropuertoOrigen;
            this.aeropuertoDestino= aeropuertoDestino;
            this.id_vuelo_salida= id_vuelo_salida;
            this.id_vuelo_vuelta= id_vuelo_vuelta;
            this.idAsientoIda= id_asiento_ida;
            this.idAsientoVuelta= id_asiento_vuelta;
    }

        private void button2_Click(object sender, EventArgs e)
        {

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

        private void formRegistrarReservaDatosTitular_Load(object sender, EventArgs e)
        {

        }
    }
}
