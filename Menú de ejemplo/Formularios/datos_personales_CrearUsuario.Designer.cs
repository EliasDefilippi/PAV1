namespace Menú_de_ejemplo.Formularios
{
    partial class datos_personales_CrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(datos_personales_CrearUsuario));
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxPaisEmisionDocu = new System.Windows.Forms.ComboBox();
            this.paisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localidades = new Menú_de_ejemplo.localidades();
            this.comboBoxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.tipodocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxTerminosYcondiciones = new System.Windows.Forms.CheckBox();
            this.buttonCrearCuenta = new System.Windows.Forms.Button();
            this.comboBoxMesFechaNac = new System.Windows.Forms.ComboBox();
            this.paisesTableAdapter = new Menú_de_ejemplo.localidadesTableAdapters.paisesTableAdapter();
            this.tipo_documentoTableAdapter = new Menú_de_ejemplo.localidadesTableAdapters.tipo_documentoTableAdapter();
            this.comBoxDiaNac = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxNombre = new Mi_Liberia_LF.Error_txtBox();
            this.textBoxApellido = new Mi_Liberia_LF.Error_txtBox();
            this.textBoxAñoNac = new Mi_Liberia_LF.Error_txtBox();
            this.textBoxNumeroTelefono = new Mi_Liberia_LF.Error_txtBox();
            this.textBoxCodigoPais = new Mi_Liberia_LF.Error_txtBox();
            this.textBoxNumeroDocumento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(47, 588);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(260, 24);
            this.textBox6.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(47, 618);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Crear cuenta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxPaisEmisionDocu
            // 
            this.comboBoxPaisEmisionDocu.DataSource = this.paisesBindingSource;
            this.comboBoxPaisEmisionDocu.DisplayMember = "nombre_pais";
            this.comboBoxPaisEmisionDocu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPaisEmisionDocu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPaisEmisionDocu.FormattingEnabled = true;
            this.comboBoxPaisEmisionDocu.Location = new System.Drawing.Point(501, 92);
            this.comboBoxPaisEmisionDocu.Name = "comboBoxPaisEmisionDocu";
            this.comboBoxPaisEmisionDocu.Size = new System.Drawing.Size(324, 28);
            this.comboBoxPaisEmisionDocu.TabIndex = 8;
            this.comboBoxPaisEmisionDocu.ValueMember = "id_pais";
            // 
            // paisesBindingSource
            // 
            this.paisesBindingSource.DataMember = "paises";
            this.paisesBindingSource.DataSource = this.localidades;
            // 
            // localidades
            // 
            this.localidades.DataSetName = "localidades";
            this.localidades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxTipoDocumento
            // 
            this.comboBoxTipoDocumento.DataSource = this.tipodocumentoBindingSource;
            this.comboBoxTipoDocumento.DisplayMember = "desc_tipo_doc";
            this.comboBoxTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoDocumento.FormattingEnabled = true;
            this.comboBoxTipoDocumento.Location = new System.Drawing.Point(501, 181);
            this.comboBoxTipoDocumento.Name = "comboBoxTipoDocumento";
            this.comboBoxTipoDocumento.Size = new System.Drawing.Size(324, 28);
            this.comboBoxTipoDocumento.TabIndex = 9;
            this.comboBoxTipoDocumento.ValueMember = "id_tipo_documento";
            // 
            // tipodocumentoBindingSource
            // 
            this.tipodocumentoBindingSource.DataMember = "tipo_documento";
            this.tipodocumentoBindingSource.DataSource = this.localidades;
            // 
            // checkBoxTerminosYcondiciones
            // 
            this.checkBoxTerminosYcondiciones.AutoSize = true;
            this.checkBoxTerminosYcondiciones.BackColor = System.Drawing.Color.LightGray;
            this.checkBoxTerminosYcondiciones.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTerminosYcondiciones.Location = new System.Drawing.Point(501, 357);
            this.checkBoxTerminosYcondiciones.Name = "checkBoxTerminosYcondiciones";
            this.checkBoxTerminosYcondiciones.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTerminosYcondiciones.TabIndex = 11;
            this.checkBoxTerminosYcondiciones.UseVisualStyleBackColor = false;
            // 
            // buttonCrearCuenta
            // 
            this.buttonCrearCuenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCrearCuenta.BackgroundImage")));
            this.buttonCrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCrearCuenta.Location = new System.Drawing.Point(501, 449);
            this.buttonCrearCuenta.Name = "buttonCrearCuenta";
            this.buttonCrearCuenta.Size = new System.Drawing.Size(333, 53);
            this.buttonCrearCuenta.TabIndex = 12;
            this.buttonCrearCuenta.UseVisualStyleBackColor = true;
            this.buttonCrearCuenta.Click += new System.EventHandler(this.buttonCrearCuenta_Click);
            // 
            // comboBoxMesFechaNac
            // 
            this.comboBoxMesFechaNac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMesFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMesFechaNac.FormattingEnabled = true;
            this.comboBoxMesFechaNac.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.comboBoxMesFechaNac.Location = new System.Drawing.Point(130, 267);
            this.comboBoxMesFechaNac.Name = "comboBoxMesFechaNac";
            this.comboBoxMesFechaNac.Size = new System.Drawing.Size(131, 28);
            this.comboBoxMesFechaNac.TabIndex = 4;
            // 
            // paisesTableAdapter
            // 
            this.paisesTableAdapter.ClearBeforeFill = true;
            // 
            // tipo_documentoTableAdapter
            // 
            this.tipo_documentoTableAdapter.ClearBeforeFill = true;
            // 
            // comBoxDiaNac
            // 
            this.comBoxDiaNac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comBoxDiaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxDiaNac.FormattingEnabled = true;
            this.comBoxDiaNac.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comBoxDiaNac.Location = new System.Drawing.Point(55, 267);
            this.comBoxDiaNac.Name = "comBoxDiaNac";
            this.comBoxDiaNac.Size = new System.Drawing.Size(56, 28);
            this.comBoxDiaNac.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(55, 92);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(326, 31);
            this.textBoxNombre.SoloCaracteres = true;
            this.textBoxNombre.SoloNumeros = false;
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.Validar = true;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(55, 181);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(326, 31);
            this.textBoxApellido.SoloCaracteres = true;
            this.textBoxApellido.SoloNumeros = false;
            this.textBoxApellido.TabIndex = 2;
            this.textBoxApellido.Validar = true;
            // 
            // textBoxAñoNac
            // 
            this.textBoxAñoNac.Location = new System.Drawing.Point(278, 267);
            this.textBoxAñoNac.Name = "textBoxAñoNac";
            this.textBoxAñoNac.Size = new System.Drawing.Size(103, 31);
            this.textBoxAñoNac.SoloCaracteres = false;
            this.textBoxAñoNac.SoloNumeros = true;
            this.textBoxAñoNac.TabIndex = 5;
            this.textBoxAñoNac.Validar = true;
            // 
            // textBoxNumeroTelefono
            // 
            this.textBoxNumeroTelefono.Location = new System.Drawing.Point(130, 404);
            this.textBoxNumeroTelefono.Name = "textBoxNumeroTelefono";
            this.textBoxNumeroTelefono.Size = new System.Drawing.Size(251, 31);
            this.textBoxNumeroTelefono.SoloCaracteres = false;
            this.textBoxNumeroTelefono.SoloNumeros = true;
            this.textBoxNumeroTelefono.TabIndex = 7;
            this.textBoxNumeroTelefono.Validar = true;
            // 
            // textBoxCodigoPais
            // 
            this.textBoxCodigoPais.Location = new System.Drawing.Point(55, 404);
            this.textBoxCodigoPais.Name = "textBoxCodigoPais";
            this.textBoxCodigoPais.Size = new System.Drawing.Size(56, 31);
            this.textBoxCodigoPais.SoloCaracteres = false;
            this.textBoxCodigoPais.SoloNumeros = true;
            this.textBoxCodigoPais.TabIndex = 6;
            this.textBoxCodigoPais.Validar = true;
            // 
            // textBoxNumeroDocumento
            // 
            this.textBoxNumeroDocumento.Location = new System.Drawing.Point(501, 267);
            this.textBoxNumeroDocumento.Name = "textBoxNumeroDocumento";
            this.textBoxNumeroDocumento.Size = new System.Drawing.Size(324, 31);
            this.textBoxNumeroDocumento.TabIndex = 10;
            // 
            // datos_personales_CrearUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(918, 541);
            this.Controls.Add(this.textBoxNumeroDocumento);
            this.Controls.Add(this.textBoxCodigoPais);
            this.Controls.Add(this.textBoxNumeroTelefono);
            this.Controls.Add(this.textBoxAñoNac);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.comBoxDiaNac);
            this.Controls.Add(this.comboBoxMesFechaNac);
            this.Controls.Add(this.buttonCrearCuenta);
            this.Controls.Add(this.checkBoxTerminosYcondiciones);
            this.Controls.Add(this.comboBoxTipoDocumento);
            this.Controls.Add(this.comboBoxPaisEmisionDocu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "datos_personales_CrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "z";
            this.Load += new System.EventHandler(this.datos_personales_CrearUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxPaisEmisionDocu;
        private System.Windows.Forms.ComboBox comboBoxTipoDocumento;
        private System.Windows.Forms.CheckBox checkBoxTerminosYcondiciones;
        private System.Windows.Forms.Button buttonCrearCuenta;
        private System.Windows.Forms.ComboBox comboBoxMesFechaNac;
        private localidades localidades;
        private System.Windows.Forms.BindingSource paisesBindingSource;
        private localidadesTableAdapters.paisesTableAdapter paisesTableAdapter;
        private System.Windows.Forms.BindingSource tipodocumentoBindingSource;
        private localidadesTableAdapters.tipo_documentoTableAdapter tipo_documentoTableAdapter;
        private System.Windows.Forms.ComboBox comBoxDiaNac;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Mi_Liberia_LF.Error_txtBox textBoxCodigoPais;
        private Mi_Liberia_LF.Error_txtBox textBoxNumeroTelefono;
        private Mi_Liberia_LF.Error_txtBox textBoxAñoNac;
        private Mi_Liberia_LF.Error_txtBox textBoxApellido;
        private Mi_Liberia_LF.Error_txtBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxNumeroDocumento;
    }
}