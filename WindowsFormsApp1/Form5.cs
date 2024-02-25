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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void пропуски_клиентовBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пропуски_клиентовBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.пропускаDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Отделы". При необходимости она может быть перемещена или удалена.
            this.отделыTableAdapter.Fill(this.пропускаDataSet.Отделы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.пропускаDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Пропуски_клиентов". При необходимости она может быть перемещена или удалена.
            this.пропуски_клиентовTableAdapter.Fill(this.пропускаDataSet.Пропуски_клиентов);
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Отделы". При необходимости она может быть перемещена или удалена.
            this.отделыTableAdapter.Fill(this.пропускаDataSet.Отделы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.пропускаDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Пропуски_клиентов". При необходимости она может быть перемещена или удалена.
            this.пропуски_клиентовTableAdapter.Fill(this.пропускаDataSet.Пропуски_клиентов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Пропуски_клиентов". При необходимости она может быть перемещена или удалена.
            this.пропуски_клиентовTableAdapter.Fill(this.пропускаDataSet.Пропуски_клиентов);
            // Устанавливаем формат DateTimePicker на время
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            // Устанавливаем пользовательский формат времени без секунд
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
           
            // Устанавливаем формат DateTimePicker на дату и время
            dateTimePicker2.Format = DateTimePickerFormat.Custom;

            // Устанавливаем пользовательский формат времени без секунд
            dateTimePicker2.CustomFormat = "dd.MM.yyyy HH:mm";

            код_сотрудникаTextBox.Text = Program.FIO2;
            textBox1.Text = Program.KOD2;
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
            this.пропуски_клиентовBindingSource.EndEdit();
            this.пропуски_клиентовTableAdapter.Update(this.пропускаDataSet.Пропуски_клиентов);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form2>(this);
        }

        private void пропуски_клиентовBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.пропуски_клиентовBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.пропускаDataSet);

        }

        private void пропуски_клиентовBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.пропуски_клиентовBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.пропускаDataSet);

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

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            код_сотрудникаTextBox.Text = Program.FIO2;
            textBox1.Text = Program.KOD2;
        }

       

        private void клиентыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form11>(this);
        }

        private void справочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ктоСейчасНаходитсяНаТерриториюИзКлиентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form15>(this);
        }

        private void универсальныйЗапросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form16>(this);
        }

        private void рейтингОтделовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form17>(this);
        }
    }
}
