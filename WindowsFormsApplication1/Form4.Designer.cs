namespace WindowsFormsApplication1
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spravndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test2BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet11 = new WindowsFormsApplication1.NorthwindDataSet11();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.database7DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.test1test2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.test2BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.test2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test2TableAdapter = new WindowsFormsApplication1.NorthwindDataSet11TableAdapters.test2TableAdapter();
            this.northwindDataSet4 = new WindowsFormsApplication1.NorthwindDataSet4();
            this.test2TableAdapter2 = new WindowsFormsApplication1.NorthwindDataSet4TableAdapters.test2TableAdapter();
            this.test1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet1 = new WindowsFormsApplication1.NorthwindDataSet1();
            this.test1TableAdapter = new WindowsFormsApplication1.NorthwindDataSet1TableAdapters.test1TableAdapter();
            this.test1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.test1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.test1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet3 = new WindowsFormsApplication1.NorthwindDataSet3();
            this.test1TableAdapter1 = new WindowsFormsApplication1.NorthwindDataSet3TableAdapters.test1TableAdapter();
            this.test2TableAdapter1 = new WindowsFormsApplication1.NorthwindDataSet3TableAdapters.test2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test2BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database7DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1test2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test2BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.pluDataGridViewTextBoxColumn,
            this.descrDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.ndDataGridViewTextBoxColumn,
            this.spravndDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.test2BindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 221);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pluDataGridViewTextBoxColumn
            // 
            this.pluDataGridViewTextBoxColumn.DataPropertyName = "plu";
            this.pluDataGridViewTextBoxColumn.HeaderText = "код";
            this.pluDataGridViewTextBoxColumn.Name = "pluDataGridViewTextBoxColumn";
            // 
            // descrDataGridViewTextBoxColumn
            // 
            this.descrDataGridViewTextBoxColumn.DataPropertyName = "descr";
            this.descrDataGridViewTextBoxColumn.HeaderText = "описание";
            this.descrDataGridViewTextBoxColumn.Name = "descrDataGridViewTextBoxColumn";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "кол-во";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // ndDataGridViewTextBoxColumn
            // 
            this.ndDataGridViewTextBoxColumn.DataPropertyName = "nd";
            this.ndDataGridViewTextBoxColumn.HeaderText = "nd";
            this.ndDataGridViewTextBoxColumn.Name = "ndDataGridViewTextBoxColumn";
            // 
            // spravndDataGridViewTextBoxColumn
            // 
            this.spravndDataGridViewTextBoxColumn.DataPropertyName = "sprav_nd";
            this.spravndDataGridViewTextBoxColumn.HeaderText = "sprav_nd";
            this.spravndDataGridViewTextBoxColumn.Name = "spravndDataGridViewTextBoxColumn";
            // 
            // test2BindingSource3
            // 
            this.test2BindingSource3.DataMember = "test2";
            this.test2BindingSource3.DataSource = this.northwindDataSet11;
            // 
            // northwindDataSet11
            // 
            this.northwindDataSet11.DataSetName = "NorthwindDataSet11";
            this.northwindDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(547, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(203, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(547, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(203, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(547, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(203, 140);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(547, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(203, 177);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(466, 20);
            this.textBox5.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(104, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "номер";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(125, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(47, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "поставщик";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "наименование";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(162, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(113, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 45);
            this.button2.TabIndex = 12;
            this.button2.Text = "обновить для таблицы test1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(532, 447);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 45);
            this.button3.TabIndex = 13;
            this.button3.Text = "изменит данные таблицы test2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // test1test2BindingSource
            // 
            this.test1test2BindingSource.DataMember = "test1_test2";
            this.test1test2BindingSource.DataSource = this.test1BindingSource2;
            // 
            // test2BindingSource
            // 
            this.test2BindingSource.DataMember = "test2";
            this.test2BindingSource.DataSource = this.northwindDataSet11;
            // 
            // test2TableAdapter
            // 
            this.test2TableAdapter.ClearBeforeFill = true;
            // 
            // northwindDataSet4
            // 
            this.northwindDataSet4.DataSetName = "NorthwindDataSet4";
            this.northwindDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // test2TableAdapter2
            // 
            this.test2TableAdapter2.ClearBeforeFill = true;
            // 
            // test1BindingSource
            // 
            this.test1BindingSource.DataMember = "test1";
            this.test1BindingSource.DataSource = this.northwindDataSet1;
            // 
            // northwindDataSet1
            // 
            this.northwindDataSet1.DataSetName = "NorthwindDataSet1";
            this.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // test1TableAdapter
            // 
            this.test1TableAdapter.ClearBeforeFill = true;
            // 
            // test1BindingSource1
            // 
            this.test1BindingSource1.DataMember = "test1";
            this.test1BindingSource1.DataSource = this.northwindDataSet1;
            // 
            // test1BindingSource3
            // 
            this.test1BindingSource3.DataMember = "test1";
            this.test1BindingSource3.DataSource = this.northwindDataSet1;
            // 
            // test1BindingSource2
            // 
            this.test1BindingSource2.DataMember = "test1";
            this.test1BindingSource2.DataSource = this.northwindDataSet3;
            // 
            // northwindDataSet3
            // 
            this.northwindDataSet3.DataSetName = "NorthwindDataSet3";
            this.northwindDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // test1TableAdapter1
            // 
            this.test1TableAdapter1.ClearBeforeFill = true;
            // 
            // test2TableAdapter1
            // 
            this.test2TableAdapter1.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 512);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test2BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database7DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1test2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test2BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private NorthwindDataSet1 northwindDataSet1;
        private System.Windows.Forms.BindingSource test1BindingSource;
        private WindowsFormsApplication1.NorthwindDataSet1TableAdapters.test1TableAdapter test1TableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource test1BindingSource1;
        private NorthwindDataSet11 northwindDataSet11;
        private System.Windows.Forms.BindingSource test2BindingSource;
        private WindowsFormsApplication1.NorthwindDataSet11TableAdapters.test2TableAdapter test2TableAdapter;
        private NorthwindDataSet3 northwindDataSet3;
        private System.Windows.Forms.BindingSource test1BindingSource2;
        private WindowsFormsApplication1.NorthwindDataSet3TableAdapters.test1TableAdapter test1TableAdapter1;
        private System.Windows.Forms.BindingSource test1test2BindingSource;
        private WindowsFormsApplication1.NorthwindDataSet3TableAdapters.test2TableAdapter test2TableAdapter1;
        private System.Windows.Forms.BindingSource test2BindingSource1;
        private NorthwindDataSet4 northwindDataSet4;
        private System.Windows.Forms.BindingSource test2BindingSource2;
        private WindowsFormsApplication1.NorthwindDataSet4TableAdapters.test2TableAdapter test2TableAdapter2;
        private System.Windows.Forms.BindingSource test2BindingSource3;
        private System.Windows.Forms.BindingSource test1BindingSource3;
        private System.Windows.Forms.BindingSource database7DataSetBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spravndDataGridViewTextBoxColumn;
    }
}