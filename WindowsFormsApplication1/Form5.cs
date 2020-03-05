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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("Data Source=МИША-ПК\\SQLEXPRESS;Initial Catalog=MyDatabase;User ID=testSQL;Password=testSQl");
            string sql = "update test2 set  /*plu=@plu, qty=@qty,*/ price=@price, descr=@descr/*, nd=@nd, sprav_nd=@sprav_nd*/ where id=@id";
            SqlCommand cmd_SQL = new SqlCommand(sql, connect);

            //cmd_SQL.Parameters.AddWithValue("@plu", textBox1.Text);
            cmd_SQL.Parameters.AddWithValue("@qty", System.Convert.ToDecimal(textBox2.Text));
            cmd_SQL.Parameters.AddWithValue("@price", System.Convert.ToDecimal(textBox3.Text));
            cmd_SQL.Parameters.AddWithValue("@descr", textBox4.Text);
            //cmd_SQL.Parameters.AddWithValue("@nd", textBox5.Text);
            //cmd_SQL.Parameters.AddWithValue("@sprav_nd", textBox6.Text);
            textBox7.Text = Form4.s;
            cmd_SQL.Parameters.AddWithValue("@id", textBox7.Text);
            


            try
            {
                connect.Open();
                int n = cmd_SQL.ExecuteNonQuery();
                MessageBox.Show(" обновленно {1} записей");


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

        private void button2_Click(object sender, EventArgs e)
        {
            //*
            try
            {
                this.test2TableAdapter.FillBy(this.northwindDataSet3.test2);// ((int)(System.Convert.ChangeType(textBox7.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }//*/

            SqlConnection ThisConnection = new SqlConnection("Data Source=МИША-ПК\\SQLEXPRESS;Initial Catalog=MyDatabase;Persist Security Info=True;User ID=testSQL;Password=testSQL");
            ThisConnection.Open();


            SqlCommand thisCommand1 = ThisConnection.CreateCommand();
            //textBox2.Clear();
            thisCommand1.CommandText = @"select qty from test2 where id=@id";
            thisCommand1.Parameters.AddWithValue("@id", textBox7.Text);
            SqlDataReader thisReader1 = thisCommand1.ExecuteReader();
            while (thisReader1.Read())
            {

                textBox2.Text += thisReader1["qty"].ToString();
            }
            thisReader1.Close();

            SqlCommand thisCommand2 = ThisConnection.CreateCommand();
            thisCommand2.CommandText = @"select price from test2 where id=@id";
            thisCommand2.Parameters.AddWithValue("@id", textBox7.Text);
            SqlDataReader thisReader2 = thisCommand2.ExecuteReader();
            while (thisReader2.Read())
            {
                textBox3.Text += thisReader2["price"].ToString();
            }
            thisReader2.Close();

            SqlCommand thisCommand3 = ThisConnection.CreateCommand();
            thisCommand3.CommandText = @"select descr from test2 where id=@id";
            thisCommand3.Parameters.AddWithValue("@id", textBox7.Text);
            SqlDataReader thisReader3 = thisCommand3.ExecuteReader();
            while (thisReader3.Read())
            {
                textBox4.Text += thisReader3["descr"].ToString();
            }
            thisReader3.Close();

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test2TableAdapter.FillBy(this.northwindDataSet3.test2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form5_Shown(object sender, EventArgs e)
        {
            try
            {
                this.test2TableAdapter.FillBy(this.northwindDataSet3.test2);// ((int)(System.Convert.ChangeType(textBox7.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }//*/

            SqlConnection ThisConnection = new SqlConnection("Data Source=МИША-ПК\\SQLEXPRESS;Initial Catalog=MyDatabasePersist Security Info=True;User ID=testSQL;Password=testSQL");
            ThisConnection.Open();

            SqlCommand thisCommand1 = ThisConnection.CreateCommand();
            //textBox2.Clear();
            thisCommand1.CommandText = @"select qty from test2 where id=@id";
            thisCommand1.Parameters.AddWithValue("@id", textBox7.Text);
            SqlDataReader thisReader1 = thisCommand1.ExecuteReader();
            while (thisReader1.Read())
            {

                textBox2.Text += thisReader1["qty"].ToString();
            }
            thisReader1.Close();

            SqlCommand thisCommand2 = ThisConnection.CreateCommand();
            thisCommand2.CommandText = @"select price from test2 where id=@id";
            thisCommand2.Parameters.AddWithValue("@id", textBox7.Text);
            SqlDataReader thisReader2 = thisCommand2.ExecuteReader();
            while (thisReader2.Read())
            {
                textBox3.Text += thisReader2["price"].ToString();
            }
            thisReader2.Close();

            SqlCommand thisCommand3 = ThisConnection.CreateCommand();
            thisCommand3.CommandText = @"select descr from test2 where id=@id";
            thisCommand3.Parameters.AddWithValue("@id", textBox7.Text);
            SqlDataReader thisReader3 = thisCommand3.ExecuteReader();
            while (thisReader3.Read())
            {
                textBox4.Text += thisReader3["descr"].ToString();
            }
            thisReader3.Close();
        }

    }
}
