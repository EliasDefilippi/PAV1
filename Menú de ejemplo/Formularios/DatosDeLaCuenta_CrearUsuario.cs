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
            
            datos_personales_CrearUsuario ventanaDatosPersonales = new datos_personales_CrearUsuario();
            String correo = textBoxCorreoElectronico.Text;
            String password = textBoxContraseña.Text;
            String passwordConfirmated = textBoxConfirmarContraseña.Text;
            
            if(!correo.Contains("@"))
            {
                MessageBox.Show("Ingrese un correo : ");
                textBoxCorreoElectronico.Text = "";
                textBoxConfirmarContraseña.Text = "";
                textBoxContraseña.Text = "";
            }
     else {

      if(!validarUsuario())
                { 
                    if (password==passwordConfirmated)
                    {
                        this.Close();
                         ventanaDatosPersonales.propertyPassword = password;
                         ventanaDatosPersonales.propertyCorreo=correo;
                         ventanaDatosPersonales.Show();
                     }
                    else
                     {
                          MessageBox.Show("no coindicen las contraseñas, por favor vuelva a ingresarla: ");
                          textBoxConfirmarContraseña.Text = "";
                          textBoxContraseña.Text = "";
                     }
                }
      else
                {
                    MessageBox.Show("Ya se encuentra registrado ese correo : ");
                    textBoxCorreoElectronico.Text = "";
                    textBoxConfirmarContraseña.Text = "";
                    textBoxContraseña.Text = "";

                }

            }
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Boolean validarUsuario()
        {
            string cmd = string.Format("SELECT * FROM usuarios WHERE correo_usuario='{0}' ", textBoxCorreoElectronico.Text.Trim());

            DataSet dt = Utilidades.Ejecutar(cmd);
            
            if (dt.Tables[0].Rows.Count>0)
            {
                return true;
            }

            return false;



        }
        



    }
}
