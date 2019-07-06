namespace Menú_de_ejemplo.Formularios
{
    partial class RegistrarLocalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarLocalidad));
            this.buttonConfirmarLocalidad = new System.Windows.Forms.Button();
            this.textBoxNombreLocalidad = new System.Windows.Forms.TextBox();
            this.comboBoxPaises = new System.Windows.Forms.ComboBox();
            this.paisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combox_localidad = new Menú_de_ejemplo.combox_localidad();
            this.aeropuertosDetinos = new Menú_de_ejemplo.aeropuertosDetinos();
            this.aeropuertosDetinosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paisesTableAdapter = new Menú_de_ejemplo.combox_localidadTableAdapters.paisesTableAdapter();
            this.botonCerrarVuelosDestinos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combox_localidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertosDetinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertosDetinosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConfirmarLocalidad
            // 
            this.buttonConfirmarLocalidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConfirmarLocalidad.BackgroundImage")));
            this.buttonConfirmarLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmarLocalidad.Location = new System.Drawing.Point(43, 252);
            this.buttonConfirmarLocalidad.Name = "buttonConfirmarLocalidad";
            this.buttonConfirmarLocalidad.Size = new System.Drawing.Size(334, 55);
            this.buttonConfirmarLocalidad.TabIndex = 0;
            this.buttonConfirmarLocalidad.UseVisualStyleBackColor = true;
            this.buttonConfirmarLocalidad.Click += new System.EventHandler(this.buttonConfirmarLocalidad_Click);
            // 
            // textBoxNombreLocalidad
            // 
            this.textBoxNombreLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombreLocalidad.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreLocalidad.Location = new System.Drawing.Point(56, 99);
            this.textBoxNombreLocalidad.Name = "textBoxNombreLocalidad";
            this.textBoxNombreLocalidad.Size = new System.Drawing.Size(321, 16);
            this.textBoxNombreLocalidad.TabIndex = 1;
            // 
            // comboBoxPaises
            // 
            this.comboBoxPaises.DataSource = this.paisesBindingSource;
            this.comboBoxPaises.DisplayMember = "nombre_pais";
            this.comboBoxPaises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPaises.FormattingEnabled = true;
            this.comboBoxPaises.Location = new System.Drawing.Point(56, 186);
            this.comboBoxPaises.Name = "comboBoxPaises";
            this.comboBoxPaises.Size = new System.Drawing.Size(321, 21);
            this.comboBoxPaises.TabIndex = 2;
            this.comboBoxPaises.ValueMember = "id_pais";
            // 
            // paisesBindingSource
            // 
            this.paisesBindingSource.DataMember = "paises";
            this.paisesBindingSource.DataSource = this.combox_localidad;
            // 
            // combox_localidad
            // 
            this.combox_localidad.DataSetName = "combox_localidad";
            this.combox_localidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aeropuertosDetinos
            // 
            this.aeropuertosDetinos.DataSetName = "aeropuertosDetinos";
            this.aeropuertosDetinos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aeropuertosDetinosBindingSource
            // 
            this.aeropuertosDetinosBindingSource.DataSource = this.aeropuertosDetinos;
            this.aeropuertosDetinosBindingSource.Position = 0;
            // 
            // paisesTableAdapter
            // 
            this.paisesTableAdapter.ClearBeforeFill = true;
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
            // RegistrarLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(428, 325);
            this.Controls.Add(this.botonCerrarVuelosDestinos);
            this.Controls.Add(this.comboBoxPaises);
            this.Controls.Add(this.textBoxNombreLocalidad);
            this.Controls.Add(this.buttonConfirmarLocalidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarLocalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarLocalidad";
            this.Load += new System.EventHandler(this.RegistrarLocalidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combox_localidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertosDetinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertosDetinosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmarLocalidad;
        private System.Windows.Forms.TextBox textBoxNombreLocalidad;
        private System.Windows.Forms.ComboBox comboBoxPaises;
        private System.Windows.Forms.BindingSource aeropuertosDetinosBindingSource;
        private aeropuertosDetinos aeropuertosDetinos;
        private combox_localidad combox_localidad;
        private System.Windows.Forms.BindingSource paisesBindingSource;
        private combox_localidadTableAdapters.paisesTableAdapter paisesTableAdapter;
        private System.Windows.Forms.Button botonCerrarVuelosDestinos;
    }
}