namespace Menú_de_ejemplo.Formularios
{
    partial class CrearTramo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearTramo));
            this.comboBoxAeropuertoOrigen = new System.Windows.Forms.ComboBox();
            this.aeropuertosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeropuertos = new Menú_de_ejemplo.aeropuertos();
            this.comboBoxAeropuertoDestino = new System.Windows.Forms.ComboBox();
            this.aeropuertosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aeropuertosDetinos = new Menú_de_ejemplo.aeropuertosDetinos();
            this.textBoxDuracionTramo = new System.Windows.Forms.TextBox();
            this.tbx_distancia = new System.Windows.Forms.TextBox();
            this.buttonAsignarVuelo = new System.Windows.Forms.Button();
            this.combox_localidad = new Menú_de_ejemplo.combox_localidad();
            this.comboxlocalidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeropuertosTableAdapter = new Menú_de_ejemplo.aeropuertosTableAdapters.aeropuertosTableAdapter();
            this.aeropuertosTableAdapter1 = new Menú_de_ejemplo.aeropuertosDetinosTableAdapters.aeropuertosTableAdapter();
            this.botonCerrarVuelosDestinos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertosDetinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combox_localidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboxlocalidadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAeropuertoOrigen
            // 
            this.comboBoxAeropuertoOrigen.DataSource = this.aeropuertosBindingSource;
            this.comboBoxAeropuertoOrigen.DisplayMember = "nombre_aeropuerto";
            this.comboBoxAeropuertoOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAeropuertoOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAeropuertoOrigen.FormattingEnabled = true;
            this.comboBoxAeropuertoOrigen.Location = new System.Drawing.Point(53, 94);
            this.comboBoxAeropuertoOrigen.Name = "comboBoxAeropuertoOrigen";
            this.comboBoxAeropuertoOrigen.Size = new System.Drawing.Size(324, 28);
            this.comboBoxAeropuertoOrigen.TabIndex = 0;
            this.comboBoxAeropuertoOrigen.ValueMember = "id_aeropuerto";
            // 
            // aeropuertosBindingSource
            // 
            this.aeropuertosBindingSource.DataMember = "aeropuertos";
            this.aeropuertosBindingSource.DataSource = this.aeropuertos;
            // 
            // aeropuertos
            // 
            this.aeropuertos.DataSetName = "aeropuertos";
            this.aeropuertos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxAeropuertoDestino
            // 
            this.comboBoxAeropuertoDestino.DataSource = this.aeropuertosBindingSource1;
            this.comboBoxAeropuertoDestino.DisplayMember = "nombre_aeropuerto";
            this.comboBoxAeropuertoDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAeropuertoDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAeropuertoDestino.FormattingEnabled = true;
            this.comboBoxAeropuertoDestino.Location = new System.Drawing.Point(53, 180);
            this.comboBoxAeropuertoDestino.Name = "comboBoxAeropuertoDestino";
            this.comboBoxAeropuertoDestino.Size = new System.Drawing.Size(324, 28);
            this.comboBoxAeropuertoDestino.TabIndex = 1;
            this.comboBoxAeropuertoDestino.ValueMember = "id_aeropuerto";
            // 
            // aeropuertosBindingSource1
            // 
            this.aeropuertosBindingSource1.DataMember = "aeropuertos";
            this.aeropuertosBindingSource1.DataSource = this.aeropuertosDetinos;
            // 
            // aeropuertosDetinos
            // 
            this.aeropuertosDetinos.DataSetName = "aeropuertosDetinos";
            this.aeropuertosDetinos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxDuracionTramo
            // 
            this.textBoxDuracionTramo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDuracionTramo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDuracionTramo.Location = new System.Drawing.Point(53, 271);
            this.textBoxDuracionTramo.Name = "textBoxDuracionTramo";
            this.textBoxDuracionTramo.Size = new System.Drawing.Size(324, 24);
            this.textBoxDuracionTramo.TabIndex = 2;
            // 
            // tbx_distancia
            // 
            this.tbx_distancia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_distancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_distancia.Location = new System.Drawing.Point(53, 368);
            this.tbx_distancia.Name = "tbx_distancia";
            this.tbx_distancia.Size = new System.Drawing.Size(324, 24);
            this.tbx_distancia.TabIndex = 3;
            // 
            // buttonAsignarVuelo
            // 
            this.buttonAsignarVuelo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAsignarVuelo.BackgroundImage")));
            this.buttonAsignarVuelo.Location = new System.Drawing.Point(53, 435);
            this.buttonAsignarVuelo.Name = "buttonAsignarVuelo";
            this.buttonAsignarVuelo.Size = new System.Drawing.Size(334, 55);
            this.buttonAsignarVuelo.TabIndex = 4;
            this.buttonAsignarVuelo.UseVisualStyleBackColor = true;
            this.buttonAsignarVuelo.Click += new System.EventHandler(this.buttonAsignarVuelo_Click);
            // 
            // combox_localidad
            // 
            this.combox_localidad.DataSetName = "combox_localidad";
            this.combox_localidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboxlocalidadBindingSource
            // 
            this.comboxlocalidadBindingSource.DataSource = this.combox_localidad;
            this.comboxlocalidadBindingSource.Position = 0;
            // 
            // aeropuertosTableAdapter
            // 
            this.aeropuertosTableAdapter.ClearBeforeFill = true;
            // 
            // aeropuertosTableAdapter1
            // 
            this.aeropuertosTableAdapter1.ClearBeforeFill = true;
            // 
            // botonCerrarVuelosDestinos
            // 
            this.botonCerrarVuelosDestinos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonCerrarVuelosDestinos.BackgroundImage")));
            this.botonCerrarVuelosDestinos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCerrarVuelosDestinos.Location = new System.Drawing.Point(359, 12);
            this.botonCerrarVuelosDestinos.Name = "botonCerrarVuelosDestinos";
            this.botonCerrarVuelosDestinos.Size = new System.Drawing.Size(50, 35);
            this.botonCerrarVuelosDestinos.TabIndex = 12;
            this.botonCerrarVuelosDestinos.UseVisualStyleBackColor = true;
            this.botonCerrarVuelosDestinos.Click += new System.EventHandler(this.botonCerrarVuelosDestinos_Click);
            // 
            // CrearTramo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(412, 502);
            this.Controls.Add(this.botonCerrarVuelosDestinos);
            this.Controls.Add(this.buttonAsignarVuelo);
            this.Controls.Add(this.tbx_distancia);
            this.Controls.Add(this.textBoxDuracionTramo);
            this.Controls.Add(this.comboBoxAeropuertoDestino);
            this.Controls.Add(this.comboBoxAeropuertoOrigen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearTramo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearTramo";
            this.Load += new System.EventHandler(this.CrearTramo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertosDetinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combox_localidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboxlocalidadBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAeropuertoOrigen;
        private System.Windows.Forms.ComboBox comboBoxAeropuertoDestino;
        private System.Windows.Forms.TextBox textBoxDuracionTramo;
        private System.Windows.Forms.TextBox tbx_distancia;
        private System.Windows.Forms.Button buttonAsignarVuelo;
        private combox_localidad combox_localidad;
        private System.Windows.Forms.BindingSource comboxlocalidadBindingSource;
        private aeropuertos aeropuertos;
        private System.Windows.Forms.BindingSource aeropuertosBindingSource;
        private aeropuertosTableAdapters.aeropuertosTableAdapter aeropuertosTableAdapter;
        private aeropuertosDetinos aeropuertosDetinos;
        private System.Windows.Forms.BindingSource aeropuertosBindingSource1;
        private aeropuertosDetinosTableAdapters.aeropuertosTableAdapter aeropuertosTableAdapter1;
        private System.Windows.Forms.Button botonCerrarVuelosDestinos;
    }
}