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
    public partial class Form10 : Form
    {
        public static string a;
        public static string b;
        public static string c;
        public static string d;
        public static DateTime f;
        public static DateTime f2;
        public Form10()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet16.usr_proc123". При необходимости она может быть перемещена или удалена.
           /**/  //this.usr_proc123TableAdapter.Fill(this.northwindDataSet16.usr_proc123);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet16.usr_proc123". При необходимости она может быть перемещена или удалена.
            //this.usr_proc123TableAdapter.Fill(this.northwindDataSet16.usr_proc123);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet16.usr_proc123". При необходимости она может быть перемещена или удалена.
            //this.usr_proc123TableAdapter.Fill(this.northwindDataSet16.usr_proc123);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet15.usr_proc123". При необходимости она может быть перемещена или удалена.
            //this.usr_proc123TableAdapter.Fill(this.northwindDataSet15.usr_proc123);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet15.usr_proc123". При необходимости она может быть перемещена или удалена.
            this.usr_proc123TableAdapter1.Fill(this.northwindDataSet16.usr_proc123, dateTimePicker1.Value, dateTimePicker2.Value );

            this.reportViewer1.RefreshReport();

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection ThisConnection = new SqlConnection("Data Source=МИША-ПК\\SQLEXPRESS;Initial Catalog=MyDatabase;Persist Security Info=True;User ID=testSQL;Password=testSQL");
            ThisConnection.Open();
            SqlCommand thisCommand = ThisConnection.CreateCommand();

            ReportParameter dat1 = new ReportParameter("dat1", dateTimePicker1.Value.ToString("dd.MM.yyyy HH:mm"));
            ReportParameter dat2 = new ReportParameter("dat2", dateTimePicker2.Value.ToString("dd.MM.yyyy HH:mm"));
            this.usr_proc123TableAdapter1.Fill(this.northwindDataSet16.usr_proc123, dateTimePicker1.Value, dateTimePicker2.Value);

  
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] {dat1, dat2 });
            this.reportViewer1.RefreshReport();

        }
    }
}
