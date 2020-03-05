using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;


namespace WindowsFormsApplication1
{
    public partial class Form7 : Form
    {
        public static int a;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "NorthwindDataSet1.test1". При необходимости она может быть перемещена или удалена.
            this.test1TableAdapter.Fill(this.NorthwindDataSet1.test1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet11.test2". При необходимости она может быть перемещена или удалена.
            this.test2TableAdapter.Fill(this.northwindDataSet11.test2);

            //this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //a = Int32.Parse(textBox5.Text);

            if (textBox5.Text.Length != 0)
            {
                //a = Int32.Parse(textBox5.Text);

                try
                {
                    this.test2TableAdapter.FillBy(this.northwindDataSet11.test2, ((int)(System.Convert.ChangeType(textBox5.Text, typeof(int)))));
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

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
                ReportParameter Report0 = new ReportParameter("Report0", textBox5.Text);
                ReportParameter Number = new ReportParameter("Number", textBox1.Text);
                ReportParameter naimenovanie = new ReportParameter("naimenovanie", textBox4.Text);
                ReportParameter id = new ReportParameter("id", textBox5.Text);
                ReportParameter dat = new ReportParameter("dat", textBox2.Text);
                ReportParameter postavshik = new ReportParameter("postavshik", textBox3.Text);
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { Report0, Number, naimenovanie, dat, id, postavshik });
                //ReportViewer.Reset(reportViewer1); 
                this.reportViewer1.RefreshReport();

                ThisConnection.Close();
            }
        }

        private void test2BindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test2TableAdapter.Fill(this.northwindDataSet11.test2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
        private void Form7_Shown(object sender, EventArgs e)
        {
            try
            {
                this.test2TableAdapter.FillBy(this.northwindDataSet11.test2, a);
            }
            catch(System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            /*SqlConnection ThisConnection = new SqlConnection("Data Source=МИША-ПК\SQLEXPRESS;Initial Catalog=MyDatabase;Persist Security Info=True;User ID=testSQL;Password=testSQL");
            ThisConnection.Open();*/

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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
    }
}