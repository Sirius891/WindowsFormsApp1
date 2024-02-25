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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void организацииBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.организацииBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.пропускаDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Организации". При необходимости она может быть перемещена или удалена.
            this.организацииTableAdapter.Fill(this.пропускаDataSet.Организации);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Организации". При необходимости она может быть перемещена или удалена.
            this.организацииTableAdapter.Fill(this.пропускаDataSet.Организации);

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form5>(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.организацииBindingSource.EndEdit();
            this.организацииTableAdapter.Update(this.пропускаDataSet.Организации);
        }
    }
}
