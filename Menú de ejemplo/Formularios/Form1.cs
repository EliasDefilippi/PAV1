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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lAFAST_gestor_de_reservasDataSet3.vuelos' Puede moverla o quitarla según sea necesario.
            this.vuelosTableAdapter.Fill(this.lAFAST_gestor_de_reservasDataSet3.vuelos);
            // TODO: esta línea de código carga datos en la tabla 'datosNuevos.aeropuertos' Puede moverla o quitarla según sea necesario.

            // TODO: esta línea de código carga datos en la tabla 'aeropuertos._aeropuertos' Puede moverla o quitarla según sea necesario.




            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void aeropuertosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_2(object sender, EventArgs e)
        {

        }
    }
}
