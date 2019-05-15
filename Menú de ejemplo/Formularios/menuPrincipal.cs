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
            this.WindowState = FormWindowState.Maximized;
        }

        private void botonMinimizarInicio_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void buttonRegistrarAeropuerto_Click(object sender, EventArgs e)
        {
            Formularios.RegistrarAeropuerto newAirport = new Formularios.RegistrarAeropuerto();
            newAirport.Show();
        }

        private void buttonCrearVuelo_Click(object sender, EventArgs e)
        {
            Formularios.CrearVuelo newFligth = new Formularios.CrearVuelo();
            newFligth.Show();
        }

        private void buttonCrearTarifa_Click(object sender, EventArgs e)
        {
            Formularios.CrearTarifa newTarifa = new Formularios.CrearTarifa();
            newTarifa.Show();
        }

        private void buttonEliminarAeropuerto_Click(object sender, EventArgs e)
        {
            Formularios.EliminarAeropuerto chauAeropuerto = new Formularios.EliminarAeropuerto();
            chauAeropuerto.Show();
        }
    }
}
