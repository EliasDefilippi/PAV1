namespace Menú_de_ejemplo.Formularios
{
    partial class EliminarAeropuerto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarAeropuerto));
            this.buttonConfirmarElimAero = new System.Windows.Forms.Button();
            this.buttonCancelarElimAero = new System.Windows.Forms.Button();
            this.comboBoxElimAero = new System.Windows.Forms.ComboBox();
            this.aeropuertos = new Menú_de_ejemplo.aeropuertos();
            this.aeropuertosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combox_localidad = new Menú_de_ejemplo.combox_localidad();
            this.comboxlocalidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lAFAST_gestor_de_reservas = new Menú_de_ejemplo.LAFAST_gestor_de_reservas();
            this.aeropuertosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aeropuertosTableAdapter = new Menú_de_ejemplo.LAFAST_gestor_de_reservasTableAdapters.aeropuertosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combox_localidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboxlocalidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAFAST_gestor_de_reservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConfirmarElimAero
            // 
            this.buttonConfirmarElimAero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConfirmarElimAero.BackgroundImage")));
            this.buttonConfirmarElimAero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirmarElimAero.Location = new System.Drawing.Point(42, 151);
            this.buttonConfirmarElimAero.Name = "buttonConfirmarElimAero";
            this.buttonConfirmarElimAero.Size = new System.Drawing.Size(334, 55);
            this.buttonConfirmarElimAero.TabIndex = 0;
            this.buttonConfirmarElimAero.UseVisualStyleBackColor = true;
            this.buttonConfirmarElimAero.Click += new System.EventHandler(this.buttonConfirmarElimAero_Click);
            // 
            // buttonCancelarElimAero
            // 
            this.buttonCancelarElimAero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancelarElimAero.BackgroundImage")));
            this.buttonCancelarElimAero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelarElimAero.Location = new System.Drawing.Point(42, 222);
            this.buttonCancelarElimAero.Name = "buttonCancelarElimAero";
            this.buttonCancelarElimAero.Size = new System.Drawing.Size(334, 55);
            this.buttonCancelarElimAero.TabIndex = 1;
            this.buttonCancelarElimAero.UseVisualStyleBackColor = true;
            this.buttonCancelarElimAero.Click += new System.EventHandler(this.buttonCancelarElimAero_Click);
            // 
            // comboBoxElimAero
            // 
            this.comboBoxElimAero.DataSource = this.aeropuertosBindingSource1;
            this.comboBoxElimAero.DisplayMember = "nombre_aeropuerto";
            this.comboBoxElimAero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxElimAero.FormattingEnabled = true;
            this.comboBoxElimAero.Location = new System.Drawing.Point(55, 89);
            this.comboBoxElimAero.Name = "comboBoxElimAero";
            this.comboBoxElimAero.Size = new System.Drawing.Size(321, 24);
            this.comboBoxElimAero.TabIndex = 2;
            this.comboBoxElimAero.ValueMember = "nombre_aeropuerto";
            // 
            // aeropuertos
            // 
            this.aeropuertos.DataSetName = "aeropuertos";
            this.aeropuertos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aeropuertosBindingSource
            // 
            this.aeropuertosBindingSource.DataSource = this.aeropuertos;
            this.aeropuertosBindingSource.Position = 0;
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
            // lAFAST_gestor_de_reservas
            // 
            this.lAFAST_gestor_de_reservas.DataSetName = "LAFAST_gestor_de_reservas";
            this.lAFAST_gestor_de_reservas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aeropuertosBindingSource1
            // 
            this.aeropuertosBindingSource1.DataMember = "aeropuertos";
            this.aeropuertosBindingSource1.DataSource = this.lAFAST_gestor_de_reservas;
            // 
            // aeropuertosTableAdapter
            // 
            this.aeropuertosTableAdapter.ClearBeforeFill = true;
            // 
            // EliminarAeropuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(428, 308);
            this.Controls.Add(this.comboBoxElimAero);
            this.Controls.Add(this.buttonCancelarElimAero);
            this.Controls.Add(this.buttonConfirmarElimAero);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EliminarAeropuerto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EliminarAeropuerto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combox_localidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboxlocalidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAFAST_gestor_de_reservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmarElimAero;
        private System.Windows.Forms.Button buttonCancelarElimAero;
        private System.Windows.Forms.ComboBox comboBoxElimAero;
        private System.Windows.Forms.BindingSource comboxlocalidadBindingSource;
        private combox_localidad combox_localidad;
        private aeropuertos aeropuertos;
        private System.Windows.Forms.BindingSource aeropuertosBindingSource;
        private LAFAST_gestor_de_reservas lAFAST_gestor_de_reservas;
        private System.Windows.Forms.BindingSource aeropuertosBindingSource1;
        private LAFAST_gestor_de_reservasTableAdapters.aeropuertosTableAdapter aeropuertosTableAdapter;
    }
}