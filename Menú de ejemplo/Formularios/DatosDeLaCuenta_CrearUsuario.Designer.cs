namespace Menú_de_ejemplo.Formularios.Crear_Usuario
{
    partial class DatosDeLaCuenta_CrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosDeLaCuenta_CrearUsuario));
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxCorreoElectronico = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.textBoxConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(65, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCorreoElectronico
            // 
            this.textBoxCorreoElectronico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCorreoElectronico.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreoElectronico.Location = new System.Drawing.Point(65, 121);
            this.textBoxCorreoElectronico.Name = "textBoxCorreoElectronico";
            this.textBoxCorreoElectronico.Size = new System.Drawing.Size(320, 24);
            this.textBoxCorreoElectronico.TabIndex = 1;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseña.Location = new System.Drawing.Point(65, 240);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(320, 22);
            this.textBoxContraseña.TabIndex = 2;
            this.textBoxContraseña.UseSystemPasswordChar = true;
            // 
            // textBoxConfirmarContraseña
            // 
            this.textBoxConfirmarContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConfirmarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmarContraseña.Location = new System.Drawing.Point(65, 331);
            this.textBoxConfirmarContraseña.Name = "textBoxConfirmarContraseña";
            this.textBoxConfirmarContraseña.Size = new System.Drawing.Size(320, 22);
            this.textBoxConfirmarContraseña.TabIndex = 3;
            this.textBoxConfirmarContraseña.UseSystemPasswordChar = true;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCerrar.BackgroundImage")));
            this.buttonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.Location = new System.Drawing.Point(381, 2);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(50, 35);
            this.buttonCerrar.TabIndex = 4;
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // DatosDeLaCuenta_CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(433, 466);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.textBoxConfirmarContraseña);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxCorreoElectronico);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatosDeLaCuenta_CrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatosDeLaCuenta_CrearUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxCorreoElectronico;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.TextBox textBoxConfirmarContraseña;
        private System.Windows.Forms.Button buttonCerrar;
    }
}