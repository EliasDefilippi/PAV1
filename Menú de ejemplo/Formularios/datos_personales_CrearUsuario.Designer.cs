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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNumeroTelefono = new System.Windows.Forms.TextBox();
            this.textBoxCodigoPais = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxPaisEmisionDocu = new System.Windows.Forms.ComboBox();
            this.paisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localidades = new Menú_de_ejemplo.localidades();
            this.comboBoxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.tipodocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxNumeroDocumento = new System.Windows.Forms.TextBox();
            this.checkBoxTerminosYcondiciones = new System.Windows.Forms.CheckBox();
            this.buttonCrearCuenta = new System.Windows.Forms.Button();
            this.textBoxAñoNac = new System.Windows.Forms.TextBox();
            this.comboBoxMesFechaNac = new System.Windows.Forms.ComboBox();
            this.paisesTableAdapter = new Menú_de_ejemplo.localidadesTableAdapters.paisesTableAdapter();
            this.tipo_documentoTableAdapter = new Menú_de_ejemplo.localidadesTableAdapters.tipo_documentoTableAdapter();
            this.comBoxDiaNac = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(55, 95);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(326, 26);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxApellido.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellido.Location = new System.Drawing.Point(55, 184);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(326, 26);
            this.textBoxApellido.TabIndex = 2;
            // 
            // textBoxNumeroTelefono
            // 
            this.textBoxNumeroTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumeroTelefono.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroTelefono.Location = new System.Drawing.Point(130, 407);
            this.textBoxNumeroTelefono.Name = "textBoxNumeroTelefono";
            this.textBoxNumeroTelefono.Size = new System.Drawing.Size(251, 26);
            this.textBoxNumeroTelefono.TabIndex = 7;
            this.textBoxNumeroTelefono.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxCodigoPais
            // 
            this.textBoxCodigoPais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCodigoPais.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigoPais.Location = new System.Drawing.Point(55, 407);
            this.textBoxCodigoPais.Name = "textBoxCodigoPais";
            this.textBoxCodigoPais.Size = new System.Drawing.Size(56, 26);
            this.textBoxCodigoPais.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(47, 588);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(260, 26);
            this.textBox6.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.comboBoxPaisEmisionDocu.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.comboBoxTipoDocumento.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // textBoxNumeroDocumento
            // 
            this.textBoxNumeroDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumeroDocumento.Location = new System.Drawing.Point(501, 270);
            this.textBoxNumeroDocumento.Name = "textBoxNumeroDocumento";
            this.textBoxNumeroDocumento.Size = new System.Drawing.Size(324, 26);
            this.textBoxNumeroDocumento.TabIndex = 10;
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
            // textBoxAñoNac
            // 
            this.textBoxAñoNac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAñoNac.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAñoNac.Location = new System.Drawing.Point(281, 270);
            this.textBoxAñoNac.Name = "textBoxAñoNac";
            this.textBoxAñoNac.Size = new System.Drawing.Size(100, 20);
            this.textBoxAñoNac.TabIndex = 5;
            // 
            // comboBoxMesFechaNac
            // 
            this.comboBoxMesFechaNac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMesFechaNac.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.comBoxDiaNac.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // datos_personales_CrearUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(918, 541);
            this.Controls.Add(this.comBoxDiaNac);
            this.Controls.Add(this.comboBoxMesFechaNac);
            this.Controls.Add(this.buttonCrearCuenta);
            this.Controls.Add(this.checkBoxTerminosYcondiciones);
            this.Controls.Add(this.textBoxNumeroDocumento);
            this.Controls.Add(this.comboBoxTipoDocumento);
            this.Controls.Add(this.comboBoxPaisEmisionDocu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBoxCodigoPais);
            this.Controls.Add(this.textBoxAñoNac);
            this.Controls.Add(this.textBoxNumeroTelefono);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "datos_personales_CrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "z";
            this.Load += new System.EventHandler(this.datos_personales_CrearUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNumeroTelefono;
        private System.Windows.Forms.TextBox textBoxCodigoPais;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxPaisEmisionDocu;
        private System.Windows.Forms.ComboBox comboBoxTipoDocumento;
        private System.Windows.Forms.TextBox textBoxNumeroDocumento;
        private System.Windows.Forms.CheckBox checkBoxTerminosYcondiciones;
        private System.Windows.Forms.Button buttonCrearCuenta;
        private System.Windows.Forms.TextBox textBoxAñoNac;
        private System.Windows.Forms.ComboBox comboBoxMesFechaNac;
        private localidades localidades;
        private System.Windows.Forms.BindingSource paisesBindingSource;
        private localidadesTableAdapters.paisesTableAdapter paisesTableAdapter;
        private System.Windows.Forms.BindingSource tipodocumentoBindingSource;
        private localidadesTableAdapters.tipo_documentoTableAdapter tipo_documentoTableAdapter;
        private System.Windows.Forms.ComboBox comBoxDiaNac;
    }
}