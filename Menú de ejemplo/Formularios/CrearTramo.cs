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
    public partial class CrearTramo : Form
    {
        public CrearTramo()
        {
            InitializeComponent();
        }

        private void buttonAsignarVuelo_Click(object sender, EventArgs e)
        {
            Formularios.SeleccionDeVuelo vueloElegido = new Formularios.SeleccionDeVuelo();
            this.Close();
            vueloElegido.Show();
        }

        private void CrearTramo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'localidades.aeropuertos' Puede moverla o quitarla según sea necesario.
            this.aeropuertosTableAdapter.Fill(this.localidades.aeropuertos);
            // TODO: esta línea de código carga datos en la tabla 'localidades._localidades' Puede moverla o quitarla según sea necesario.
            this.localidadesTableAdapter.Fill(this.localidades._localidades);

        }
    }
}
