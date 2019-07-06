namespace Menú_de_ejemplo.Formularios
{
    partial class CrearVuelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearVuelo));
            this.buttonConfirmarVuelo = new System.Windows.Forms.Button();
            this.buttonCancelarCreacionVuelo = new System.Windows.Forms.Button();
            this.textBoxNumeroVuelo = new System.Windows.Forms.TextBox();
            this.dateTimeFechaVuelo = new System.Windows.Forms.DateTimePicker();
            this.comboBoxAvionVuelo = new System.Windows.Forms.ComboBox();
            this.comboBoxTarifaVuelo = new System.Windows.Forms.ComboBox();
            this.tarifasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combox_localidad = new Menú_de_ejemplo.combox_localidad();
            this.tarifasTableAdapter = new Menú_de_ejemplo.combox_localidadTableAdapters.tarifasTableAdapter();
            this.botonCerrarVuelosDestinos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tarifasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combox_localidad)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConfirmarVuelo
            // 
            this.buttonConfirmarVuelo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConfirmarVuelo.BackgroundImage")));
            this.buttonConfirmarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirmarVuelo.Location = new System.Drawing.Point(56, 431);
            this.buttonConfirmarVuelo.Name = "buttonConfirmarVuelo";
            this.buttonConfirmarVuelo.Size = new System.Drawing.Size(334, 55);
            this.buttonConfirmarVuelo.TabIndex = 0;
            this.buttonConfirmarVuelo.UseVisualStyleBackColor = true;
            this.buttonConfirmarVuelo.Click += new System.EventHandler(this.buttonConfirmarVuelo_Click);
            // 
            // buttonCancelarCreacionVuelo
            // 
            this.buttonCancelarCreacionVuelo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancelarCreacionVuelo.BackgroundImage")));
            this.buttonCancelarCreacionVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelarCreacionVuelo.Location = new System.Drawing.Point(56, 503);
            this.buttonCancelarCreacionVuelo.Name = "buttonCancelarCreacionVuelo";
            this.buttonCancelarCreacionVuelo.Size = new System.Drawing.Size(334, 55);
            this.buttonCancelarCreacionVuelo.TabIndex = 1;
            this.buttonCancelarCreacionVuelo.UseVisualStyleBackColor = true;
            this.buttonCancelarCreacionVuelo.Click += new System.EventHandler(this.buttonCancelarCreacionVuelo_Click);
            // 
            // textBoxNumeroVuelo
            // 
            this.textBoxNumeroVuelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumeroVuelo.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroVuelo.Location = new System.Drawing.Point(56, 99);
            this.textBoxNumeroVuelo.Name = "textBoxNumeroVuelo";
            this.textBoxNumeroVuelo.Size = new System.Drawing.Size(320, 19);
            this.textBoxNumeroVuelo.TabIndex = 2;
            // 
            // dateTimeFechaVuelo
            // 
            this.dateTimeFechaVuelo.CalendarFont = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFechaVuelo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFechaVuelo.Location = new System.Drawing.Point(56, 274);
            this.dateTimeFechaVuelo.Name = "dateTimeFechaVuelo";
            this.dateTimeFechaVuelo.Size = new System.Drawing.Size(320, 23);
            this.dateTimeFechaVuelo.TabIndex = 3;
            // 
            // comboBoxAvionVuelo
            // 
            this.comboBoxAvionVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAvionVuelo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAvionVuelo.FormattingEnabled = true;
            this.comboBoxAvionVuelo.Location = new System.Drawing.Point(56, 183);
            this.comboBoxAvionVuelo.Name = "comboBoxAvionVuelo";
            this.comboBoxAvionVuelo.Size = new System.Drawing.Size(320, 24);
            this.comboBoxAvionVuelo.TabIndex = 4;
            // 
            // comboBoxTarifaVuelo
            // 
            this.comboBoxTarifaVuelo.DataSource = this.tarifasBindingSource;
            this.comboBoxTarifaVuelo.DisplayMember = "clase_tarifa";
            this.comboBoxTarifaVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTarifaVuelo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTarifaVuelo.FormattingEnabled = true;
            this.comboBoxTarifaVuelo.Location = new System.Drawing.Point(56, 367);
            this.comboBoxTarifaVuelo.Name = "comboBoxTarifaVuelo";
            this.comboBoxTarifaVuelo.Size = new System.Drawing.Size(320, 24);
            this.comboBoxTarifaVuelo.TabIndex = 5;
            this.comboBoxTarifaVuelo.ValueMember = "id_tarifa";
            // 
            // tarifasBindingSource
            // 
            this.tarifasBindingSource.DataMember = "tarifas";
            this.tarifasBindingSource.DataSource = this.combox_localidad;
            // 
            // combox_localidad
            // 
            this.combox_localidad.DataSetName = "combox_localidad";
            this.combox_localidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tarifasTableAdapter
            // 
            this.tarifasTableAdapter.ClearBeforeFill = true;
            // 
            // botonCerrarVuelosDestinos
            // 
            this.botonCerrarVuelosDestinos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonCerrarVuelosDestinos.BackgroundImage")));
            this.botonCerrarVuelosDestinos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCerrarVuelosDestinos.Location = new System.Drawing.Point(366, 12);
            this.botonCerrarVuelosDestinos.Name = "botonCerrarVuelosDestinos";
            this.botonCerrarVuelosDestinos.Size = new System.Drawing.Size(50, 35);
            this.botonCerrarVuelosDestinos.TabIndex = 12;
            this.botonCerrarVuelosDestinos.UseVisualStyleBackColor = true;
            this.botonCerrarVuelosDestinos.Click += new System.EventHandler(this.botonCerrarVuelosDestinos_Click);
            // 
            // CrearVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(428, 580);
            this.Controls.Add(this.botonCerrarVuelosDestinos);
            this.Controls.Add(this.comboBoxTarifaVuelo);
            this.Controls.Add(this.comboBoxAvionVuelo);
            this.Controls.Add(this.dateTimeFechaVuelo);
            this.Controls.Add(this.textBoxNumeroVuelo);
            this.Controls.Add(this.buttonCancelarCreacionVuelo);
            this.Controls.Add(this.buttonConfirmarVuelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearVuelo";
            this.Load += new System.EventHandler(this.CrearVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tarifasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combox_localidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmarVuelo;
        private System.Windows.Forms.Button buttonCancelarCreacionVuelo;
        private System.Windows.Forms.TextBox textBoxNumeroVuelo;
        private System.Windows.Forms.DateTimePicker dateTimeFechaVuelo;
        private System.Windows.Forms.ComboBox comboBoxAvionVuelo;
        private System.Windows.Forms.ComboBox comboBoxTarifaVuelo;
        private combox_localidad combox_localidad;
        private System.Windows.Forms.BindingSource tarifasBindingSource;
        private combox_localidadTableAdapters.tarifasTableAdapter tarifasTableAdapter;
        private System.Windows.Forms.Button botonCerrarVuelosDestinos;
    }
}