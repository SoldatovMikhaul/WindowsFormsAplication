using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        Form8 f;
        public static string s1;
        public static string s2;
        public static string s3;
        string connectionString = @"Data Source=МИША-ПК\SQLEXPRESS;Initial Catalog=MyDatabase;Persist Security Info=True;User ID=testSQL;Password=testSQL";
        public Form2()
        {
            InitializeComponent();
            //f = fs;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet8.tabletest2". При необходимости она может быть перемещена или удалена.
            this.tabletest2TableAdapter.Fill(this.northwindDataSet8.tabletest2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet8.tabletest1". При необходимости она может быть перемещена или удалена.
            this.tabletest1TableAdapter.Fill(this.northwindDataSet8.tabletest1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet10.tabletest3". При необходимости она может быть перемещена или удалена.
            this.tabletest3TableAdapter1.Fill(this.northwindDataSet10.tabletest3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet9.tabletest1". При необходимости она может быть перемещена или удалена.
            this.tabletest1TableAdapter1.Fill1(this.northwindDataSet9.tabletest1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet1.test1". При необходимости она может быть перемещена или удалена.
            this.test1TableAdapter.Fill(this.northwindDataSet1.test1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet8.tabletest3". При необходимости она может быть перемещена или удалена.
            this.tabletest3TableAdapter.Fill(this.northwindDataSet8.tabletest3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet8.tabletest2". При необходимости она может быть перемещена или удалена.
            this.tabletest2TableAdapter.Fill(this.northwindDataSet8.tabletest2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet8.tabletest1". При необходимости она может быть перемещена или удалена.
            this.tabletest1TableAdapter.Fill(this.northwindDataSet8.tabletest1);

        }

        private void dataGridView1_CellClick(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            s1 = dataGridView3[0, dataGridView3.CurrentRow.Index].Value.ToString();
            s2 = dataGridView3[1, dataGridView3.CurrentRow.Index].Value.ToString();
            //s3 = dataGridView3[3, dataGridView3.CurrentRow.Index].Value.ToString();

            Close();
        }
    }
}
