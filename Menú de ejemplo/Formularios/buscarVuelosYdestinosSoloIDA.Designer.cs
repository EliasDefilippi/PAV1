namespace Menú_de_ejemplo.Formularios
{
    partial class buscarVuelosYdestinosSoloIDA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscarVuelosYdestinosSoloIDA));
            this.buttonBuscaTuVuelo = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.comboBoxOrigen = new System.Windows.Forms.ComboBox();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFechaIda = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCabina = new System.Windows.Forms.ComboBox();
            this.textBoxCodPromocional = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonBuscaTuVuelo
            // 
            this.buttonBuscaTuVuelo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBuscaTuVuelo.BackgroundImage")));
            this.buttonBuscaTuVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscaTuVuelo.Location = new System.Drawing.Point(371, 234);
            this.buttonBuscaTuVuelo.Name = "buttonBuscaTuVuelo";
            this.buttonBuscaTuVuelo.Size = new System.Drawing.Size(318, 52);
            this.buttonBuscaTuVuelo.TabIndex = 0;
            this.buttonBuscaTuVuelo.UseVisualStyleBackColor = true;
            this.buttonBuscaTuVuelo.Click += new System.EventHandler(this.buttonBuscaTuVuelo_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.BackgroundImage")));
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Location = new System.Drawing.Point(371, 312);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(318, 55);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // comboBoxOrigen
            // 
            this.comboBoxOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxOrigen.FormattingEnabled = true;
            this.comboBoxOrigen.Location = new System.Drawing.Point(12, 79);
            this.comboBoxOrigen.Name = "comboBoxOrigen";
            this.comboBoxOrigen.Size = new System.Drawing.Size(309, 24);
            this.comboBoxOrigen.TabIndex = 2;
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(385, 79);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(304, 24);
            this.comboBoxDestino.TabIndex = 3;
            // 
            // dateTimePickerFechaIda
            // 
            this.dateTimePickerFechaIda.Location = new System.Drawing.Point(13, 184);
            this.dateTimePickerFechaIda.Name = "dateTimePickerFechaIda";
            this.dateTimePickerFechaIda.Size = new System.Drawing.Size(308, 23);
            this.dateTimePickerFechaIda.TabIndex = 4;
            // 
            // comboBoxCabina
            // 
            this.comboBoxCabina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCabina.FormattingEnabled = true;
            this.comboBoxCabina.Location = new System.Drawing.Point(385, 184);
            this.comboBoxCabina.Name = "comboBoxCabina";
            this.comboBoxCabina.Size = new System.Drawing.Size(304, 24);
            this.comboBoxCabina.TabIndex = 5;
            // 
            // textBoxCodPromocional
            // 
            this.textBoxCodPromocional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCodPromocional.Location = new System.Drawing.Point(12, 338);
            this.textBoxCodPromocional.Name = "textBoxCodPromocional";
            this.textBoxCodPromocional.Size = new System.Drawing.Size(309, 16);
            this.textBoxCodPromocional.TabIndex = 6;
            // 
            // buscarVuelosYdestinosSoloIDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(711, 395);
            this.Controls.Add(this.textBoxCodPromocional);
            this.Controls.Add(this.comboBoxCabina);
            this.Controls.Add(this.dateTimePickerFechaIda);
            this.Controls.Add(this.comboBoxDestino);
            this.Controls.Add(this.comboBoxOrigen);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonBuscaTuVuelo);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "buscarVuelosYdestinosSoloIDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscaTuVuelo;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.ComboBox comboBoxOrigen;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaIda;
        private System.Windows.Forms.ComboBox comboBoxCabina;
        private System.Windows.Forms.TextBox textBoxCodPromocional;
    }
}