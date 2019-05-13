using System;
using System.Collections;
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
    public partial class CrearVuelo : Form
    {
        public CrearVuelo()
        {
            InitializeComponent();
            inicializarCombo();
        }

        private void CrearVuelo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'combox_localidad.tarifas' Puede moverla o quitarla según sea necesario.
            this.tarifasTableAdapter.Fill(this.combox_localidad.tarifas);

        }

        private void buttonCancelarCreacionVuelo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inicializarCombo()
        {
            string cmd = string.Format("SELECT * FROM dbo.avion,dbo.modelo_avion where dbo.avion.id_modelo_avion=dbo.modelo_avion.id_modelo_avion;");

            DataSet dt = Utilidades.Ejecutar(cmd);

            DataTable customerTable = dt.Tables["Table"];

            comboBoxAvionVuelo.DisplayMember = customerTable.Columns["desc_modelo_avion"].ToString().Trim(); 
            comboBoxAvionVuelo.ValueMember = customerTable.Columns["id_avion"].ToString().Trim();
            comboBoxAvionVuelo.DataSource = customerTable;
   
        }

        private void buttonConfirmarVuelo_Click(object sender, EventArgs e)
        {
            //      [id_vuelo],[id_avion],[fecha_salida_vuelo],[id_asiento],[id_tipo_documento_pasajero],[numero_documento_pasajero],[id_tarifa_vuelo]
            int id_vuelo = int.Parse(textBoxNumeroVuelo.Text);
            DateTime fecha_salida_vuelo = dateTimeFechaVuelo.Value;
            int id_avion = int.Parse(comboBoxAvionVuelo.SelectedValue.ToString());
        }
    }
}
