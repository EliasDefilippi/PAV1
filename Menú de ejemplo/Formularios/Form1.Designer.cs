namespace Menú_de_ejemplo.Formularios
{
    partial class Form1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lAFAST_gestor_de_reservasDataSet3 = new Menú_de_ejemplo.LAFAST_gestor_de_reservasDataSet3();
            this.lAFASTgestordereservasDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vuelosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vuelosTableAdapter = new Menú_de_ejemplo.LAFAST_gestor_de_reservasDataSet3TableAdapters.vuelosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lAFAST_gestor_de_reservasDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAFASTgestordereservasDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vuelosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.lAFASTgestordereservasDataSet3BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Menú_de_ejemplo.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(69, 32);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // lAFAST_gestor_de_reservasDataSet3
            // 
            this.lAFAST_gestor_de_reservasDataSet3.DataSetName = "LAFAST_gestor_de_reservasDataSet3";
            this.lAFAST_gestor_de_reservasDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lAFASTgestordereservasDataSet3BindingSource
            // 
            this.lAFASTgestordereservasDataSet3BindingSource.DataSource = this.lAFAST_gestor_de_reservasDataSet3;
            this.lAFASTgestordereservasDataSet3BindingSource.Position = 0;
            // 
            // vuelosBindingSource
            // 
            this.vuelosBindingSource.DataMember = "vuelos";
            this.vuelosBindingSource.DataSource = this.lAFASTgestordereservasDataSet3BindingSource;
            // 
            // vuelosTableAdapter
            // 
            this.vuelosTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 419);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lAFAST_gestor_de_reservasDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAFASTgestordereservasDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vuelosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource lAFASTgestordereservasDataSet3BindingSource;
        private LAFAST_gestor_de_reservasDataSet3 lAFAST_gestor_de_reservasDataSet3;
        private System.Windows.Forms.BindingSource vuelosBindingSource;
        private LAFAST_gestor_de_reservasDataSet3TableAdapters.vuelosTableAdapter vuelosTableAdapter;
    }
}