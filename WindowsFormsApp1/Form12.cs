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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.пропускаDataSet);

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Регистрация". При необходимости она может быть перемещена или удалена.
            this.регистрацияTableAdapter.Fill(this.пропускаDataSet.Регистрация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.пропускаDataSet.Сотрудники);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.сотрудникиTableAdapter.Update(this.пропускаDataSet.Сотрудники);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.сотрудникиTableAdapter.Update(this.пропускаDataSet.Сотрудники);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form3>(this);
        }
    }
}
