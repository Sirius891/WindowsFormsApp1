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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void временные_пропуски_ВодителиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.временные_пропуски_ВодителиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.пропускаDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.пропускаDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Организации". При необходимости она может быть перемещена или удалена.
            this.организацииTableAdapter.Fill(this.пропускаDataSet.Организации);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Водители". При необходимости она может быть перемещена или удалена.
            this.водителиTableAdapter.Fill(this.пропускаDataSet.Водители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Временные_пропуски_Водители". При необходимости она может быть перемещена или удалена.
            this.временные_пропуски_ВодителиTableAdapter.Fill(this.пропускаDataSet.Временные_пропуски_Водители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            //this.сотрудникиTableAdapter.Fill(this.пропускаDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Склады". При необходимости она может быть перемещена или удалена.
            this.складыTableAdapter.Fill(this.пропускаDataSet.Склады);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Машины". При необходимости она может быть перемещена или удалена.
            this.машиныTableAdapter.Fill(this.пропускаDataSet.Машины);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Организации". При необходимости она может быть перемещена или удалена.
            this.организацииTableAdapter.Fill(this.пропускаDataSet.Организации);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Водители". При необходимости она может быть перемещена или удалена.
            this.водителиTableAdapter.Fill(this.пропускаDataSet.Водители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Временные_пропуски_Водители". При необходимости она может быть перемещена или удалена.
            this.временные_пропуски_ВодителиTableAdapter.Fill(this.пропускаDataSet.Временные_пропуски_Водители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Водители". При необходимости она может быть перемещена или удалена.
            this.водителиTableAdapter.Fill(this.пропускаDataSet.Водители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Временные_пропуски_Водители". При необходимости она может быть перемещена или удалена.
            this.временные_пропуски_ВодителиTableAdapter.Fill(this.пропускаDataSet.Временные_пропуски_Водители);

            // Устанавливаем формат DateTimePicker на время
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            // Устанавливаем пользовательский формат времени без секунд
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";

            
            // Устанавливаем формат DateTimePicker на дату и время
            dateTimePicker2.Format = DateTimePickerFormat.Custom;

            // Устанавливаем пользовательский формат времени без секунд
            dateTimePicker2.CustomFormat = "dd.MM.yyyy HH:mm";

           

            код_сотрудникаTextBox.Text = Program.FIO1;
            textBox2.Text = Program.KOD1;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;

            if (date1.Date != date2.Date)
            {
                MessageBox.Show("Установите корректную дату в пределах дня", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Прерываем выполнение кода
            }

            this.Validate();
            this.временные_пропуски_ВодителиBindingSource.EndEdit();
            this.временные_пропуски_ВодителиTableAdapter.Update(this.пропускаDataSet.Временные_пропуски_Водители);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.временные_пропуски_ВодителиTableAdapter.Update(this.пропускаDataSet.Временные_пропуски_Водители);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form2>(this);
        }

        private void временные_пропуски_ВодителиBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.временные_пропуски_ВодителиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.пропускаDataSet);

        }

        private void машиныToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void запросыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            // Проставляем только дату из dateTimePicker2, сохраняя время из dateTimePicker1
            dateTimePicker1.Value = new DateTime(
                dateTimePicker2.Value.Year,
                dateTimePicker2.Value.Month,
                dateTimePicker2.Value.Day,
                dateTimePicker1.Value.Hour,
                dateTimePicker1.Value.Minute,
                0 // Обнуляем секунды
            );
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            код_сотрудникаTextBox.Text = Program.FIO1;
            textBox2.Text = Program.KOD1;
            

        }

        private void водителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form6>(this);
        }

        private void организацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form7>(this);
        }

        private void машиныToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form9>(this);
        }

        private void comboBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ктоСейчасНаходитсяНаПредприятииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form14>(this);
        }

        private void ктоВоСколькоПриезжалВТеченииДняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form13>(this);
        }

        private void рейтингОрганизацийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form18>(this);
        }

        private void рейтингВодителейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form19>(this);
        }
    }
}
