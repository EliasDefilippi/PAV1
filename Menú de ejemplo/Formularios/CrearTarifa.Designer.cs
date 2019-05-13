namespace Menú_de_ejemplo.Formularios
{
    partial class CrearTarifa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearTarifa));
            this.comboBoxClaseTarifa = new System.Windows.Forms.ComboBox();
            this.textBoxPrecioTarifa = new System.Windows.Forms.TextBox();
            this.textBoxImpuestoTarifa = new System.Windows.Forms.TextBox();
            this.buttonConfirmarTarifa = new System.Windows.Forms.Button();
            this.buttonCancelarTarifa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxClaseTarifa
            // 
            this.comboBoxClaseTarifa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClaseTarifa.FormattingEnabled = true;
            this.comboBoxClaseTarifa.Items.AddRange(new object[] {
            "T",
            "E",
            "F"});
            this.comboBoxClaseTarifa.Location = new System.Drawing.Point(51, 98);
            this.comboBoxClaseTarifa.Name = "comboBoxClaseTarifa";
            this.comboBoxClaseTarifa.Size = new System.Drawing.Size(325, 24);
            this.comboBoxClaseTarifa.TabIndex = 0;
            // 
            // textBoxPrecioTarifa
            // 
            this.textBoxPrecioTarifa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrecioTarifa.Location = new System.Drawing.Point(51, 189);
            this.textBoxPrecioTarifa.Name = "textBoxPrecioTarifa";
            this.textBoxPrecioTarifa.Size = new System.Drawing.Size(325, 16);
            this.textBoxPrecioTarifa.TabIndex = 1;
            // 
            // textBoxImpuestoTarifa
            // 
            this.textBoxImpuestoTarifa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxImpuestoTarifa.Location = new System.Drawing.Point(51, 276);
            this.textBoxImpuestoTarifa.Name = "textBoxImpuestoTarifa";
            this.textBoxImpuestoTarifa.Size = new System.Drawing.Size(325, 16);
            this.textBoxImpuestoTarifa.TabIndex = 2;
            // 
            // buttonConfirmarTarifa
            // 
            this.buttonConfirmarTarifa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConfirmarTarifa.BackgroundImage")));
            this.buttonConfirmarTarifa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirmarTarifa.Location = new System.Drawing.Point(51, 332);
            this.buttonConfirmarTarifa.Name = "buttonConfirmarTarifa";
            this.buttonConfirmarTarifa.Size = new System.Drawing.Size(334, 55);
            this.buttonConfirmarTarifa.TabIndex = 3;
            this.buttonConfirmarTarifa.UseVisualStyleBackColor = true;
            // 
            // buttonCancelarTarifa
            // 
            this.buttonCancelarTarifa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancelarTarifa.BackgroundImage")));
            this.buttonCancelarTarifa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelarTarifa.Location = new System.Drawing.Point(51, 407);
            this.buttonCancelarTarifa.Name = "buttonCancelarTarifa";
            this.buttonCancelarTarifa.Size = new System.Drawing.Size(334, 55);
            this.buttonCancelarTarifa.TabIndex = 4;
            this.buttonCancelarTarifa.UseVisualStyleBackColor = true;
            this.buttonCancelarTarifa.Click += new System.EventHandler(this.buttonCancelarTarifa_Click);
            // 
            // CrearTarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(412, 474);
            this.Controls.Add(this.buttonCancelarTarifa);
            this.Controls.Add(this.buttonConfirmarTarifa);
            this.Controls.Add(this.textBoxImpuestoTarifa);
            this.Controls.Add(this.textBoxPrecioTarifa);
            this.Controls.Add(this.comboBoxClaseTarifa);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CrearTarifa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearTarifa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClaseTarifa;
        private System.Windows.Forms.TextBox textBoxPrecioTarifa;
        private System.Windows.Forms.TextBox textBoxImpuestoTarifa;
        private System.Windows.Forms.Button buttonConfirmarTarifa;
        private System.Windows.Forms.Button buttonCancelarTarifa;
    }
}