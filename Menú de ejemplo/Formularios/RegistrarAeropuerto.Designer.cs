namespace Menú_de_ejemplo.Formularios
{
    partial class RegistrarAeropuerto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarAeropuerto));
            this.buttonConfirmarRegistroAeropuerto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelRegistrarLocalidad = new System.Windows.Forms.LinkLabel();
            this.textBoxNombreAeropuerto = new System.Windows.Forms.TextBox();
            this.comboBoxLocalidad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonConfirmarRegistroAeropuerto
            // 
            this.buttonConfirmarRegistroAeropuerto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConfirmarRegistroAeropuerto.BackgroundImage")));
            this.buttonConfirmarRegistroAeropuerto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirmarRegistroAeropuerto.Location = new System.Drawing.Point(43, 271);
            this.buttonConfirmarRegistroAeropuerto.Name = "buttonConfirmarRegistroAeropuerto";
            this.buttonConfirmarRegistroAeropuerto.Size = new System.Drawing.Size(334, 55);
            this.buttonConfirmarRegistroAeropuerto.TabIndex = 0;
            this.buttonConfirmarRegistroAeropuerto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "¿La localidad que busca no se encuentra disponible?";
            // 
            // linkLabelRegistrarLocalidad
            // 
            this.linkLabelRegistrarLocalidad.AutoSize = true;
            this.linkLabelRegistrarLocalidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelRegistrarLocalidad.DisabledLinkColor = System.Drawing.Color.White;
            this.linkLabelRegistrarLocalidad.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRegistrarLocalidad.Location = new System.Drawing.Point(142, 243);
            this.linkLabelRegistrarLocalidad.Name = "linkLabelRegistrarLocalidad";
            this.linkLabelRegistrarLocalidad.Size = new System.Drawing.Size(132, 16);
            this.linkLabelRegistrarLocalidad.TabIndex = 2;
            this.linkLabelRegistrarLocalidad.TabStop = true;
            this.linkLabelRegistrarLocalidad.Text = "Registrar Localidad";
            this.linkLabelRegistrarLocalidad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegistrarLocalidad_LinkClicked);
            // 
            // textBoxNombreAeropuerto
            // 
            this.textBoxNombreAeropuerto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombreAeropuerto.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreAeropuerto.Location = new System.Drawing.Point(52, 101);
            this.textBoxNombreAeropuerto.Name = "textBoxNombreAeropuerto";
            this.textBoxNombreAeropuerto.Size = new System.Drawing.Size(325, 19);
            this.textBoxNombreAeropuerto.TabIndex = 3;
            // 
            // comboBoxLocalidad
            // 
            this.comboBoxLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLocalidad.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLocalidad.FormattingEnabled = true;
            this.comboBoxLocalidad.Location = new System.Drawing.Point(52, 186);
            this.comboBoxLocalidad.Name = "comboBoxLocalidad";
            this.comboBoxLocalidad.Size = new System.Drawing.Size(325, 24);
            this.comboBoxLocalidad.TabIndex = 4;
            // 
            // RegistrarAeropuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(428, 338);
            this.Controls.Add(this.comboBoxLocalidad);
            this.Controls.Add(this.textBoxNombreAeropuerto);
            this.Controls.Add(this.linkLabelRegistrarLocalidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConfirmarRegistroAeropuerto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarAeropuerto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarAeropuerto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmarRegistroAeropuerto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelRegistrarLocalidad;
        private System.Windows.Forms.TextBox textBoxNombreAeropuerto;
        private System.Windows.Forms.ComboBox comboBoxLocalidad;
    }
}