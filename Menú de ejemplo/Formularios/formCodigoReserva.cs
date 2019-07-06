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
    public partial class formCodigoReserva : Form
    {
        public formCodigoReserva(int codigo)
        {
            InitializeComponent();
            lblcodigo.Text = ""+codigo;
        }

        private void formCodigoReserva_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
