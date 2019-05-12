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

namespace Menú_de_ejemplo.Formularios
{
    public partial class datos_personales_CrearUsuario : Form
    {
        private String correo;
        private String password;
        public datos_personales_CrearUsuario()
        {
            InitializeComponent();
            comboBoxMesFechaNac.SelectedIndex = comboBoxMesFechaNac.Items.IndexOf("Enero");
            comBoxDiaNac.SelectedIndex = comBoxDiaNac.Items.IndexOf("01");

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void datos_personales_CrearUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'localidades.tipo_documento' Puede moverla o quitarla según sea necesario.
            this.tipo_documentoTableAdapter.Fill(this.localidades.tipo_documento);
            // TODO: esta línea de código carga datos en la tabla 'localidades.paises' Puede moverla o quitarla según sea necesario.
            this.paisesTableAdapter.Fill(this.localidades.paises);

        }

        private void buttonCrearCuenta_Click(object sender, EventArgs e)
        {


            if (checkBoxTerminosYcondiciones.Checked) { 

            String mes = "";
            switch (comboBoxMesFechaNac.Text)
            {
                case "Enero":
                    mes = "01";
                break;
                case "Febrero":
                     mes = "02";
                    break;
                case "Marzo":
                     mes = "03";
                    break;
                case "Abril":
                     mes = "04";
                    break;
                case "Mayo":
                    mes = "05";
                    break;
                case "Junio":
                    mes = "06";
                    break;
                case "Julio":
                    mes = "07";
                    break;
                case "Agosto":
                    mes = "08";
                    break;
                case "Septiembre":
                    mes = "09";
                    break;
                case "Octubre":
                    mes = "10";
                    break;
                case "Noviembre":
                    mes = "11";
                    break;
                case "Diciembre":
                    mes = "12";
                    break;

            }


            //año-mes-dia
            String nombre = textBoxNombre.Text;
            String apellido = textBoxApellido.Text;



            if (textBoxNumeroDocumento.Text != "")
            {
                int dni = int.Parse(textBoxNumeroDocumento.Text.Replace(".", ""));
                String fecha = textBoxAñoNac.Text + "/" + mes + "/" + comBoxDiaNac.Text;
                String telefono = textBoxCodigoPais.Text + "-" + textBoxNumeroTelefono.Text;
                int pais = int.Parse(comboBoxPaisEmisionDocu.SelectedValue.ToString());
                int tipoDoc = int.Parse(comboBoxTipoDocumento.SelectedValue.ToString());
                insertarDatosPersonales(nombre, apellido, dni, fecha, telefono, pais, tipoDoc);

            }
            else {
                MessageBox.Show("Ingrese DNI");
            }

            }
            else
            {
                MessageBox.Show("Debe aceptar los terminos y condiciones establecidos por la Empresa");

            }

        }

        // Forma de generar set y get ctrol k x luego la opcion prop
        public String propertyCorreo {
            get
            {
                return correo;
            }
            set
            {
                correo = value;
            }
        }

        public String propertyPassword
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        private void insertarDatosPersonales(String nombre, String apellido, int dni, String fecha, String telefono, int pais , int tipoDoc)
        {

            String[] usuario = propertyCorreo.Split('@');

            try
            {

            string insertPasajero = string.Format("INSERT INTO [LAFAST_gestor_de_reservas].[dbo].[pasajero] (id_tipo_documento, numero_documento, nombre ,apellido,telefono,email,id_categoria_pasajero,usuario,clave,cantidad_millas,calle,numero_calle,id_localidad_pasajero,fecha_nacimiento) VALUES ({0} , {1} ,'{2}' , '{3}' ,{4} , '{5}' ,{6} ,'{7}' ,'{8}' ,{9} ,'{10}' ,{11} , {12} , '{13}' );", tipoDoc, dni, nombre, apellido, telefono, propertyCorreo, 1, usuario[0], propertyPassword, 0, "N/A", 0, pais, fecha);

            Utilidades.Ejecutar(insertPasajero);

            string insertUsuario = string.Format("INSERT INTO [LAFAST_gestor_de_reservas].[dbo].[usuarios] (correo_usuario, pass_usuario) VALUES ('{0}' , '{1}');", propertyCorreo , propertyPassword);

            Utilidades.Ejecutar(insertUsuario);

            MessageBox.Show("Se registro el usuario");

            this.Close();
            
               
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Generar El usuario: ");
            }

                

        }
    }
}
