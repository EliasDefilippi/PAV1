namespace Menú_de_ejemplo.Formularios
{
    partial class Frm_reportes
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource12 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.aeropuertos = new Menú_de_ejemplo.aeropuertos();
            this.aeropuertosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeropuertosTableAdapter = new Menú_de_ejemplo.aeropuertosTableAdapters.aeropuertosTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.codigoRecervaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSNuevo = new Menú_de_ejemplo.DSNuevo();
            this.pasajerosConMenorCantidadDeMillasQueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gananciaGanadaPorReservaDuranteElAñoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costoTotalPromedioDeReservasDuranteElAñoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listadoDeAeropuertosYlocalidadDestinoPorPaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservasPorMesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoRecervaTableAdapter = new Menú_de_ejemplo.DSNuevoTableAdapters.CodigoRecervaTableAdapter();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.reportViewer6 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertosBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoRecervaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajerosConMenorCantidadDeMillasQueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gananciaGanadaPorReservaDuranteElAñoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costoTotalPromedioDeReservasDuranteElAñoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDeAeropuertosYlocalidadDestinoPorPaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasPorMesBindingSource)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // aeropuertos
            // 
            this.aeropuertos.DataSetName = "aeropuertos";
            this.aeropuertos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aeropuertosBindingSource
            // 
            this.aeropuertosBindingSource.DataMember = "aeropuertos";
            this.aeropuertosBindingSource.DataSource = this.aeropuertos;
            // 
            // aeropuertosTableAdapter
            // 
            this.aeropuertosTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(727, 476);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.reportViewer2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.btn_filtrar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(719, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos de recerva";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(719, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pasajero con menor cantidad de millas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            reportDataSource8.Name = "DataSet1";
            reportDataSource8.Value = this.codigoRecervaBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Menú_de_ejemplo.Report1_cod_res.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 46);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(719, 404);
            this.reportViewer2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(271, 18);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(75, 23);
            this.btn_filtrar.TabIndex = 5;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingrese su codigo de recerva:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ingrese cantidad de millas:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(174, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // reportViewer1
            // 
            reportDataSource9.Name = "DataSet1";
            reportDataSource9.Value = this.pasajerosConMenorCantidadDeMillasQueBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Menú_de_ejemplo.Reporte_pasajero_millas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 61);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(710, 383);
            this.reportViewer1.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(719, 450);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Granacia por recerva";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ingrese un año:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(208, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Filtrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // reportViewer3
            // 
            reportDataSource10.Name = "DataSet1";
            reportDataSource10.Value = this.gananciaGanadaPorReservaDuranteElAñoBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource10);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Menú_de_ejemplo.Reporte_ganacia_por_recerva.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 59);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(716, 391);
            this.reportViewer3.TabIndex = 15;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer4);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.textBox4);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(719, 450);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ganacia poromedio por año";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            reportDataSource11.Name = "DataSet1";
            reportDataSource11.Value = this.costoTotalPromedioDeReservasDuranteElAñoBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource11);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "Menú_de_ejemplo.Reporte_ganacia_promedio_por_anio.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(1, 44);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.Size = new System.Drawing.Size(716, 391);
            this.reportViewer4.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ingrese un año:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(209, 17);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(315, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Filtrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reportViewer5);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.textBox5);
            this.tabPage5.Controls.Add(this.button4);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(719, 450);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Aeropuertos por pais";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // reportViewer5
            // 
            reportDataSource12.Name = "DataSet1";
            reportDataSource12.Value = this.listadoDeAeropuertosYlocalidadDestinoPorPaisBindingSource;
            this.reportViewer5.LocalReport.DataSources.Add(reportDataSource12);
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "Menú_de_ejemplo.Report_aeropuertos.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(1, 44);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.Size = new System.Drawing.Size(716, 391);
            this.reportViewer5.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ingrese un pais:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(209, 17);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(315, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Filtrar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // codigoRecervaBindingSource
            // 
            this.codigoRecervaBindingSource.DataMember = "CodigoRecerva";
            this.codigoRecervaBindingSource.DataSource = this.dSNuevo;
            // 
            // dSNuevo
            // 
            this.dSNuevo.DataSetName = "DSNuevo";
            this.dSNuevo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pasajerosConMenorCantidadDeMillasQueBindingSource
            // 
            this.pasajerosConMenorCantidadDeMillasQueBindingSource.DataMember = "pasajerosConMenorCantidadDeMillasQue";
            this.pasajerosConMenorCantidadDeMillasQueBindingSource.DataSource = this.dSNuevo;
            // 
            // gananciaGanadaPorReservaDuranteElAñoBindingSource
            // 
            this.gananciaGanadaPorReservaDuranteElAñoBindingSource.DataMember = "gananciaGanadaPorReservaDuranteElAño";
            this.gananciaGanadaPorReservaDuranteElAñoBindingSource.DataSource = this.dSNuevo;
            // 
            // costoTotalPromedioDeReservasDuranteElAñoBindingSource
            // 
            this.costoTotalPromedioDeReservasDuranteElAñoBindingSource.DataMember = "costoTotalPromedioDeReservasDuranteElAño";
            this.costoTotalPromedioDeReservasDuranteElAñoBindingSource.DataSource = this.dSNuevo;
            // 
            // listadoDeAeropuertosYlocalidadDestinoPorPaisBindingSource
            // 
            this.listadoDeAeropuertosYlocalidadDestinoPorPaisBindingSource.DataMember = "listadoDeAeropuertosYlocalidadDestinoPorPais";
            this.listadoDeAeropuertosYlocalidadDestinoPorPaisBindingSource.DataSource = this.dSNuevo;
            // 
            // reservasPorMesBindingSource
            // 
            this.reservasPorMesBindingSource.DataMember = "reservasPorMes";
            this.reservasPorMesBindingSource.DataSource = this.dSNuevo;
            // 
            // codigoRecervaTableAdapter
            // 
            this.codigoRecervaTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.reportViewer6);
            this.tabPage6.Controls.Add(this.label6);
            this.tabPage6.Controls.Add(this.textBox6);
            this.tabPage6.Controls.Add(this.button5);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(719, 450);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Cntidad de recervas por mes";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // reportViewer6
            // 
            reportDataSource7.Name = "DataSet1";
            reportDataSource7.Value = this.reservasPorMesBindingSource;
            this.reportViewer6.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer6.LocalReport.ReportEmbeddedResource = "Menú_de_ejemplo.Reporte_cantidad_de_recervas_mes.rdlc";
            this.reportViewer6.Location = new System.Drawing.Point(1, 44);
            this.reportViewer6.Name = "reportViewer6";
            this.reportViewer6.Size = new System.Drawing.Size(716, 391);
            this.reportViewer6.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ingrese un mes:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(209, 17);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 25;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(315, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 24;
            this.button5.Text = "Filtrar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Frm_reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 514);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_reportes";
            this.Text = "Frm_reportes";
            this.Load += new System.EventHandler(this.Frm_reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertosBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoRecervaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajerosConMenorCantidadDeMillasQueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gananciaGanadaPorReservaDuranteElAñoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costoTotalPromedioDeReservasDuranteElAñoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDeAeropuertosYlocalidadDestinoPorPaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasPorMesBindingSource)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private aeropuertos aeropuertos;
        private System.Windows.Forms.BindingSource aeropuertosBindingSource;
        private aeropuertosTableAdapters.aeropuertosTableAdapter aeropuertosTableAdapter;
        private System.Windows.Forms.BindingSource codigoRecervaBindingSource;
        private DSNuevo dSNuevo;
        private DSNuevoTableAdapters.CodigoRecervaTableAdapter codigoRecervaTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pasajerosConMenorCantidadDeMillasQueBindingSource;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource gananciaGanadaPorReservaDuranteElAñoBindingSource;
        private System.Windows.Forms.TabPage tabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource costoTotalPromedioDeReservasDuranteElAñoBindingSource;
        private System.Windows.Forms.TabPage tabPage5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private System.Windows.Forms.BindingSource reservasPorMesBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource listadoDeAeropuertosYlocalidadDestinoPorPaisBindingSource;
        private System.Windows.Forms.TabPage tabPage6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button5;
    }
}