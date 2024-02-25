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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ПропускаDataSet.Посещаимость_отделов". При необходимости она может быть перемещена или удалена.
            this.Посещаимость_отделовTableAdapter.Fill(this.ПропускаDataSet.Посещаимость_отделов);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form5>(this);
        }
    }
}
