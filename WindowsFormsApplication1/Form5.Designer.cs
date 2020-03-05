namespace WindowsFormsApplication1
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.test2TableAdapter2 = new WindowsFormsApplication1.NorthwindDataSet4TableAdapters.test2TableAdapter();
            this.northwindDataSet11 = new WindowsFormsApplication1.NorthwindDataSet1();
            this.northwindDataSet111 = new WindowsFormsApplication1.NorthwindDataSet11();
            this.test1TableAdapter1 = new WindowsFormsApplication1.NorthwindDataSet3TableAdapters.test1TableAdapter();
            this.test1TableAdapter2 = new WindowsFormsApplication1.NorthwindDataSet3TableAdapters.test1TableAdapter();
            this.northwindDataSet3 = new WindowsFormsApplication1.NorthwindDataSet3();
            this.test2TableAdapter = new WindowsFormsApplication1.NorthwindDataSet3TableAdapters.test2TableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.NorthwindDataSet3TableAdapters.TableAdapterManager();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet111)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(103, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(42, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "кол-во";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(63, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "описание";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(376, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(376, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(144, 83);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(376, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(144, 113);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(262, 20);
            this.textBox7.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 53);
            this.button1.TabIndex = 14;
            this.button1.Text = "обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "найти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // test2TableAdapter2
            // 
            this.test2TableAdapter2.ClearBeforeFill = true;
            // 
            // northwindDataSet11
            // 
            this.northwindDataSet11.DataSetName = "NorthwindDataSet1";
            this.northwindDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // northwindDataSet111
            // 
            this.northwindDataSet111.DataSetName = "NorthwindDataSet11";
            this.northwindDataSet111.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // test1TableAdapter1
            // 
            this.test1TableAdapter1.ClearBeforeFill = true;
            // 
            // test1TableAdapter2
            // 
            this.test1TableAdapter2.ClearBeforeFill = true;
            // 
            // northwindDataSet3
            // 
            this.northwindDataSet3.DataSetName = "NorthwindDataSet3";
            this.northwindDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // test2TableAdapter
            // 
            this.test2TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.test1TableAdapter = null;
            this.tableAdapterManager.test2TableAdapter = this.test2TableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.NorthwindDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(412, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "отмена";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 223);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "nd";
            this.Shown += new System.EventHandler(this.Form5_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet111)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private NorthwindDataSet11 northwindDataSet111;
        private NorthwindDataSet1 northwindDataSet11;
        private WindowsFormsApplication1.NorthwindDataSet4TableAdapters.test2TableAdapter test2TableAdapter2;
        private WindowsFormsApplication1.NorthwindDataSet3TableAdapters.test1TableAdapter test1TableAdapter1;
        private WindowsFormsApplication1.NorthwindDataSet3TableAdapters.test1TableAdapter test1TableAdapter2;
        private NorthwindDataSet3 northwindDataSet3;
        private WindowsFormsApplication1.NorthwindDataSet3TableAdapters.test2TableAdapter test2TableAdapter;
        private WindowsFormsApplication1.NorthwindDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox textBox7;
    }
}