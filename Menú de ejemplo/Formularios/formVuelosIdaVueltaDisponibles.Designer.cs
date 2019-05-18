namespace Menú_de_ejemplo.Formularios
{
    partial class formVuelosIdaVueltaDisponibles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVuelosIdaVueltaDisponibles));
            this.panelVuelosDisponiblesIda = new System.Windows.Forms.Panel();
            this.panelVuelosDisponiblesVuelta = new System.Windows.Forms.Panel();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelVuelosDisponiblesIda
            // 
            this.panelVuelosDisponiblesIda.Location = new System.Drawing.Point(12, 41);
            this.panelVuelosDisponiblesIda.Name = "panelVuelosDisponiblesIda";
            this.panelVuelosDisponiblesIda.Size = new System.Drawing.Size(445, 126);
            this.panelVuelosDisponiblesIda.TabIndex = 0;
            // 
            // panelVuelosDisponiblesVuelta
            // 
            this.panelVuelosDisponiblesVuelta.Location = new System.Drawing.Point(12, 224);
            this.panelVuelosDisponiblesVuelta.Name = "panelVuelosDisponiblesVuelta";
            this.panelVuelosDisponiblesVuelta.Size = new System.Drawing.Size(445, 126);
            this.panelVuelosDisponiblesVuelta.TabIndex = 1;
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConfirmar.BackgroundImage")));
            this.buttonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirmar.Location = new System.Drawing.Point(71, 368);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(334, 55);
            this.buttonConfirmar.TabIndex = 2;
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.BackgroundImage")));
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelar.Location = new System.Drawing.Point(71, 445);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(334, 55);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // formVuelosIdaVueltaDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(469, 512);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.panelVuelosDisponiblesVuelta);
            this.Controls.Add(this.panelVuelosDisponiblesIda);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formVuelosIdaVueltaDisponibles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formVuelosIdaVueltaDisponibles";
            this.Load += new System.EventHandler(this.formVuelosIdaVueltaDisponibles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVuelosDisponiblesIda;
        private System.Windows.Forms.Panel panelVuelosDisponiblesVuelta;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}