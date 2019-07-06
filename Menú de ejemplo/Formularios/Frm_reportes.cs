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
            if(textBox1.Text!=""){
                string filtrar = string.Format("EXEC CodigoRecerva {0}", textBox1.Text.Trim());

            DataSet DS = Utilidades.Ejecutar(filtrar);

            DataTable DT = DS.Tables["Table"];
            codigoRecervaBindingSource.DataSource = DT;
            this.reportViewer2.RefreshReport();
            }
            else
            {
                MessageBox.Show("Ingrese el Codigo de reserva");
                textBox1.Focus();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                string filtrar = string.Format("EXEC pasajerosConMenorCantidadDeMillasQue {0}", textBox2.Text.Trim());

            DataSet DS = Utilidades.Ejecutar(filtrar);

            DataTable DT = DS.Tables["Table"];
            pasajerosConMenorCantidadDeMillasQueBindingSource.DataSource = DT;

            this.reportViewer1.RefreshReport();
            }
            else
            {
                    MessageBox.Show("Ingrese cantidad de millas");
                    textBox2.Focus();
                }
            }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                string filtrar = string.Format("EXEC gananciaGanadaPorReservaDuranteElAño {0}", textBox3.Text.Trim());

            DataSet DS = Utilidades.Ejecutar(filtrar);

            DataTable DT = DS.Tables["Table"];

            gananciaGanadaPorReservaDuranteElAñoBindingSource.DataSource = DT;

            this.reportViewer3.RefreshReport();
            }
            else
            {
                MessageBox.Show("Ingrese año");
                textBox3.Focus();
            }
        
    }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                string filtrar = string.Format("EXEC costoTotalPromedioDeReservasDuranteElAño {0}", textBox4.Text.Trim());

            DataSet DS = Utilidades.Ejecutar(filtrar);

            DataTable DT = DS.Tables["Table"];

           costoTotalPromedioDeReservasDuranteElAñoBindingSource.DataSource = DT;

            this.reportViewer4.RefreshReport();
            }
            else
            {
                MessageBox.Show("Ingrese año");
                textBox4.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                string filtrar = string.Format("EXEC listadoDeAeropuertosYlocalidadDestinoPorPais {0}", textBox5.Text.Trim());

            DataSet DS = Utilidades.Ejecutar(filtrar);

            DataTable DT = DS.Tables["Table"];

            listadoDeAeropuertosYlocalidadDestinoPorPaisBindingSource.DataSource = DT;

            this.reportViewer5.RefreshReport();
            }
            else
            {
                MessageBox.Show("Ingrese Pais");
                textBox5.Focus();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                string filtrar = string.Format("EXEC reservasPorMes {0}", textBox6.Text.Trim());

            DataSet DS = Utilidades.Ejecutar(filtrar);

            DataTable DT = DS.Tables["Table"];

            reservasPorMesBindingSource.DataSource = DT;

            this.reportViewer6.RefreshReport();
            }
            else
            {
                MessageBox.Show("Ingrese Mes");
                textBox6.Focus();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                string filtrar = string.Format("EXEC  gananciaTotalEnUnAñoXporMes {0}", textBox7.Text.Trim());

            DataSet DS = Utilidades.Ejecutar(filtrar);

            DataTable DT = DS.Tables["Table"];

            gananciaTotalEnUnAñoXporMesBindingSource.DataSource = DT;

            this.reportViewer7.RefreshReport();
            }
            else
            {
                MessageBox.Show("Ingrese Año");
                textBox7.Focus();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox8.Text != "")
            {
                string filtrar = string.Format("EXEC  promedioPorMesEnUnAñoX {0}", textBox8.Text.Trim());

            DataSet DS = Utilidades.Ejecutar(filtrar);

            DataTable DT = DS.Tables["Table"];

          promedioPorMesEnUnAñoXBindingSource.DataSource = DT;

            this.reportViewer8.RefreshReport();
            }
            else
            {
                MessageBox.Show("Ingrese Año");
                textBox8.Focus();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {
                string filtrar = string.Format("EXEC  historioVueos {0}", textBox9.Text.Trim());

            DataSet DS = Utilidades.Ejecutar(filtrar);

            DataTable DT = DS.Tables["Table"];

           historioVueosBindingSource.DataSource = DT;

            this.reportViewer9.RefreshReport();
            }
            else
            {
                MessageBox.Show("Ingrese Pais");
                textBox8.Focus();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer9_Load(object sender, EventArgs e)
        {

        }
    }
}
