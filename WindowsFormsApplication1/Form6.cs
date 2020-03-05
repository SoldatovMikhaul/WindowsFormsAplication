using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "NorthwindDataSet1.test1". При необходимости она может быть перемещена или удалена.
            this.test1TableAdapter.Fill(this.NorthwindDataSet1.test1);

            this.reportViewer1.RefreshReport();
        }
    }
}
