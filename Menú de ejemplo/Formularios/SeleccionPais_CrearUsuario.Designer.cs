namespace Menú_de_ejemplo.Formularios
{
    partial class SeleccionPais_CrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionPais_CrearUsuario));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxNacionalidad = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(80, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxNacionalidad
            // 
            this.comboBoxNacionalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNacionalidad.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNacionalidad.FormattingEnabled = true;
            this.comboBoxNacionalidad.Items.AddRange(new object[] {
            "Argentina",
            "Bolivia",
            "Brasil",
            "Chile",
            ""});
            this.comboBoxNacionalidad.Location = new System.Drawing.Point(62, 69);
            this.comboBoxNacionalidad.Name = "comboBoxNacionalidad";
            this.comboBoxNacionalidad.Size = new System.Drawing.Size(326, 24);
            this.comboBoxNacionalidad.TabIndex = 1;
            this.comboBoxNacionalidad.Text = "Argentina";
            this.comboBoxNacionalidad.SelectedIndexChanged += new System.EventHandler(this.comboBoxNacionalidad_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(397, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 37);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SeleccionPais_CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(450, 212);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxNacionalidad);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeleccionPais_CrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionPais_CrearUsuario";
            this.Load += new System.EventHandler(this.SeleccionPais_CrearUsuario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxNacionalidad;
        private System.Windows.Forms.Button button2;
    }
}