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
            
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            int d = 0;  //Добавить и все ОК!
            if (textBox3.Text != null)
            d = int.Parse(textBox3.Text);

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet3.test2". При необходимости она может быть перемещена или удалена.
            this.test2TableAdapter1.Fill(this.northwindDataSet3.test2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet1.test1". При необходимости она может быть перемещена или удалена.
            this.test1TableAdapter.Fill(this.northwindDataSet1.test1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet4.test2". При необходимости она может быть перемещена или удалена.
            this.test2TableAdapter.FillBy(this.northwindDataSet4.test2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet8.tabletest1". При необходимости она может быть перемещена или удалена.
            this.tabletest1TableAdapter.Fill(this.northwindDataSet8.tabletest1);

            //this.test2TableAdapter.Fill(this.northwindDataSet4.test2);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("Data Source=МИША-ПК\\SQLEXPRESS;Initial Catalog=MyDatabase;User ID=testSQl;Password=testSQL");
            string sql = "INSERT test1 (number, dat, postavshik, naimenovnie) VALUES (@number, @dat, @postavshik, @naimenovnie)";
            SqlCommand cmd_SQL = new SqlCommand(sql, connect);

            cmd_SQL.Parameters.AddWithValue("@number", textBox1.Text);
            cmd_SQL.Parameters.AddWithValue("@dat", textBox2.Text);
            cmd_SQL.Parameters.AddWithValue("@postavshik", textBox3.Text);
            cmd_SQL.Parameters.AddWithValue("@naimenovnie", textBox4.Text);
            try
            {
                connect.Open();
                int n = cmd_SQL.ExecuteNonQuery();
                textBox1.Text += String.Format("Добавлено {0} записей", n);
               // MessageBox.Show("Добавлено {0} записей")
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
            Close();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            using (SqlConnection cn = new SqlConnection("Data Source=МИША-ПК\\SQLEXPRESS;Initial Catalog=MyDatabase;Persist Security Info=True;User ID=testSQL;Password=testSQL")) // юзинг для того, чтобы подключение в случае проблемы закрылось. тут создается подключение. ключевая строка - это строка подключения, главное тут - провайдер. провайдер - это ключевая разница в подключениях
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();//если соединение закрыто - октрыть
                }
                SqlDataAdapter adapter = new SqlDataAdapter(); //создаем адаптер для связи с данными. 
                adapter.SelectCommand = new SqlCommand("select * from test2 where id=2", cn); // указываем ему команду для выборки
                DataSet ds = new DataSet();
                //Console.WriteLine(adapter.Fill(ds));//заполняем датасет с помощьб адаптера (будет исполнена команда на выборку)

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("Первое действие");
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("Второе действие");
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("Третье действие");
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("Четвертое действие");
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("Пятое действие");
        }
    }
}
          
        

    

