using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Menú_de_ejemplo
{
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscarVuelosYdestinos ventanaVuelosDestinos = new buscarVuelosYdestinos();
            ventanaVuelosDestinos.Show();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Login instancia = new Login();
            instancia.Show();
        }

        private void botonCerrarInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonMaximizarInicio_Click(object sender, EventArgs e)
        {
            
        }

        private void botonMinimizarInicio_Click(object sender, EventArgs e)
        {

        }

        private void buttonInscribete_Click(object sender, EventArgs e)
        {
            Formularios.SeleccionPais_CrearUsuario ventanaSelecPais = new Formularios.SeleccionPais_CrearUsuario();
            ventanaSelecPais.Show();
        }

        private void buttonCrearTramo_Click(object sender, EventArgs e)
        {
            Formularios.CrearTramo formCrearTramo = new Formularios.CrearTramo();
            formCrearTramo.Show();
        }
    }
}
