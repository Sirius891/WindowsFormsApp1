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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void водителиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.водителиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.пропускаDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Водители". При необходимости она может быть перемещена или удалена.
            this.водителиTableAdapter.Fill(this.пропускаDataSet.Водители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Водители". При необходимости она может быть перемещена или удалена.
            this.водителиTableAdapter.Fill(this.пропускаDataSet.Водители);

        }

        private void организацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form7>(this);
        }

        private void складыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form8>(this);
        }

        private void машиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form9>(this);
        }

        private void отделыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form10>(this);
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form11>(this);
        }

        private void вернутсяНазадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form3>(this);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form2>(this);
        }

        private void водитеоиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form6>(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form4>(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.водителиBindingSource.EndEdit();
            this.водителиTableAdapter.Update(this.пропускаDataSet.Водители);
        }
    }
}
