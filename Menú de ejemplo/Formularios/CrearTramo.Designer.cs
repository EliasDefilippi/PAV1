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
            this.comboBoxAeropuertoDestino = new System.Windows.Forms.ComboBox();
            this.textBoxDuracionTramo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAsignarVuelo = new System.Windows.Forms.Button();
            this.localidades = new Menú_de_ejemplo.localidades();
            this.localidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localidadesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.localidadesTableAdapter = new Menú_de_ejemplo.localidadesTableAdapters.localidadesTableAdapter();
            this.localidadesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.aeropuertosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeropuertosTableAdapter = new Menú_de_ejemplo.localidadesTableAdapters.aeropuertosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.localidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAeropuertoOrigen
            // 
            this.comboBoxAeropuertoOrigen.DataSource = this.aeropuertosBindingSource;
            this.comboBoxAeropuertoOrigen.DisplayMember = "nombre_aeropuerto";
            this.comboBoxAeropuertoOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAeropuertoOrigen.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAeropuertoOrigen.FormattingEnabled = true;
            this.comboBoxAeropuertoOrigen.Location = new System.Drawing.Point(53, 94);
            this.comboBoxAeropuertoOrigen.Name = "comboBoxAeropuertoOrigen";
            this.comboBoxAeropuertoOrigen.Size = new System.Drawing.Size(324, 28);
            this.comboBoxAeropuertoOrigen.TabIndex = 0;
            this.comboBoxAeropuertoOrigen.Text = "Seleccione el aeropuerto...";
            this.comboBoxAeropuertoOrigen.ValueMember = "id_aeropuerto";
            // 
            // comboBoxAeropuertoDestino
            // 
            this.comboBoxAeropuertoDestino.DataSource = this.aeropuertosBindingSource;
            this.comboBoxAeropuertoDestino.DisplayMember = "nombre_aeropuerto";
            this.comboBoxAeropuertoDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAeropuertoDestino.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAeropuertoDestino.FormattingEnabled = true;
            this.comboBoxAeropuertoDestino.Location = new System.Drawing.Point(53, 180);
            this.comboBoxAeropuertoDestino.Name = "comboBoxAeropuertoDestino";
            this.comboBoxAeropuertoDestino.Size = new System.Drawing.Size(324, 28);
            this.comboBoxAeropuertoDestino.TabIndex = 1;
            this.comboBoxAeropuertoDestino.Text = "Seleccione el aeropuerto...";
            this.comboBoxAeropuertoDestino.ValueMember = "id_aeropuerto";
            // 
            // textBoxDuracionTramo
            // 
            this.textBoxDuracionTramo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDuracionTramo.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDuracionTramo.Location = new System.Drawing.Point(53, 271);
            this.textBoxDuracionTramo.Name = "textBoxDuracionTramo";
            this.textBoxDuracionTramo.Size = new System.Drawing.Size(324, 26);
            this.textBoxDuracionTramo.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(53, 368);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 26);
            this.textBox1.TabIndex = 3;
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
            // localidades
            // 
            this.localidades.DataSetName = "localidades";
            this.localidades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // localidadesBindingSource
            // 
            this.localidadesBindingSource.DataSource = this.localidades;
            this.localidadesBindingSource.Position = 0;
            // 
            // localidadesBindingSource1
            // 
            this.localidadesBindingSource1.DataMember = "localidades";
            this.localidadesBindingSource1.DataSource = this.localidadesBindingSource;
            // 
            // localidadesTableAdapter
            // 
            this.localidadesTableAdapter.ClearBeforeFill = true;
            // 
            // localidadesBindingSource2
            // 
            this.localidadesBindingSource2.DataMember = "localidades";
            this.localidadesBindingSource2.DataSource = this.localidadesBindingSource;
            // 
            // aeropuertosBindingSource
            // 
            this.aeropuertosBindingSource.DataMember = "aeropuertos";
            this.aeropuertosBindingSource.DataSource = this.localidadesBindingSource;
            // 
            // aeropuertosTableAdapter
            // 
            this.aeropuertosTableAdapter.ClearBeforeFill = true;
            // 
            // CrearTramo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(412, 502);
            this.Controls.Add(this.buttonAsignarVuelo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxDuracionTramo);
            this.Controls.Add(this.comboBoxAeropuertoDestino);
            this.Controls.Add(this.comboBoxAeropuertoOrigen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearTramo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearTramo";
            this.Load += new System.EventHandler(this.CrearTramo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.localidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAeropuertoOrigen;
        private System.Windows.Forms.ComboBox comboBoxAeropuertoDestino;
        private System.Windows.Forms.TextBox textBoxDuracionTramo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAsignarVuelo;
        private System.Windows.Forms.BindingSource localidadesBindingSource;
        private localidades localidades;
        private System.Windows.Forms.BindingSource localidadesBindingSource1;
        private localidadesTableAdapters.localidadesTableAdapter localidadesTableAdapter;
        private System.Windows.Forms.BindingSource localidadesBindingSource2;
        private System.Windows.Forms.BindingSource aeropuertosBindingSource;
        private localidadesTableAdapters.aeropuertosTableAdapter aeropuertosTableAdapter;
    }
}