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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void складыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Склады". При необходимости она может быть перемещена или удалена.
            this.складыTableAdapter.Fill(this.пропускаDataSet.Склады);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Склады". При необходимости она может быть перемещена или удалена.
            this.складыTableAdapter.Fill(this.пропускаDataSet.Склады);

        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.складыBindingSource.EndEdit();
            this.складыTableAdapter.Update(this.пропускаDataSet.Склады);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form3>(this);
        }
    }
}
