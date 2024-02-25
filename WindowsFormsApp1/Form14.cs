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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Водители_на_территории". При необходимости она может быть перемещена или удалена.
            this.водители_на_территорииTableAdapter.Fill(this.пропускаDataSet.Водители_на_территории);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form4>(this);
        }
    }
}
