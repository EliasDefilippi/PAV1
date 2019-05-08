namespace Menú_de_ejemplo
{
    partial class buscarVuelosYdestinos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscarVuelosYdestinos));
            this.botonBuscarVuelos = new System.Windows.Forms.Button();
            this.checkBoxIdaYvuelta = new System.Windows.Forms.CheckBox();
            this.checkBoxIda = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBoxOrigen = new System.Windows.Forms.ComboBox();
            this.localidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboxlocalidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combox_localidad = new Menú_de_ejemplo.combox_localidad();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.comboBoxPasajeros = new System.Windows.Forms.ComboBox();
            this.comboBoxCabina = new System.Windows.Forms.ComboBox();
            this.categoriapasajeroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboxlocalidadBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxCodigoPromocional = new System.Windows.Forms.TextBox();
            this.dateTimeIDA = new System.Windows.Forms.DateTimePicker();
            this.dateTimeVUELTA = new System.Windows.Forms.DateTimePicker();
            this.botonCerrarVuelosDestinos = new System.Windows.Forms.Button();
            this.localidadesTableAdapter = new Menú_de_ejemplo.combox_localidadTableAdapters.localidadesTableAdapter();
            this.categoria_pasajeroTableAdapter = new Menú_de_ejemplo.combox_localidadTableAdapters.categoria_pasajeroTableAdapter();
            this.comboxlocalidadBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.localidades2 = new Menú_de_ejemplo.localidades2();
            this.localidadesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.localidadesTableAdapter1 = new Menú_de_ejemplo.localidades2TableAdapters.localidadesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboxlocalidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combox_localidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriapasajeroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboxlocalidadBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboxlocalidadBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidades2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonBuscarVuelos
            // 
            this.botonBuscarVuelos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonBuscarVuelos.BackgroundImage")));
            this.botonBuscarVuelos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botonBuscarVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonBuscarVuelos.Location = new System.Drawing.Point(212, 388);
            this.botonBuscarVuelos.Name = "botonBuscarVuelos";
            this.botonBuscarVuelos.Size = new System.Drawing.Size(294, 52);
            this.botonBuscarVuelos.TabIndex = 0;
            this.botonBuscarVuelos.UseVisualStyleBackColor = true;
            // 
            // checkBoxIdaYvuelta
            // 
            this.checkBoxIdaYvuelta.AutoSize = true;
            this.checkBoxIdaYvuelta.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxIdaYvuelta.Location = new System.Drawing.Point(23, 127);
            this.checkBoxIdaYvuelta.Name = "checkBoxIdaYvuelta";
            this.checkBoxIdaYvuelta.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIdaYvuelta.TabIndex = 1;
            this.checkBoxIdaYvuelta.UseVisualStyleBackColor = false;
            // 
            // checkBoxIda
            // 
            this.checkBoxIda.AutoSize = true;
            this.checkBoxIda.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxIda.Location = new System.Drawing.Point(191, 127);
            this.checkBoxIda.Name = "checkBoxIda";
            this.checkBoxIda.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIda.TabIndex = 2;
            this.checkBoxIda.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(23, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(12, 11);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBoxOrigen
            // 
            this.comboBoxOrigen.DataSource = this.localidadesBindingSource;
            this.comboBoxOrigen.DisplayMember = "nombre_localidad";
            this.comboBoxOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxOrigen.FormattingEnabled = true;
            this.comboBoxOrigen.Location = new System.Drawing.Point(23, 81);
            this.comboBoxOrigen.Name = "comboBoxOrigen";
            this.comboBoxOrigen.Size = new System.Drawing.Size(291, 21);
            this.comboBoxOrigen.TabIndex = 4;
            this.comboBoxOrigen.ValueMember = "id_localidad";
            this.comboBoxOrigen.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrigen_SelectedIndexChanged);
            // 
            // localidadesBindingSource
            // 
            this.localidadesBindingSource.DataMember = "localidades";
            this.localidadesBindingSource.DataSource = this.comboxlocalidadBindingSource;
            // 
            // comboxlocalidadBindingSource
            // 
            this.comboxlocalidadBindingSource.DataSource = this.combox_localidad;
            this.comboxlocalidadBindingSource.Position = 0;
            // 
            // combox_localidad
            // 
            this.combox_localidad.DataSetName = "combox_localidad";
            this.combox_localidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.DataSource = this.localidadesBindingSource1;
            this.comboBoxDestino.DisplayMember = "nombre_localidad";
            this.comboBoxDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(392, 81);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(293, 21);
            this.comboBoxDestino.TabIndex = 5;
            this.comboBoxDestino.ValueMember = "id_localidad";
            // 
            // comboBoxPasajeros
            // 
            this.comboBoxPasajeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPasajeros.FormattingEnabled = true;
            this.comboBoxPasajeros.Location = new System.Drawing.Point(23, 261);
            this.comboBoxPasajeros.Name = "comboBoxPasajeros";
            this.comboBoxPasajeros.Size = new System.Drawing.Size(291, 21);
            this.comboBoxPasajeros.TabIndex = 6;
            // 
            // comboBoxCabina
            // 
            this.comboBoxCabina.DataSource = this.categoriapasajeroBindingSource;
            this.comboBoxCabina.DisplayMember = "desc_categoria";
            this.comboBoxCabina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCabina.FormattingEnabled = true;
            this.comboBoxCabina.Location = new System.Drawing.Point(392, 261);
            this.comboBoxCabina.Name = "comboBoxCabina";
            this.comboBoxCabina.Size = new System.Drawing.Size(293, 21);
            this.comboBoxCabina.TabIndex = 7;
            this.comboBoxCabina.ValueMember = "id_categoria";
            // 
            // categoriapasajeroBindingSource
            // 
            this.categoriapasajeroBindingSource.DataMember = "categoria_pasajero";
            this.categoriapasajeroBindingSource.DataSource = this.comboxlocalidadBindingSource1;
            // 
            // comboxlocalidadBindingSource1
            // 
            this.comboxlocalidadBindingSource1.DataSource = this.combox_localidad;
            this.comboxlocalidadBindingSource1.Position = 0;
            // 
            // textBoxCodigoPromocional
            // 
            this.textBoxCodigoPromocional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCodigoPromocional.Location = new System.Drawing.Point(23, 334);
            this.textBoxCodigoPromocional.Multiline = true;
            this.textBoxCodigoPromocional.Name = "textBoxCodigoPromocional";
            this.textBoxCodigoPromocional.Size = new System.Drawing.Size(291, 24);
            this.textBoxCodigoPromocional.TabIndex = 8;
            // 
            // dateTimeIDA
            // 
            this.dateTimeIDA.Location = new System.Drawing.Point(23, 186);
            this.dateTimeIDA.Name = "dateTimeIDA";
            this.dateTimeIDA.Size = new System.Drawing.Size(291, 20);
            this.dateTimeIDA.TabIndex = 9;
            // 
            // dateTimeVUELTA
            // 
            this.dateTimeVUELTA.Location = new System.Drawing.Point(392, 186);
            this.dateTimeVUELTA.MinDate = new System.DateTime(2019, 4, 19, 0, 0, 0, 0);
            this.dateTimeVUELTA.Name = "dateTimeVUELTA";
            this.dateTimeVUELTA.Size = new System.Drawing.Size(293, 20);
            this.dateTimeVUELTA.TabIndex = 10;
            // 
            // botonCerrarVuelosDestinos
            // 
            this.botonCerrarVuelosDestinos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonCerrarVuelosDestinos.BackgroundImage")));
            this.botonCerrarVuelosDestinos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCerrarVuelosDestinos.Location = new System.Drawing.Point(644, 11);
            this.botonCerrarVuelosDestinos.Name = "botonCerrarVuelosDestinos";
            this.botonCerrarVuelosDestinos.Size = new System.Drawing.Size(50, 35);
            this.botonCerrarVuelosDestinos.TabIndex = 11;
            this.botonCerrarVuelosDestinos.UseVisualStyleBackColor = true;
            this.botonCerrarVuelosDestinos.Click += new System.EventHandler(this.botonCerrarVuelosDestinos_Click);
            // 
            // localidadesTableAdapter
            // 
            this.localidadesTableAdapter.ClearBeforeFill = true;
            // 
            // categoria_pasajeroTableAdapter
            // 
            this.categoria_pasajeroTableAdapter.ClearBeforeFill = true;
            // 
            // comboxlocalidadBindingSource2
            // 
            this.comboxlocalidadBindingSource2.DataSource = this.combox_localidad;
            this.comboxlocalidadBindingSource2.Position = 0;
            // 
            // localidades2
            // 
            this.localidades2.DataSetName = "localidades2";
            this.localidades2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // localidadesBindingSource1
            // 
            this.localidadesBindingSource1.DataMember = "localidades";
            this.localidadesBindingSource1.DataSource = this.localidades2;
            // 
            // localidadesTableAdapter1
            // 
            this.localidadesTableAdapter1.ClearBeforeFill = true;
            // 
            // buscarVuelosYdestinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(714, 460);
            this.Controls.Add(this.botonCerrarVuelosDestinos);
            this.Controls.Add(this.dateTimeVUELTA);
            this.Controls.Add(this.dateTimeIDA);
            this.Controls.Add(this.textBoxCodigoPromocional);
            this.Controls.Add(this.comboBoxCabina);
            this.Controls.Add(this.comboBoxPasajeros);
            this.Controls.Add(this.comboBoxDestino);
            this.Controls.Add(this.comboBoxOrigen);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBoxIda);
            this.Controls.Add(this.checkBoxIdaYvuelta);
            this.Controls.Add(this.botonBuscarVuelos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "buscarVuelosYdestinos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "buscarVuelosYdestinos";
            this.Load += new System.EventHandler(this.buscarVuelosYdestinos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboxlocalidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combox_localidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriapasajeroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboxlocalidadBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboxlocalidadBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidades2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonBuscarVuelos;
        private System.Windows.Forms.CheckBox checkBoxIdaYvuelta;
        private System.Windows.Forms.CheckBox checkBoxIda;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBoxOrigen;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.ComboBox comboBoxPasajeros;
        private System.Windows.Forms.ComboBox comboBoxCabina;
        private System.Windows.Forms.TextBox textBoxCodigoPromocional;
        private System.Windows.Forms.DateTimePicker dateTimeIDA;
        private System.Windows.Forms.DateTimePicker dateTimeVUELTA;
        private System.Windows.Forms.Button botonCerrarVuelosDestinos;
        private System.Windows.Forms.BindingSource comboxlocalidadBindingSource;
        private combox_localidad combox_localidad;
        private System.Windows.Forms.BindingSource localidadesBindingSource;
        private combox_localidadTableAdapters.localidadesTableAdapter localidadesTableAdapter;
        private System.Windows.Forms.BindingSource comboxlocalidadBindingSource1;
        private System.Windows.Forms.BindingSource categoriapasajeroBindingSource;
        private combox_localidadTableAdapters.categoria_pasajeroTableAdapter categoria_pasajeroTableAdapter;
        private System.Windows.Forms.BindingSource comboxlocalidadBindingSource2;
        private localidades2 localidades2;
        private System.Windows.Forms.BindingSource localidadesBindingSource1;
        private localidades2TableAdapters.localidadesTableAdapter localidadesTableAdapter1;
    }
}