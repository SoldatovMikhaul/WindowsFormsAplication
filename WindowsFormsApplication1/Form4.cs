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
    public partial class Form4 : Form
    {
        public static string s;
        public Form4()
        {
            InitializeComponent();
            //LoadData();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet4.test2". При необходимости она может быть перемещена или удалена.
            this.test2TableAdapter2.FillBy(this.northwindDataSet4.test2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet3.test2". При необходимости она может быть перемещена или удалена.
            this.test2TableAdapter1.Fill(this.northwindDataSet3.test2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet3.test1". При необходимости она может быть перемещена или удалена.
            this.test1TableAdapter1.Fill(this.northwindDataSet3.test1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet11.test2". При необходимости она может быть перемещена или удалена.
            this.test2TableAdapter.Fill(this.northwindDataSet11.test2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet1.test1". При необходимости она может быть перемещена или удалена.
            this.test1TableAdapter.Fill(this.northwindDataSet1.test1);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection ThisConnection = new SqlConnection("Data Source=МИША-ПК\\SQLEXPRESS;Initial Catalog=MyDatabase;Persist Security Info=True;User ID=testSQL;Password=testSQL");
            ThisConnection.Open();
            SqlCommand thisCommand = ThisConnection.CreateCommand();

            textBox1.Clear();
            thisCommand.CommandText = @"select  number from test1 where id=@id";
            thisCommand.Parameters.AddWithValue("@id", textBox5.Text);

            SqlDataReader thisReader = thisCommand.ExecuteReader();
            while (thisReader.Read())
            {
                textBox1.Text += thisReader["number"].ToString();
            }
            thisReader.Close();

            SqlCommand thisCommand1 = ThisConnection.CreateCommand();
            textBox2.Clear();
            thisCommand1.CommandText = @"select dat from test1 where id=@id";
            thisCommand1.Parameters.AddWithValue("@id", textBox5.Text);
            SqlDataReader thisReader1 = thisCommand1.ExecuteReader();
            while (thisReader1.Read())
            {

                textBox2.Text += thisReader1["dat"].ToString();
            }
            thisReader1.Close();

            SqlCommand thisCommand2 = ThisConnection.CreateCommand();
            textBox3.Clear();
            thisCommand2.CommandText = @"select postavshik from test1 where id=@id";

            thisCommand2.Parameters.AddWithValue("@id", textBox5.Text);
            SqlDataReader thisReader2 = thisCommand2.ExecuteReader();
            while (thisReader2.Read())
            {

                textBox3.Text += thisReader2["postavshik"].ToString();
            }
            thisReader2.Close();

            SqlCommand thisCommand3 = ThisConnection.CreateCommand();
            textBox4.Clear();
            thisCommand3.CommandText = @"select naimenovnie from test1 where id=@id";
            thisCommand3.Parameters.AddWithValue("@id", textBox5.Text);
            SqlDataReader thisReader3 = thisCommand3.ExecuteReader();
            while (thisReader3.Read())
            {

                textBox4.Text += thisReader3["naimenovnie"].ToString();
            }
            thisReader3.Close();

            SqlCommand thisCommand4 = ThisConnection.CreateCommand();

            thisCommand4.CommandText = @"select id from test1 where id=@id";
            thisCommand4.Parameters.AddWithValue("@id", textBox5.Text);
            SqlDataReader thisReader4 = thisCommand4.ExecuteReader();
            while (thisReader4.Read())
            {

            }
            thisReader4.Close();

            ThisConnection.Close();
            ///Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection connect = new SqlConnection("Data Source=МИША-ПК\\QLEXPRESS;Initial Catalog=MyDatabase;User ID=testSQL;Password=testSQL");
            string sql = "update test1 set number=@number, dat=@dat, postavshik=@postavshik, naimenovnie=@naimenovnie where id=@id";
            SqlCommand cmd_SQL = new SqlCommand(sql, connect);

            cmd_SQL.Parameters.AddWithValue("@number", textBox1.Text);;
            cmd_SQL.Parameters.AddWithValue("@dat", textBox2.Text);
            cmd_SQL.Parameters.AddWithValue("@postavshik", textBox3.Text);
            cmd_SQL.Parameters.AddWithValue("@naimenovnie", textBox4.Text);
            cmd_SQL.Parameters.AddWithValue("@id", textBox5.Text);

           
                try
                {
                    connect.Open();
                    int n = cmd_SQL.ExecuteNonQuery();
                    MessageBox.Show(" обновленно {1} записей");
                    //textBox1.Text += String.Format(" обновленно {0} записей", n);

                }

                catch (SqlException ex)
                {
                    // throw new ApplicationException("error insert new_tovar", ex);
                }

                finally
                {
                    connect.Close();
                }

            }
        private void get_data()
        {


            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection connect = new SqlConnection("Data Source=МИША-ПК\\SQLEXPRESS;Initial Catalog=MyDatabase;User ID=testSQL;Password=testSQL");
            string sql = "select plu, qty, price, descr, id, nd, sprav_nd test2 where nd=@id";
            SqlCommand cmd_SQL = new SqlCommand(sql, connect);
            cmd_SQL.Parameters.AddWithValue("@id", textBox5.Text);
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f2 = new Form5();
            f2.Show();
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

           s = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
           Form5 f = new Form5();
           f.textBox7.Text=s;
           get_data();
           f.ShowDialog();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test2TableAdapter.FillBy1(this.northwindDataSet11.test2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test2TableAdapter.FillBy2(this.northwindDataSet11.test2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.test2TableAdapter.FillBy1(this.northwindDataSet11.test2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test2TableAdapter.FillBy3(this.northwindDataSet11.test2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy4ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test2TableAdapter.FillBy4(this.northwindDataSet11.test2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }


}