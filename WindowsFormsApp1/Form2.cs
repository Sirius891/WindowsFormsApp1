using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        string FIO;
        string employeeCode;
        public Form2()
        {
            InitializeComponent();

        }


        private string enteredPassword = "";
        

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = enteredPassword;

            if (string.IsNullOrEmpty(login))
            {
                label3.Visible = true;
                MessageBox.Show("Системная ошибка: Введите Логин");
                return; // Прерываем выполнение кода
            }

            if (string.IsNullOrEmpty(password))
            {
                label4.Visible = true;
                MessageBox.Show("Системная ошибка: Введите пароль");
                return; // Прерываем выполнение кода
            }

            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source =|DataDirectory|\Пропуска.mdb");
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT Код_Логина, Логин, Пароль, Роль FROM Регистрация WHERE Логин = '" + login + "' AND Пароль = '" + password + "'", con);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                string role = dt.Rows[0]["Роль"].ToString();
                string loginCode = dt.Rows[0]["Код_Логина"].ToString();
                // Здесь добавляем запрос для получения ФИО из таблицы Сотрудники
                string fioQuery = "SELECT ФИО, Код_сотрудника FROM Сотрудники WHERE Код_Логина = " + loginCode;
                OleDbDataAdapter fioDataAdapter = new OleDbDataAdapter(fioQuery, con);
                DataTable fioDt = new DataTable();
                fioDataAdapter.Fill(fioDt);

                if (fioDt.Rows.Count > 0)
                {
                    FIO = fioDt.Rows[0]["ФИО"].ToString();
                    employeeCode = fioDt.Rows[0]["Код_сотрудника"].ToString();
                    MessageBox.Show("Добро пожаловать, " + FIO + "!");
                }

                if (role == "Администратор")
                {
                    // Если роль "Администратор" и логин/пароль верны
                    FormHelper.OpenForm<Form3>(this);
                }
                else if (role == "Охранник КПП")
                {
                    // Для остальных ролей (Пользователь)
                    
                    Program.FIO1 = FIO;
                    Program.KOD1 = employeeCode;
                    FormHelper.OpenForm<Form4>(this);

                }
                else if (role == "Контролёр")
                {
                    //MessageBox.Show($"Перед передачей значений: FIO2={Program.FIO2}, KOD2={Program.KOD2}");
                   
                    Program.FIO2 = FIO;
                    Program.KOD2 = employeeCode;
                    FormHelper.OpenForm<Form5>(this);
                    //MessageBox.Show($"После передачи значений: FIO2={Program.FIO2}, KOD2={Program.KOD2}");
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }


        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Если пользователь нажал Enter, проверьте введенный пароль.
                // enteredPassword содержит введенные пользователем символы.
                MessageBox.Show("Проверка пароля: " + enteredPassword);
                return;
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                if (enteredPassword.Length > 0)
                {
                    enteredPassword = enteredPassword.Remove(enteredPassword.Length - 1);
                }
            }
            else
            {
                enteredPassword += e.KeyChar;
            }

            string maskedText = new string('*', enteredPassword.Length);
            textBox2.Text = maskedText;
            e.Handled = true;
        }
    }
}
