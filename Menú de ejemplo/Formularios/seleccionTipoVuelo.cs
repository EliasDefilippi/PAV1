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
    public partial class seleccionTipoVuelo : Form
    {
        public seleccionTipoVuelo()
        {
            InitializeComponent();
        }

        private void seleccionTipoVuelo_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancelarTarifa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonIda_Click(object sender, EventArgs e)
        {
            buscarVuelosYdestinosSoloIDA ventanaVuelosIda = new buscarVuelosYdestinosSoloIDA();
            ventanaVuelosIda.Show();
            this.Close();
        }

        private void btonVueloIda_Click(object sender, EventArgs e)
        {
            buscarVuelosYdestinos ventanaVuelosIdaYVuelta  = new buscarVuelosYdestinos();
            ventanaVuelosIdaYVuelta.Show();
            this.Close();
        }
    }
}
