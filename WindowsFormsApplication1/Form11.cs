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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "NorthwindDataSet17.usr_proc2". При необходимости она может быть перемещена или удалена.
            //this.usr_proc2TableAdapter.Fill(this.NorthwindDataSet17.usr_proc2);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            SqlConnection ThisConnection = new SqlConnection("Data Source=МИША-ПК\\SQLEXPRESS;Initial Catalog=MyDatabase;Persist Security Info=True;User ID=testSQL;Password=testSQL");
            ThisConnection.Open();
            SqlCommand thisCommand = ThisConnection.CreateCommand();
            ReportParameter dat1 = new ReportParameter("dat1", dateTimePicker1.Value.ToString("dd.MM.yyyy HH:mm"));
            ReportParameter dat2 = new ReportParameter("dat2", dateTimePicker2.Value.ToString("dd.MM.yyyy HH:mm"));
            ReportParameter postavshik = new ReportParameter("postavshik", textBox1.Text);

            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { dat1, dat2, postavshik });
            this.usr_proc2TableAdapter.Fill(this.NorthwindDataSet17.usr_proc2, dateTimePicker1.Value, dateTimePicker2.Value, textBox1.Text);
            this.reportViewer1.RefreshReport();

            //this.usr_proc123TableAdapter1.Fill(this.northwindDataSet17.usr_proc2, dateTimePicker1.Value, dateTimePicker2.Value, textBox1.Text);
        }
    }
}
