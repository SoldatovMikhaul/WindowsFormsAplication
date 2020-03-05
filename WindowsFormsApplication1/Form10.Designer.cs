namespace WindowsFormsApplication1
{
    partial class Form10
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.northwindDataSet3 = new WindowsFormsApplication1.NorthwindDataSet3();
            this.northwindDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.usr_proc123BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet15 = new WindowsFormsApplication1.NorthwindDataSet15();
            this.northwindDataSet15BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usrproc123BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet16 = new WindowsFormsApplication1.NorthwindDataSet16();
            this.usr_proc123TableAdapter1 = new WindowsFormsApplication1.NorthwindDataSet16TableAdapters.usr_proc123TableAdapter();
            this.usr_proc123TableAdapter = new WindowsFormsApplication1.NorthwindDataSet16TableAdapters.usr_proc123TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usr_proc123BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet15BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrproc123BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(51, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "dat1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(359, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "dat2";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(445, 30);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // northwindDataSet3
            // 
            this.northwindDataSet3.DataSetName = "northwindDataSet3";
            this.northwindDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // northwindDataSet3BindingSource
            // 
            this.northwindDataSet3BindingSource.DataSource = this.northwindDataSet3;
            this.northwindDataSet3BindingSource.Position = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(140, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "postavshik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(387, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "saldo_na_dat_1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(545, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "id";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(34, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(50, 20);
            this.textBox3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(675, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "oborot";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(749, 74);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(886, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "saldo_na_dat_2";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1045, 73);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usr_proc123BindingSource
            // 
            this.usr_proc123BindingSource.DataMember = "usr_proc123";
            this.usr_proc123BindingSource.DataSource = this.northwindDataSet15;
            // 
            // northwindDataSet15
            // 
            this.northwindDataSet15.DataSetName = "NorthwindDataSet15";
            this.northwindDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // northwindDataSet15BindingSource
            // 
            this.northwindDataSet15BindingSource.DataSource = this.northwindDataSet15;
            this.northwindDataSet15BindingSource.Position = 0;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "NorthwindDataSet16_usr_proc123";
            reportDataSource1.Value = this.usr_proc123BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report8.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 100);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1365, 408);
            this.reportViewer1.TabIndex = 17;
            // 
            // usrproc123BindingSource
            // 
            this.usrproc123BindingSource.DataMember = "usr_proc123";
            this.usrproc123BindingSource.DataSource = this.northwindDataSet16;
            // 
            // northwindDataSet16
            // 
            this.northwindDataSet16.DataSetName = "NorthwindDataSet16";
            this.northwindDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usr_proc123TableAdapter1
            // 
            this.usr_proc123TableAdapter1.ClearBeforeFill = true;
            // 
            // usr_proc123TableAdapter
            // 
            this.usr_proc123TableAdapter.ClearBeforeFill = true;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 542);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usr_proc123BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet15BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrproc123BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.BindingSource northwindDataSet3BindingSource;
        private NorthwindDataSet3 northwindDataSet3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource northwindDataSet15BindingSource;
        private NorthwindDataSet15 northwindDataSet15;
        private System.Windows.Forms.BindingSource usr_proc123BindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private NorthwindDataSet16 northwindDataSet16;
        private System.Windows.Forms.BindingSource usrproc123BindingSource;
        private WindowsFormsApplication1.NorthwindDataSet16TableAdapters.usr_proc123TableAdapter usr_proc123TableAdapter1;
        private WindowsFormsApplication1.NorthwindDataSet16TableAdapters.usr_proc123TableAdapter usr_proc123TableAdapter;
    }
}