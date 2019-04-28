using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menú_de_ejemplo.Formularios.Crear_Usuario
{
    public partial class DatosDeLaCuenta_CrearUsuario : Form
    {
        public DatosDeLaCuenta_CrearUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            datos_personales_CrearUsuario ventanaDatosPersonales = new datos_personales_CrearUsuario();
            ventanaDatosPersonales.Show();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
