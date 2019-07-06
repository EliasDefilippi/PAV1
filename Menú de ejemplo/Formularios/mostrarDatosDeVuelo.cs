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
    public partial class mostrarDatosDeVuelo : Form
    {
        private DateTime fecha_salida_vuelo;
        private int aeropuertoOrigen;
        private int aeropuertoDestino;
        private int id_vuelo_salida;
        private int id_vuelo_vuelta;
        private DataGridViewSelectedRowCollection idAsientoIda;
        private DataGridViewSelectedRowCollection idAsientoVuelta;
        private DateTime fecha_salida_ida;
        private string NombreAeropuertoDestino;
        private String NombreAeropuertoOrigen;
        private int cantidad;
        private String asientoidaId;
        private String asientoVueltaId;
        private int precioIdaUnitario;
        private int precioVueltaUnitario;

        public mostrarDatosDeVuelo(DateTime fecha_salida, int aeropuertoOrigen, int aeropuertoDestino, int id_vuelo_salida, int id_vuelo_vuelta, DataGridViewSelectedRowCollection id_asiento_ida, DataGridViewSelectedRowCollection id_asiento_vuelta, DateTime fecha_salida_ida,int  precioIda, int precioVueltas, String aeropuertoOrigenNombre, String aeropuertoNombreDesstino)
        {



            InitializeComponent();
            inicializarCombo();

            this.precioIdaUnitario = precioIda;
           this.precioVueltaUnitario = precioVueltas;

                fechaSalida.Text = fechaSalida.Text + fecha_salida_ida.ToString("dd-MM-yyyy");
            fechaSalida.Text += Environment.NewLine;

            fechaVuelta.Text = fechaVuelta.Text + fecha_salida.ToString("dd-MM-yyyy");
            fechaVuelta.Text += Environment.NewLine;

            aeroOrigen.Text = aeroOrigen.Text + aeropuertoOrigenNombre;
            aeroOrigen.Text += Environment.NewLine;

            aeroDestino.Text = aeroDestino.Text + aeropuertoNombreDesstino;
            aeroDestino.Text += Environment.NewLine;

            nroVueloVuelta.Text = nroVueloVuelta.Text + id_vuelo_vuelta;
            nroVueloVuelta.Text += Environment.NewLine;

            nroVuelo.Text = nroVuelo.Text + id_vuelo_salida;
            nroVuelo.Text += Environment.NewLine;

            aeroOrigenVuelta.Text = aeroOrigenVuelta.Text + aeropuertoNombreDesstino; 
            aeroOrigenVuelta.Text += Environment.NewLine;

             aeroDestinoVuelta.Text = aeroDestinoVuelta.Text + aeropuertoOrigenNombre;
             aeroDestinoVuelta.Text += Environment.NewLine;
            this.cantidad = 0;
            asientoidaId = "";
            asientoVueltaId = "";
            foreach (DataGridViewRow item in  id_asiento_ida)
            {


                asientoVueltaId = asientoVueltaId + (item.Cells[2].Value + ",");
                asientoVuelta.Text = asientoVuelta.Text + (item.Cells[0].Value) + (item.Cells[1].Value);
                asientoVuelta.Text += Environment.NewLine;
               
                Precio.Text = Precio.Text + precioIda;
                Precio.Text += Environment.NewLine;
                this.cantidad = this.cantidad + precioIda;


            }
    
           
            foreach (DataGridViewRow item in id_asiento_vuelta)
                {
                idAsiento.Text = idAsiento.Text +(item.Cells[0].Value) + (item.Cells[1].Value);
                idAsiento.Text += Environment.NewLine;
                asientoidaId = asientoidaId + (item.Cells[2].Value + ",");
                precioVuelta.Text = precioVuelta.Text + precioVueltas;
                precioVuelta.Text += Environment.NewLine;
                this.cantidad = this.cantidad + precioVueltas;
            }
            asientoidaId = asientoidaId.Substring(0, asientoidaId.Length - 1);
            asientoVueltaId = asientoVueltaId.Substring(0, asientoVueltaId.Length - 1);

            lbltotal.Text = "$ "+Convert.ToString(this.cantidad);

            fecha_salida_vuelo = fecha_salida;
            this.aeropuertoOrigen = aeropuertoOrigen;
            this.aeropuertoDestino = aeropuertoDestino;
            this.id_vuelo_salida = id_vuelo_salida;
            this.id_vuelo_vuelta = id_vuelo_vuelta;

            idAsientoVuelta = id_asiento_vuelta;
            this.fecha_salida_ida = fecha_salida_ida;
            idAsientoIda = id_asiento_ida;

        }

        

        private void inicializarCombo()
        {
            string cmd = string.Format("SELECT id_tipo_documento,desc_tipo_doc FROM[LAFAST_gestor_de_reservas].[dbo].[tipo_documento]; ");

            DataSet dt = Utilidades.Ejecutar(cmd);

            DataTable customerTable = dt.Tables[0];
             cmbTipo.DataSource = customerTable;
           
            cmbTipo.DisplayMember = customerTable.Columns["desc_tipo_doc"].ToString().Trim();
            cmbTipo.ValueMember = customerTable.Columns["id_tipo_documento"].ToString().Trim();
           
            cmbTipo.SelectedIndex = 0;

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mostrarDatosDeVuelo_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public int propertyCantidad
        {
            get { return cantidad; }

            set { cantidad = value; }
        }
        public DateTime propertyFecha_salida_ida
        {
            get { return fecha_salida_ida; }

            set { fecha_salida_ida = value; }
        }

        public DateTime propertyFecha_salida_vuelo
        {
            get { return fecha_salida_vuelo; }

            set { fecha_salida_vuelo = value; }
        }

        public int propertyAeropuertoOrigen
        {
            get { return aeropuertoOrigen; }

            set { aeropuertoOrigen = value; }
        }

        public int propertyAeropuertoDestino
        {
            get { return aeropuertoDestino; }

            set { aeropuertoDestino = value; }
        }

        public int propertyId_vuelo_salida
        {
            get { return id_vuelo_salida; }

            set { id_vuelo_salida = value; }
        }

        public int propertyId_vuelo_vuelta
        {
            get { return id_vuelo_vuelta; }

            set { id_vuelo_vuelta = value; }
        }

        public DataGridViewSelectedRowCollection propertyIdAsientoIda
        {
            get { return idAsientoIda; }

            set { idAsientoIda = value; }
        }

        public DataGridViewSelectedRowCollection propertyIdAsientoVuelta
        {
            get { return idAsientoVuelta; }

            set { idAsientoVuelta = value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public String propertyNombreAeropuertoDestino
        {
            get { return NombreAeropuertoDestino; }

            set { NombreAeropuertoDestino = value; }
        }


        public String  propertyNombreAeropuertoOrigen
        {
            get { return NombreAeropuertoOrigen; }

            set { NombreAeropuertoOrigen = value; }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            



                                       int idtipoDocumento = int.Parse(cmbTipo.SelectedValue.ToString());

            if (textBoxNumeroDocumento.Text != "") { 
                                int nroDocumento = int.Parse(textBoxNumeroDocumento.Text);
                                      

                                       String[] partesAsiento =   asientoidaId.Split(',');

                                        Random rnd = new Random();
                                        int codigo = int.Parse(idtipoDocumento + rnd.Next(1, 300)+ partesAsiento[0]);
                                        string insertReservaIda = string.Format("INSERT INTO dbo.reservas(id_tipo_documento_titular, numero_documento_titular, fecha_reserva, fecha_salida, id_estado_reserva, costo_total, observacion,codigo) VALUES({0},{1},getdate(),'{2}',{3} ,{4} ,'{5}',{6})", idtipoDocumento, nroDocumento, fecha_salida_ida.ToString("yyyy-MM-dd"), 2,propertyCantidad,"", codigo);

                                       Utilidades.Ejecutar(insertReservaIda);

                                       String idReserva = string.Format("SELECT id_reserva FROM DBO.reservas WHERE id_tipo_documento_titular ={0} AND numero_documento_titular ={1} AND fecha_salida = '{2}'", idtipoDocumento, nroDocumento, fecha_salida_ida.ToString("yyyy-MM-dd"));

                                       DataSet dt = Utilidades.Ejecutar(idReserva);

                                       int idReservaInsertado = int.Parse(dt.Tables[0].Rows[0]["id_reserva"].ToString().Trim());
                           
                                          for(int i = 0; i< partesAsiento.Length; i++) {

                                        string insertDetalle = string.Format(" INSERT INTO dbo.detalle_reserva(id_reserva, id_tipo_documento_titular_reserva, numero_documento_titular_reserva, id_tipo_documento_pasajero, numero_documento_pasajero, costo_unitario, id_aeropuerto_origen, id_aeropuerto_destino,id_asiento,id_vuelo)VALUES({0},{1},{2},{3},{4},{5},{6},{7},{8},{9})", idReservaInsertado,idtipoDocumento,nroDocumento,idtipoDocumento,nroDocumento, precioIdaUnitario, aeropuertoOrigen, aeropuertoDestino, int.Parse(partesAsiento[i]),id_vuelo_salida);

                                        Utilidades.Ejecutar(insertDetalle);

                                                    }

                                String[] partesAsientoVuelta = asientoVueltaId.Split(',');

                                string insertReservaVuelta = string.Format("INSERT INTO dbo.reservas(id_tipo_documento_titular, numero_documento_titular, fecha_reserva, fecha_salida, id_estado_reserva, costo_total, observacion,codigo) VALUES({0},{1},getdate(),'{2}',{3} ,{4} ,'{5}',{6})", idtipoDocumento, nroDocumento, fecha_salida_vuelo.ToString("yyyy-MM-dd"), 2, propertyCantidad, "",codigo);

                                Utilidades.Ejecutar(insertReservaVuelta);

                                String idReservaVuelta = string.Format("SELECT id_reserva FROM DBO.reservas WHERE id_tipo_documento_titular ={0} AND numero_documento_titular ={1} AND fecha_salida = '{2}'", idtipoDocumento, nroDocumento, fecha_salida_vuelo.ToString("yyyy-MM-dd"));

                                DataSet dts = Utilidades.Ejecutar(idReservaVuelta);

                                int idReservaInsertadoVuelta = int.Parse(dts.Tables[0].Rows[0]["id_reserva"].ToString().Trim());

                                for (int i = 0; i < partesAsiento.Length; i++)
                                {

                                    string insertDetalleVuelta = string.Format(" INSERT INTO dbo.detalle_reserva(id_reserva, id_tipo_documento_titular_reserva, numero_documento_titular_reserva, id_tipo_documento_pasajero, numero_documento_pasajero, costo_unitario, id_aeropuerto_origen, id_aeropuerto_destino,id_asiento,id_vuelo)VALUES({0},{1},{2},{3},{4},{5},{6},{7},{8},{9})", idReservaInsertadoVuelta, idtipoDocumento, nroDocumento, idtipoDocumento, nroDocumento, precioVueltaUnitario, aeropuertoDestino, aeropuertoOrigen, int.Parse(partesAsientoVuelta[i]),id_vuelo_vuelta);

                                    Utilidades.Ejecutar(insertDetalleVuelta);

                                }

                                formCodigoReserva pantallaReservaFinalizada = new formCodigoReserva(codigo);
                                    pantallaReservaFinalizada.Show();

                                this.Close();
            }
            else
            {

                MessageBox.Show("Ingrese el número de documento del titular de la reserva");
                textBoxNumeroDocumento.Focus();
            }
        }
    }
}
