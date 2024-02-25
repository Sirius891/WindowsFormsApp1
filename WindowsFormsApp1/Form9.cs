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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void машиныBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.машиныBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.пропускаDataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Машины". При необходимости она может быть перемещена или удалена.
            this.машиныTableAdapter.Fill(this.пропускаDataSet.Машины);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Машины". При необходимости она может быть перемещена или удалена.
            this.машиныTableAdapter.Fill(this.пропускаDataSet.Машины);

        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.машиныBindingSource.EndEdit();
            this.машиныTableAdapter.Update(this.пропускаDataSet.Машины);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.машиныTableAdapter.Update(this.пропускаDataSet.Машины);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form4>(this);
        }
    }
}
