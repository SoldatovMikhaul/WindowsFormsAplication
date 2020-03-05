namespace WindowsFormsApplication1
{
    partial class Form7
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.test2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet11 = new WindowsFormsApplication1.NorthwindDataSet11();
            this.test2BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.test1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NorthwindDataSet1 = new WindowsFormsApplication1.NorthwindDataSet1();
            this.test1TableAdapter = new WindowsFormsApplication1.NorthwindDataSet1TableAdapters.test1TableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.test1TableAdapter1 = new WindowsFormsApplication1.NorthwindDataSet1TableAdapters.test1TableAdapter();
            this.test1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.test1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.test2TableAdapter = new WindowsFormsApplication1.NorthwindDataSet11TableAdapters.test2TableAdapter();
            this.test2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.test2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test2BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1BindingSource2)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.test2BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // test2BindingSource
            // 
            this.test2BindingSource.DataMember = "test2";
            this.test2BindingSource.DataSource = this.northwindDataSet11;
            this.test2BindingSource.CurrentChanged += new System.EventHandler(this.test2BindingSource_CurrentChanged);
            // 
            // northwindDataSet11
            // 
            this.northwindDataSet11.DataSetName = "NorthwindDataSet11";
            this.northwindDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // test2BindingSource2
            // 
            this.test2BindingSource2.DataMember = "test2";
            this.test2BindingSource2.DataSource = this.northwindDataSet11;
            // 
            // test1BindingSource
            // 
            this.test1BindingSource.DataMember = "test1";
            this.test1BindingSource.DataSource = this.NorthwindDataSet1;
            // 
            // NorthwindDataSet1
            // 
            this.NorthwindDataSet1.DataSetName = "NorthwindDataSet1";
            this.NorthwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // test1TableAdapter
            // 
            this.test1TableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "test1";
            this.bindingSource1.DataSource = this.NorthwindDataSet1;
            // 
            // test1TableAdapter1
            // 
            this.test1TableAdapter1.ClearBeforeFill = true;
            // 
            // test1BindingSource1
            // 
            this.test1BindingSource1.DataMember = "test1";
            this.test1BindingSource1.DataSource = this.NorthwindDataSet1;
            // 
            // test1BindingSource2
            // 
            this.test1BindingSource2.DataMember = "test1";
            this.test1BindingSource2.DataSource = this.NorthwindDataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "номер";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(341, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "дата";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(405, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(624, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "поставщик";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(774, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(201, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "название";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(150, 116);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(201, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.Location = new System.Drawing.Point(399, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "id";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(440, 116);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(201, 20);
            this.textBox5.TabIndex = 11;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(628, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "название";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1366, 25);
            this.fillToolStrip.TabIndex = 13;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // test2TableAdapter
            // 
            this.test2TableAdapter.ClearBeforeFill = true;
            // 
            // test2BindingSource1
            // 
            this.test2BindingSource1.DataMember = "test2";
            this.test2BindingSource1.DataSource = this.northwindDataSet11;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            reportDataSource2.Name = "NorthwindDataSet11_test2";
            reportDataSource2.Value = this.test2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 182);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reportViewer1.Size = new System.Drawing.Size(1366, 540);
            this.reportViewer1.TabIndex = 14;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1366, 734);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.Shown += new System.EventHandler(this.Form7_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.test2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test2BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1BindingSource2)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.test2BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NorthwindDataSet11 northwindDataSet11;
        private System.Windows.Forms.BindingSource test2BindingSource;
        private WindowsFormsApplication1.NorthwindDataSet11TableAdapters.test2TableAdapter test2TableAdapter;
        private System.Windows.Forms.BindingSource test2BindingSource1;
        private System.Windows.Forms.BindingSource test1BindingSource;
        private NorthwindDataSet1 NorthwindDataSet1;
        private WindowsFormsApplication1.NorthwindDataSet1TableAdapters.test1TableAdapter test1TableAdapter;
        private System.Windows.Forms.BindingSource test2BindingSource2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private WindowsFormsApplication1.NorthwindDataSet1TableAdapters.test1TableAdapter test1TableAdapter1;
        private System.Windows.Forms.BindingSource test1BindingSource1;
        private System.Windows.Forms.BindingSource test1BindingSource2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.TextBox textBox5;
    }
}