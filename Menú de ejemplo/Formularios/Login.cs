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
using System.Data.OleDb;
using System.Data;


namespace Menú_de_ejemplo
{
    public partial class Login : Form
    {
        public static String Id = "";
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botonIniciaSesion_Click(object sender, EventArgs e)
        {
          if(Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {
                    this.textBoxUsuario.Focus();
                    string cmd = string.Format("SELECT * FROM usuarios WHERE correo_usuario='{0}' AND  pass_usuario='{1}' ", textBoxUsuario.Text.Trim(), textBoxContraseña.Text.Trim());

                    DataSet DT = Utilidades.Ejecutar(cmd);

                    string cadena = DT.Tables[0].Rows[0]["correo_usuario"].ToString().Trim();
                    string contra = DT.Tables[0].Rows[0]["pass_usuario"].ToString().Trim();

                    Id = DT.Tables[0].Rows[0]["id_usuario"].ToString().Trim();

                    if (cadena == textBoxUsuario.Text.Trim() && contra == textBoxContraseña.Text.Trim())
                    {
                        MessageBox.Show("Todo bien");
                    }
                    else
                    {
                        MessageBox.Show("Los datos ingresados sn incorrectos.");
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error de conexion: " + error.Message);
                }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Formularios.SeleccionPais_CrearUsuario ventanaSelecUsu = new Formularios.SeleccionPais_CrearUsuario();
            ventanaSelecUsu.Show();
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
