using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ПропускаDataSet.Количество_доставок_товаров". При необходимости она может быть перемещена или удалена.
            this.Количество_доставок_товаровTableAdapter.Fill(this.ПропускаDataSet.Количество_доставок_товаров);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form4>(this);
        }
    }
}
