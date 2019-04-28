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
    public partial class SeleccionPais_CrearUsuario : Form
    {
        public SeleccionPais_CrearUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBoxNacionalidad != null)
            {
                this.Close();
                Formularios.Crear_Usuario.DatosDeLaCuenta_CrearUsuario ventanaDatosCuenta = new Formularios.Crear_Usuario.DatosDeLaCuenta_CrearUsuario();
                ventanaDatosCuenta.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxNacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SeleccionPais_CrearUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
