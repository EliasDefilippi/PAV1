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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarLocalidad));
            this.buttonConfirmarLocalidad = new System.Windows.Forms.Button();
            this.textBoxNombreLocalidad = new System.Windows.Forms.TextBox();
            this.comboBoxPaises = new System.Windows.Forms.ComboBox();
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
            this.comboBoxPaises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPaises.FormattingEnabled = true;
            this.comboBoxPaises.Location = new System.Drawing.Point(56, 186);
            this.comboBoxPaises.Name = "comboBoxPaises";
            this.comboBoxPaises.Size = new System.Drawing.Size(321, 21);
            this.comboBoxPaises.TabIndex = 2;
            this.comboBoxPaises.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaises_SelectedIndexChanged);
            // 
            // RegistrarLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(428, 338);
            this.Controls.Add(this.comboBoxPaises);
            this.Controls.Add(this.textBoxNombreLocalidad);
            this.Controls.Add(this.buttonConfirmarLocalidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarLocalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarLocalidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmarLocalidad;
        private System.Windows.Forms.TextBox textBoxNombreLocalidad;
        private System.Windows.Forms.ComboBox comboBoxPaises;
    }
}