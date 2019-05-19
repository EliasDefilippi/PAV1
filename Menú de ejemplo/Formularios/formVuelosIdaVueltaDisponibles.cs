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
    public partial class formVuelosIdaVueltaDisponibles : Form
    {
        public formVuelosIdaVueltaDisponibles()
        {
            InitializeComponent();
        }

        private void formVuelosIdaVueltaDisponibles_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
