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
        public SeleccionDeVuelo()
        {
            InitializeComponent();
        }


        private void SeleccionDeVuelo_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = Utilidades.LlenarDataGV("vuelos").Tables[0];
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;
                    string cmd = "select * FROM vuelos WHERE id_avion LIKE ('%" + textBox1.Text.Trim() + "%')";

                    ds = Utilidades.Ejecutar(cmd);

                    dataGridView1.DataSource = ds.Tables[0];

                }
                catch (Exception error)
                {

                    MessageBox.Show("Se produjo un error: " + error.Message);
                }
            }
        }

    }
}
