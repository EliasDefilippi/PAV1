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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearTramo));
            this.comboBoxAeropuertoOrigen = new System.Windows.Forms.ComboBox();
            this.comboBoxAeropuertoDestino = new System.Windows.Forms.ComboBox();
            this.textBoxDuracionTramo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAsignarVuelo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxAeropuertoOrigen
            // 
            this.comboBoxAeropuertoOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAeropuertoOrigen.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAeropuertoOrigen.FormattingEnabled = true;
            this.comboBoxAeropuertoOrigen.Location = new System.Drawing.Point(53, 94);
            this.comboBoxAeropuertoOrigen.Name = "comboBoxAeropuertoOrigen";
            this.comboBoxAeropuertoOrigen.Size = new System.Drawing.Size(324, 34);
            this.comboBoxAeropuertoOrigen.TabIndex = 0;
            // 
            // comboBoxAeropuertoDestino
            // 
            this.comboBoxAeropuertoDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAeropuertoDestino.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAeropuertoDestino.FormattingEnabled = true;
            this.comboBoxAeropuertoDestino.Location = new System.Drawing.Point(53, 180);
            this.comboBoxAeropuertoDestino.Name = "comboBoxAeropuertoDestino";
            this.comboBoxAeropuertoDestino.Size = new System.Drawing.Size(324, 34);
            this.comboBoxAeropuertoDestino.TabIndex = 1;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAeropuertoOrigen;
        private System.Windows.Forms.ComboBox comboBoxAeropuertoDestino;
        private System.Windows.Forms.TextBox textBoxDuracionTramo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAsignarVuelo;
    }
}