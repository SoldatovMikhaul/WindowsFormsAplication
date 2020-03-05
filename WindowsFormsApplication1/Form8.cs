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
    public partial class Form8 : Form
    {
        public static string s;
        public static string b;
        public static int b1;
        public static int a1;
        public static string y1;
        DataSet ds;
        DataSet ds1;
        SqlDataAdapter adapter;
        SqlDataAdapter adapter1;
        SqlCommandBuilder commandBuilder;
        SqlCommandBuilder commandBuilder1;
        string connectionString = @"Data Source=МИША-ПК\SQLEXPRESS;Initial Catalog=MyDatabase;Persist Security Info=True;User ID=testSQL;Password=testSQL";
        string sql = "SELECT * FROM test1 where id = 0";
        string sql2 = "SELECT * FROM test2 where id = 0";
        string sql3 = "select plu, descr from tabletest3 where nd=@nd";
        public Form8(string t, int parametr2)
        {
            InitializeComponent();
            textBox2.Text = t;
            a1 = parametr2;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.AllowUserToAddRows = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);

                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter1 = new SqlDataAdapter(sql2, connection);
                ds1 = new DataSet();
                adapter1.Fill(ds1);
                dataGridView2.DataSource = ds1.Tables[0];//*/
            }
            Form1 f1 = new Form1();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
            //row.Field["id"].Value = 8;
            ds.Tables[0].Rows.Add(row);
            MessageBox.Show("введи запись для добавления");
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
           DataRow row = ds1.Tables[0].NewRow(); // добавляем новую строку в DataTable
            ds1.Tables[0].Rows.Add(row);
            MessageBox.Show("введи запись2 для добавления");//*/
            Form2 f2 = new Form2();
            //textBox1.Text = Form2.s1;// ((Form)(f2)).s1;
            f2.ShowDialog();
            textBox1.Text = Form2.s1;// ((Form)(f2)).s1;
            textBox3.Text = Form2.s2;
            textBox4.Text = Form2.s3;
            row["plu"] = Form2.s1;
            row["descr"] = Form2.s2;
           
            //textBox1.Text=((Form2)(f2)).s1;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet4.test2". При необходимости она может быть перемещена или удалена.
            this.test2TableAdapter.Fill(this.northwindDataSet4.test2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet1.test1". При необходимости она может быть перемещена или удалена.
            this.test1TableAdapter1.Fill(this.northwindDataSet1.test1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet12.test1". При необходимости она может быть перемещена или удалена.
/*1*/       this.test1TableAdapter.Fill(this.northwindDataSet12.test1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet1.test1". При необходимости она может быть перемещена или удалена.
            //this.test1TableAdapter.Fill(this.northwindDataSet1.test1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet1.test1". При необходимости она может быть перемещена или удалена.
            //this.test1TableAdapter.Fill(this.northwindDataSet1.test1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet1.test1". При необходимости она может быть перемещена или удалена.
            //this.test1TableAdapter.Fill(this.northwindDataSet1.test1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet3.test2". При необходимости она может быть перемещена или удалена.
            //this.test2TableAdapter.Fill(this.northwindDataSet3.test2);
           // this.dataGridView1.Columns[4].Visible = false;
            this.dataGridView2.Columns[5].Visible = false;
            this.dataGridView2.Columns[4].Visible = false;

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
/*2*/       this.test1TableAdapter.Fill(this.northwindDataSet12.test1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
/*3*/       this.test1TableAdapter.Fill(this.northwindDataSet12.test1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
/*4*/       this.test1TableAdapter.Fill(this.northwindDataSet12.test1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
/*5*/       this.test1TableAdapter.Fill(this.northwindDataSet12.test1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //начало save button
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(adapter);
                adapter.InsertCommand = new SqlCommand("sp_CreateUser1", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@number", SqlDbType.Int, 0, "number"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@dat", SqlDbType.DateTime, 0, "dat"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@postavshik", SqlDbType.VarChar, 0, "postavshik"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@naimenovnie", SqlDbType.VarChar, 0, "naimenovnie"));
                //adapter.InsertCommand.Parameters.Add(new SqlParameter("@tip", SqlDbType.Int, 0, "tip"));
                //adapter1.InsertCommand.Parameters.Add("@nd", SqlDbType.Int).Value = b1;
                adapter.InsertCommand.Parameters.Add("@tip", SqlDbType.Int).Value = a1;

                SqlParameter parameter = adapter.InsertCommand.Parameters.Add("id", SqlDbType.Int, 0, "id");
                parameter.Direction = ParameterDirection.Output;
 
                adapter.Update(ds);
            }
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveButton1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                //начало save button
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(adapter);
                adapter.InsertCommand = new SqlCommand("sp_CreateUser1", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@number", SqlDbType.Int, 0, "number"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@dat", SqlDbType.VarChar, 0, "dat"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@postavshik", SqlDbType.VarChar, 0, "postavshik"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@naimenovnie", SqlDbType.VarChar, 0, "naimenovnie"));
                //adapter.InsertCommand.Parameters.Add(new SqlParameter("@tip", SqlDbType.Int, 0, "tip"));
                //adapter1.InsertCommand.Parameters.Add("@nd", SqlDbType.Int).Value = b1;
                adapter.InsertCommand.Parameters.Add("@tip", SqlDbType.Int).Value = a1;

                SqlParameter parameter = adapter.InsertCommand.Parameters.Add("id", SqlDbType.Int, 0, "id");
                parameter.Direction = ParameterDirection.Output;

                adapter.Update(ds);
                b = dataGridView1[4, 0].Value.ToString();
                b1 = Convert.ToInt32(b);
                adapter1 = new SqlDataAdapter(sql2, connection);
                commandBuilder1 = new SqlCommandBuilder(adapter1);
                adapter1.InsertCommand = new SqlCommand("sp_CreateUser2", connection);
                adapter1.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter1.InsertCommand.Parameters.Add(new SqlParameter("@plu", SqlDbType.Int, 0, "plu"));
                adapter1.InsertCommand.Parameters.Add(new SqlParameter("@qty", SqlDbType.Decimal, 0, "qty"));
                adapter1.InsertCommand.Parameters.Add(new SqlParameter("@price", SqlDbType.Money, 0, "price"));
                adapter1.InsertCommand.Parameters.Add(new SqlParameter("@descr", SqlDbType.VarChar, 0, "descr"));
                adapter1.InsertCommand.Parameters.Add("@nd", SqlDbType.Int).Value=b1;
                //adapter1.InsertCommand.Parameters.Add(new SqlParameter("@nd", SqlDbType.Int, 0, "nd"));
                //adapter1.InsertCommand.Parameters.Add(dataGridView1.CurrentCell.Value.ToString());
                adapter1.InsertCommand.Parameters.Add("@sprav_nd", SqlDbType.Int).Value = 0;

                SqlParameter parameter1 = adapter1.InsertCommand.Parameters.Add("id", SqlDbType.Int, 0, "id");
              
                parameter1.Direction = ParameterDirection.Output;
                //dataGridView1.Refresh();
                adapter1.Update(ds1);
                //dataGridView2.Refresh();
                //this.test2TableAdapter.FillBy1(this.northwindDataSet4.test2, b1);
                test2TableAdapter.Fill(northwindDataSet4.test2);
                dataGridView2.Refresh();
                MessageBox.Show("Сохранено");
            }
        }


        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.test2TableAdapter.Fill(this.northwindDataSet4.test2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.test2TableAdapter.Fill(this.northwindDataSet4.test2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton2_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test2TableAdapter.Fill(this.northwindDataSet4.test2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView2_Click(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Refresh();
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {

            dataGridView2.Refresh();
            //textBox2.Text = "a";
        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }        
    }
}
