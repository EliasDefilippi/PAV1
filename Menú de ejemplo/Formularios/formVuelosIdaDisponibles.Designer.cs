namespace Menú_de_ejemplo.Formularios
{
    partial class formVuelosIdaDisponibles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVuelosIdaDisponibles));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonConfirmarVueloIda = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 134);
            this.panel1.TabIndex = 0;
            // 
            // buttonConfirmarVueloIda
            // 
            this.buttonConfirmarVueloIda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConfirmarVueloIda.BackgroundImage")));
            this.buttonConfirmarVueloIda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirmarVueloIda.Location = new System.Drawing.Point(40, 207);
            this.buttonConfirmarVueloIda.Name = "buttonConfirmarVueloIda";
            this.buttonConfirmarVueloIda.Size = new System.Drawing.Size(334, 55);
            this.buttonConfirmarVueloIda.TabIndex = 1;
            this.buttonConfirmarVueloIda.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.BackgroundImage")));
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelar.Location = new System.Drawing.Point(40, 282);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(334, 55);
            this.buttonCancelar.TabIndex = 2;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // formVuelosIdaDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(407, 361);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConfirmarVueloIda);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formVuelosIdaDisponibles";
            this.Text = "formVuelosIdaDisponibles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonConfirmarVueloIda;
        private System.Windows.Forms.Button buttonCancelar;
    }
}