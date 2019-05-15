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
    public partial class CrearTarifa : Form
    {
        public CrearTarifa()
        {
            InitializeComponent();
        }

        private void buttonCancelarTarifa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrearTarifa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'combox_localidad.tarifas' Puede moverla o quitarla según sea necesario.
            this.tarifasTableAdapter.Fill(this.combox_localidad.tarifas);
        }

        private void buttonConfirmarTarifa_Click(object sender, EventArgs e)
        {
            int precioTarifa = int.Parse(textBoxPrecioTarifa.Text);
            int impuestoTarifa = int.Parse(textBoxImpuestoTarifa.Text);
            string claseTarifa = comboBoxClaseTarifa.Text;

            insertarNuevaTarifa(claseTarifa, precioTarifa, impuestoTarifa);
        }

        public void insertarNuevaTarifa(String claseTarifa, int precioTarifa, int impuestoTarifa)
        {
            try
            {
                string insertarTarifa = string.Format("INSERT INTO [LAFAST_gestor_de_reservas].[dbo].[tarifas] (clase_tarifa, precio_tarifa, impuesto_tarifa) VALUES ('{0}', {1}, {2});", claseTarifa, precioTarifa, impuestoTarifa);
                MessageBox.Show(insertarTarifa);
                Utilidades.Ejecutar(insertarTarifa);
                MessageBox.Show("Se registro una nueva tarifa exitosamente.");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al insertar la nueva tarifa, intente nuevamente más tarde.");
            }
        }
    }
}
