namespace WindowsFormsApplication1
{
    partial class Form6
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
            this.NorthwindDataSet1 = new WindowsFormsApplication1.NorthwindDataSet1();
            this.test1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test1TableAdapter = new WindowsFormsApplication1.NorthwindDataSet1TableAdapters.test1TableAdapter();
            this.test1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NorthwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "NorthwindDataSet1_test1";
            reportDataSource1.Value = this.test1BindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(807, 305);
            this.reportViewer1.TabIndex = 0;
            // 
            // NorthwindDataSet1
            // 
            this.NorthwindDataSet1.DataSetName = "NorthwindDataSet1";
            this.NorthwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // test1BindingSource
            // 
            this.test1BindingSource.DataMember = "test1";
            this.test1BindingSource.DataSource = this.NorthwindDataSet1;
            // 
            // test1TableAdapter
            // 
            this.test1TableAdapter.ClearBeforeFill = true;
            // 
            // test1BindingSource1
            // 
            this.test1BindingSource1.DataMember = "test1";
            this.test1BindingSource1.DataSource = this.NorthwindDataSet1;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 322);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NorthwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource test1BindingSource;
        private NorthwindDataSet1 NorthwindDataSet1;
        private WindowsFormsApplication1.NorthwindDataSet1TableAdapters.test1TableAdapter test1TableAdapter;
        private System.Windows.Forms.BindingSource test1BindingSource1;
    }
}