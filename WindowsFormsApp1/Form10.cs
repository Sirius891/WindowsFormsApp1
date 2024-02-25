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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void отделыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Отделы". При необходимости она может быть перемещена или удалена.
            this.отделыTableAdapter.Fill(this.пропускаDataSet.Отделы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Отделы". При необходимости она может быть перемещена или удалена.
            this.отделыTableAdapter.Fill(this.пропускаDataSet.Отделы);

        }

        private void водитеоиToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void водителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form6>(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.отделыBindingSource.EndEdit();
            this.отделыTableAdapter.Update(this.пропускаDataSet.Отделы);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form3>(this);
        }
    }
}
