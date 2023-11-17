namespace Personnel_Management_System
{
    partial class FrmReports
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
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelDatabaseDataSet21 = new Personnel_Management_System.PersonelDatabaseDataSet2();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.personelDatabaseDataSet1 = new Personnel_Management_System.PersonelDatabaseDataSet();
            this.personelDatabaseDataSet2 = new Personnel_Management_System.PersonelDatabaseDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_PersonelTableAdapter1 = new Personnel_Management_System.PersonelDatabaseDataSet2TableAdapters.Tbl_PersonelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDatabaseDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDatabaseDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelDatabaseDataSet21;
            // 
            // personelDatabaseDataSet21
            // 
            this.personelDatabaseDataSet21.DataSetName = "PersonelDatabaseDataSet2";
            this.personelDatabaseDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelDatabaseDataSet1
            // 
            this.personelDatabaseDataSet1.DataSetName = "PersonelDatabaseDataSet";
            this.personelDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelDatabaseDataSet2
            // 
            this.personelDatabaseDataSet2.DataSetName = "PersonelDatabaseDataSet";
            this.personelDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblPersonelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Personnel_Management_System.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(29, 27);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1162, 492);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbl_PersonelTableAdapter1
            // 
            this.tbl_PersonelTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 581);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReports";
            this.Text = "FrmReports";
            this.Load += new System.EventHandler(this.FrmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDatabaseDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDatabaseDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private PersonelDatabaseDataSet personelDatabaseDataSet1;
        private PersonelDatabaseDataSet personelDatabaseDataSet2;
        private System.Windows.Forms.BindingSource Tbl_PersonelBindingSource;
        private PersonelDatabaseDataSetTableAdapters.Tbl_PersonelTableAdapter Tbl_PersonelTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PersonelDatabaseDataSet2 personelDatabaseDataSet21;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelDatabaseDataSet2TableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter1;
    }
}