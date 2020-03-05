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
    public partial class Form1 : Form
    {
        public static string s;
        string connectionString = @"Data Source=МИША-ПК\SQLEXPRESS;Initial Catalog=MyDatabase;Persist Security Info=True;User ID=testSQl;Password=testSQl";
        
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet71.tabletest2". При необходимости она может быть перемещена или удалена.
            this.tabletest2TableAdapter.Fill(this.northwindDataSet71.tabletest2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet51.tabletest3". При необходимости она может быть перемещена или удалена.
            this.tabletest3TableAdapter.Fill(this.northwindDataSet51.tabletest3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet31.test2". При необходимости она может быть перемещена или удалена.
            this.test2TableAdapter.Fill(this.northwindDataSet31.test2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet31.test1". При необходимости она может быть перемещена или удалена.
            this.test1TableAdapter1.Fill(this.northwindDataSet31.test1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet11.test1". При необходимости она может быть перемещена или удалена.
            this.test1TableAdapter.Fill(this.northwindDataSet11.test1);

        }

        private void northwindDataSet51BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void test2BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void test1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 f = new Form2();
            f.Show();

        }


        private void button2_Click_1(object sender, EventArgs e)//"update"
        {

            Form4 f2 = new Form4();
            f2.Show();
        }


        /*private void button3_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            f1.Show();
        }*/



        private void button5_Click(object sender, EventArgs e)
        {
            /*Form7 f3 = new Form7();
            f3.Show();*/
            s = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            Form7 f = new Form7();
            f.textBox5.Text = s;
            //get_data();
            f.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            /*s = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            Form7 f = new Form7();
            f.textBox5.Text = s;
            //get_data();
            f.ShowDialog();*/
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection connect = new SqlConnection("Data Source=МИША-ПК\\SQLEXPRESS;Initial Catalog=MyDatabase;User ID=testSQL;Password=testSQL");
            string sql = "select plu, qty, price, descr, id, nd, sprav_nd test2 where nd=@id";
            SqlCommand cmd_SQL = new SqlCommand(sql, connect);
            Form7 f = new Form7();
            cmd_SQL.Parameters.AddWithValue("@id", f.textBox5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form8 f8 = new Form8("приход", 1);
                f8.ShowDialog();
                dataGridView1.Refresh();
                dataGridView2.Refresh();
                this.test1TableAdapter1.FillBy1(this.northwindDataSet31.test1, 1);
                test2BindingSource.ResetBindings(false);
                this.test2TableAdapter.Fill(this.northwindDataSet31.test2);

            }
            if (radioButton2.Checked)
            {
                Form8 f8 = new Form8("рассход", 2);
                f8.ShowDialog();
                dataGridView1.Refresh();
                dataGridView2.Refresh();
                this.test1TableAdapter1.FillBy1(this.northwindDataSet31.test1, 2);
                test2BindingSource.ResetBindings(false);
                this.test2TableAdapter.Fill(this.northwindDataSet31.test2);
            }
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            // приводим отправителя к элементу типа RadioButton
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                this.test1TableAdapter1.FillBy1(this.northwindDataSet31.test1, 1);
                test2BindingSource.ResetBindings(false);
                this.test2TableAdapter.Fill(this.northwindDataSet31.test2);
                dataGridView1.Refresh();
                dataGridView2.Refresh();


            }
        }
        private void radioButton1_ChekedChanged(object sender, EventArgs e)
        {
            // приводим отправителя к элементу типа RadioButton
            RadioButton radioButton1 = (RadioButton)sender;
            if (radioButton1.Checked)
            {
                this.test1TableAdapter1.FillBy1(this.northwindDataSet31.test1, 2);
                test2BindingSource.ResetBindings(false);
                this.test2TableAdapter.Fill(this.northwindDataSet31.test2);
                dataGridView1.Refresh();
                dataGridView2.Refresh();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            s = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            Form11 f11 = new Form11();
            f11.textBox1.Text = s;
            f11.ShowDialog();
        }
    }
}
