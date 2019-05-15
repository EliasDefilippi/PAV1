using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mi_Liberia_LF
{
    public partial class Error_txtBox : TextBox
    {
        public Error_txtBox()
        {
            InitializeComponent();
        }

        public Boolean Validar
        {
            set;
            get;
        }

        public Boolean SoloNumeros
        {
            set;
            get;
        }

        public Boolean SoloCaracteres
        {
            set;
            get;
        }

    }
}
