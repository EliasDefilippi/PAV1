using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mi_Liberia_LF
{
    public class Utilidades
    {

        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=LAFAST_gestor_de_reservas;Integrated Security=True");
            conexion.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, conexion);

            DP.Fill(DS);

            conexion.Close();

            return DS;
        }

        public static Boolean ValidarFormulario(Control objeto, ErrorProvider ErrorProvider)
        {
            Boolean HayErrores = false;

            foreach (Control item in objeto.Controls)
            {
                if (item is Error_txtBox)
                {
                    Error_txtBox obj = (Error_txtBox)item;

                    if (obj.Validar == true)
                    {
                        if (string.IsNullOrEmpty(obj.Text.Trim()))
                        {
                            ErrorProvider.SetError(obj, "No puede estar vacio.");
                            HayErrores = true;
                        }
                    }
                    if (obj.SoloNumeros == true)
                    {
                        int cont = 0, letrasEnconradas = 0;

                        foreach (char letra in obj.Text.Trim())
                        {
                            if (char.IsLetter(obj.Text.Trim(), cont))
                            {
                                letrasEnconradas++;
                            }
                            cont++;
                        }
                        if (letrasEnconradas != 0)
                        {
                            HayErrores = true;
                            ErrorProvider.SetError(obj, "Se aceptan solo numeros.");
                        }
                    }
                }
            }
            return HayErrores;
        }

    }
}
