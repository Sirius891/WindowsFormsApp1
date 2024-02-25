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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet1.Склады". При необходимости она может быть перемещена или удалена.
            this.складыTableAdapter.Fill(this.пропускаDataSet1.Склады);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet1.Водители". При необходимости она может быть перемещена или удалена.
            this.водителиTableAdapter.Fill(this.пропускаDataSet1.Водители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ПропускаDataSet.Пропуски_клиентов". При необходимости она может быть перемещена или удалена.
            this.пропуски_клиентовTableAdapter.Fill(this.ПропускаDataSet.Пропуски_клиентов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ПропускаDataSet.DataTable1". При необходимости она может быть перемещена или удалена.
            this.DataTable1TableAdapter.Fill(this.ПропускаDataSet.DataTable1);

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
            DataTable1BindingSource.Filter = $"Дата_выдачи_пропуска >= #{startDate.ToString("MM/dd/yyyy")}# AND Время_отбытия <= #{endDate.ToString("MM/dd/yyyy")}#";

            // Обновляем отображение данных в DataGridView
            dataGridView1.Refresh();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string driverName = comboBox1.Text.Trim();

            // Устанавливаем фильтр для BindingSource с использованием ФИО водителя
            if (!string.IsNullOrEmpty(driverName))
            {
                string filter = $"[ФИО_водителя] LIKE '%{driverName}%'";
                DataTable1BindingSource.Filter = filter;

                // Обновляем отображение данных в DataGridView
                dataGridView1.Refresh();
            }
            else
            {
                // Если поле с ФИО водителя пусто, сбрасываем фильтр
                DataTable1BindingSource.RemoveFilter();

                // Обновляем отображение данных в DataGridView
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
                string filter = $"[Время_отбытия] >= #{startDate.ToString("MM/dd/yyyy HH:mm")}# AND [Время_отбытия] <= #{endDate.ToString("MM/dd/yyyy HH:mm")}# AND [Наименование_склада] = '{selectedWarehouse}'";

                DataTable1BindingSource.Filter = filter;

                // Обновляем отображение данных в DataGridView
                dataGridView1.Refresh();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form4>(this);
        }
    }
}
