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
    public partial class Frm_reportes : Form
    {
        public Frm_reportes()
        {
            InitializeComponent();
        }

        private void Frm_reportes_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string filtrar = string.Format("EXEC CodigoRecerva {0}", textBox1.Text.Trim());

            DataSet DS = Utilidades.Ejecutar(filtrar);

            DataTable DT = DS.Tables["Table"];
            codigoRecervaBindingSource.DataSource = DT;
            this.reportViewer2.RefreshReport();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string filtrar = string.Format("EXEC pasajerosConMenorCantidadDeMillasQue {0}", textBox2.Text.Trim());

            DataSet DS = Utilidades.Ejecutar(filtrar);

            DataTable DT = DS.Tables["Table"];
            pasajerosConMenorCantidadDeMillasQueBindingSource.DataSource = DT;

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

            string filtrar = string.Format("EXEC gananciaGanadaPorReservaDuranteElAño {0}", textBox3.Text.Trim());

            DataSet DS = Utilidades.Ejecutar(filtrar);

            DataTable DT = DS.Tables["Table"];

            gananciaGanadaPorReservaDuranteElAñoBindingSource.DataSource = DT;

            this.reportViewer3.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filtrar = string.Format("EXEC costoTotalPromedioDeReservasDuranteElAño {0}", textBox4.Text.Trim());

            DataSet DS = Utilidades.Ejecutar(filtrar);

            DataTable DT = DS.Tables["Table"];

           costoTotalPromedioDeReservasDuranteElAñoBindingSource.DataSource = DT;

            this.reportViewer4.RefreshReport();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filtrar = string.Format("EXEC listadoDeAeropuertosYlocalidadDestinoPorPais {0}", textBox5.Text.Trim());

            DataSet DS = Utilidades.Ejecutar(filtrar);

            DataTable DT = DS.Tables["Table"];

            listadoDeAeropuertosYlocalidadDestinoPorPaisBindingSource.DataSource = DT;

            this.reportViewer5.RefreshReport();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filtrar = string.Format("EXEC reservasPorMes {0}", textBox6.Text.Trim());

            DataSet DS = Utilidades.Ejecutar(filtrar);

            DataTable DT = DS.Tables["Table"];

            reservasPorMesBindingSource.DataSource = DT;

            this.reportViewer6.RefreshReport();
        }
    }
}
