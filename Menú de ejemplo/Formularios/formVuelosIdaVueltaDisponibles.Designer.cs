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
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonVuelta = new System.Windows.Forms.Button();
            this.vuelosIda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vuelosIda)).BeginInit();
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
            // buttonVuelta
            // 
            this.buttonVuelta.BackColor = System.Drawing.Color.Firebrick;
            this.buttonVuelta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonVuelta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVuelta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVuelta.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonVuelta.Location = new System.Drawing.Point(441, 469);
            this.buttonVuelta.Name = "buttonVuelta";
            this.buttonVuelta.Size = new System.Drawing.Size(334, 55);
            this.buttonVuelta.TabIndex = 3;
            this.buttonVuelta.Text = "Selecionar Vuelo de Vuelta";
            this.buttonVuelta.UseVisualStyleBackColor = false;
            this.buttonVuelta.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // vuelosIda
            // 
            this.vuelosIda.AllowUserToAddRows = false;
            this.vuelosIda.AllowUserToDeleteRows = false;
            this.vuelosIda.AllowUserToResizeColumns = false;
            this.vuelosIda.AllowUserToResizeRows = false;
            this.vuelosIda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vuelosIda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.vuelosIda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vuelosIda.Location = new System.Drawing.Point(12, 46);
            this.vuelosIda.MultiSelect = false;
            this.vuelosIda.Name = "vuelosIda";
            this.vuelosIda.ReadOnly = true;
            this.vuelosIda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vuelosIda.Size = new System.Drawing.Size(896, 337);
            this.vuelosIda.TabIndex = 4;
            this.vuelosIda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vuelosIda_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vuelos de ida";
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
            // formVuelosIdaVueltaDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(920, 550);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vuelosIda);
            this.Controls.Add(this.buttonVuelta);
            this.Controls.Add(this.buttonConfirmar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formVuelosIdaVueltaDisponibles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formVuelosIdaVueltaDisponibles";
            ((System.ComponentModel.ISupportInitialize)(this.vuelosIda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonVuelta;
        private System.Windows.Forms.DataGridView vuelosIda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}