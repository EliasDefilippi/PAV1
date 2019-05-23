namespace Menú_de_ejemplo.Formularios
{
    partial class formSeleccionAsientos
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
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.asientosIda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.asientosVueta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.asientosIda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asientosVueta)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.BackColor = System.Drawing.Color.Firebrick;
            this.buttonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirmar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonConfirmar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonConfirmar.Location = new System.Drawing.Point(69, 469);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(334, 55);
            this.buttonConfirmar.TabIndex = 2;
            this.buttonConfirmar.Text = "Cancelar";
            this.buttonConfirmar.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.buttonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancelar.Location = new System.Drawing.Point(441, 469);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(334, 55);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Continuar con la Reserva";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // asientosIda
            // 
            this.asientosIda.AllowUserToAddRows = false;
            this.asientosIda.AllowUserToDeleteRows = false;
            this.asientosIda.AllowUserToResizeColumns = false;
            this.asientosIda.AllowUserToResizeRows = false;
            this.asientosIda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.asientosIda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asientosIda.Location = new System.Drawing.Point(65, 45);
            this.asientosIda.MultiSelect = false;
            this.asientosIda.Name = "asientosIda";
            this.asientosIda.ReadOnly = true;
            this.asientosIda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.asientosIda.Size = new System.Drawing.Size(339, 337);
            this.asientosIda.TabIndex = 4;
            this.asientosIda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.asientosIda_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(81, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccion Asientos Vuelo de Ida";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(446, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seleccion Asientos Vuelo de Vuelta";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // asientosVueta
            // 
            this.asientosVueta.AllowUserToAddRows = false;
            this.asientosVueta.AllowUserToDeleteRows = false;
            this.asientosVueta.AllowUserToResizeColumns = false;
            this.asientosVueta.AllowUserToResizeRows = false;
            this.asientosVueta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.asientosVueta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asientosVueta.Location = new System.Drawing.Point(441, 45);
            this.asientosVueta.MultiSelect = false;
            this.asientosVueta.Name = "asientosVueta";
            this.asientosVueta.ReadOnly = true;
            this.asientosVueta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.asientosVueta.Size = new System.Drawing.Size(350, 337);
            this.asientosVueta.TabIndex = 8;
            this.asientosVueta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.asientosVueta_CellContentClick);
            // 
            // formSeleccionAsientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(920, 550);
            this.Controls.Add(this.asientosVueta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.asientosIda);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConfirmar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formSeleccionAsientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formVuelosIdaVueltaDisponibles";
            ((System.ComponentModel.ISupportInitialize)(this.asientosIda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asientosVueta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.DataGridView asientosIda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView asientosVueta;
    }
}