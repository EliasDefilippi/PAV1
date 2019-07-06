namespace Menú_de_ejemplo.Formularios
{
    partial class seleccionTipoVuelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seleccionTipoVuelo));
            this.btonVueloIda = new System.Windows.Forms.Button();
            this.btonIda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelarTarifa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btonVueloIda
            // 
            this.btonVueloIda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btonVueloIda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btonVueloIda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonVueloIda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btonVueloIda.Location = new System.Drawing.Point(25, 135);
            this.btonVueloIda.Name = "btonVueloIda";
            this.btonVueloIda.Size = new System.Drawing.Size(264, 55);
            this.btonVueloIda.TabIndex = 1;
            this.btonVueloIda.Text = "Ida y Vuelta";
            this.btonVueloIda.UseVisualStyleBackColor = false;
            this.btonVueloIda.Click += new System.EventHandler(this.btonVueloIda_Click);
            // 
            // btonIda
            // 
            this.btonIda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btonIda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btonIda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonIda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btonIda.Location = new System.Drawing.Point(25, 74);
            this.btonIda.Name = "btonIda";
            this.btonIda.Size = new System.Drawing.Size(264, 55);
            this.btonIda.TabIndex = 2;
            this.btonIda.Text = "Ida";
            this.btonIda.UseVisualStyleBackColor = false;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione Tipo de Vuelo";
            // 
            // buttonCancelarTarifa
            // 
            this.buttonCancelarTarifa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancelarTarifa.BackgroundImage")));
            this.buttonCancelarTarifa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCancelarTarifa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelarTarifa.Location = new System.Drawing.Point(25, 308);
            this.buttonCancelarTarifa.Name = "buttonCancelarTarifa";
            this.buttonCancelarTarifa.Size = new System.Drawing.Size(272, 55);
            this.buttonCancelarTarifa.TabIndex = 5;
            this.buttonCancelarTarifa.UseVisualStyleBackColor = true;
            this.buttonCancelarTarifa.Click += new System.EventHandler(this.buttonCancelarTarifa_Click);
            // 
            // seleccionTipoVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(322, 365);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancelarTarifa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btonIda);
            this.Controls.Add(this.btonVueloIda);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "seleccionTipoVuelo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.seleccionTipoVuelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btonVueloIda;
        private System.Windows.Forms.Button btonIda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelarTarifa;
    }
}