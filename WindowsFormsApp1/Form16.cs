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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();

        }

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Отделы". При необходимости она может быть перемещена или удалена.
            this.отделыTableAdapter.Fill(this.пропускаDataSet.Отделы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.пропускаDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.DataTable2". При необходимости она может быть перемещена или удалена.
            this.dataTable2TableAdapter.Fill(this.пропускаDataSet.DataTable2);

            // Устанавливаем формат DateTimePicker на время
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            // Устанавливаем пользовательский формат времени без секунд
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";

            // Устанавливаем формат DateTimePicker на время
            dateTimePicker2.Format = DateTimePickerFormat.Custom;

            // Устанавливаем пользовательский формат времени без секунд
            dateTimePicker2.CustomFormat = "dd.MM.yyyy HH:mm";

            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "dd.MM.yyyy HH:mm";

            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "dd.MM.yyyy HH:mm";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            // Устанавливаем фильтр для BindingSource с использованием временного диапазона
            dataTable2BindingSource.Filter = $"Дата_выдачи_пропуска >= #{startDate.ToString("MM/dd/yyyy")}# AND Время_выхода <= #{endDate.ToString("MM/dd/yyyy")}#";

            // Обновляем отображение данных в DataGridView
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string KlientName = comboBox1.Text.Trim();

            if (!string.IsNullOrEmpty(KlientName))
            {
                string filter = $"[ФИО_клиента] LIKE '%{KlientName}%'";
                dataTable2BindingSource.Filter = filter;
                dataGridView1.Refresh();
            }
            else
            {
                dataTable2BindingSource.RemoveFilter();
                dataGridView1.Refresh();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string selectedWarehouse = comboBox2.Text.Trim();

            if (!string.IsNullOrEmpty(selectedWarehouse))
            {
                DateTime startDate = dateTimePicker3.Value;
                DateTime endDate = dateTimePicker4.Value;

                // Устанавливаем фильтр для BindingSource с использованием временного диапазона и выбранного склада
                string filter = $"[Время_выхода] >= #{startDate.ToString("MM/dd/yyyy HH:mm")}# AND [Время_выхода] <= #{endDate.ToString("MM/dd/yyyy HH:mm")}# AND [Наименование_отдела] = '{selectedWarehouse}'";

                dataTable2BindingSource.Filter = filter;

                // Обновляем отображение данных в DataGridView
                dataGridView1.Refresh();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form5>(this);
        }
    }
}
