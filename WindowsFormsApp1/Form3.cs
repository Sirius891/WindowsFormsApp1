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
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\Пропуска.mdb");
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Регистрация". При необходимости она может быть перемещена или удалена.
            this.регистрацияTableAdapter.Fill(this.пропускаDataSet.Регистрация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пропускаDataSet.Регистрация". При необходимости она может быть перемещена или удалена.
            this.регистрацияTableAdapter.Fill(this.пропускаDataSet.Регистрация);

            FillComboBox2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(логинTextBox.Text))
            {
                MessageBox.Show("Ошибка: Заполните поле логин ");
                return;
            }
            else if (string.IsNullOrWhiteSpace(парольTextBox.Text))
            {
                MessageBox.Show("Ошибка: Заполните поле пароль");
                return;
            }
            else if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Ошибка: Выберите роль");
                return;

            }

            string con = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = |DataDirectory|/Пропуска.mdb";
            OleDbConnection empCon = new OleDbConnection(con);

            try
            {
                // Проверка на специальные символы в textBox1 (логин)
                string loginPattern = @"[!@#$%^&*()_+{}\[\]:;<>,.?~\\]";
                Regex loginRegex = new Regex(loginPattern);

                if (loginRegex.IsMatch(логинTextBox.Text))
                {
                    // Если в логине найдены специальные символы, выдаем ошибку
                    MessageBox.Show("Нельзя использовать специальные символы в логине!");
                }
                else
                {
                    // Проверяем, существует ли логин уже в базе данных
                    string checkLoginQuery = "SELECT COUNT(*) FROM Регистрация WHERE Логин = @login";
                    OleDbCommand checkLoginCommand = new OleDbCommand(checkLoginQuery, empCon);
                    checkLoginCommand.Parameters.Add("@login", OleDbType.VarChar).Value = логинTextBox.Text;
                    empCon.Open();
                    int existingCount = (int)checkLoginCommand.ExecuteScalar();

                    if (existingCount > 0)
                    {
                        // Если логин уже существует, выдаем ошибку
                        MessageBox.Show("Пользователь с таким логином уже существует!");
                    }
                    else
                    {
                        // Если специальные символы не найдены и логин уникален, выполняем вставку данных в базу данных
                        string newinsert = "INSERT INTO Регистрация"
                            + "(Логин, Пароль, Роль) "
                            + "Values (@login,@pass,@role)";
                        OleDbCommand insertCommand = new OleDbCommand(newinsert, empCon);
                        insertCommand.Parameters.Add("@login", OleDbType.VarChar).Value = логинTextBox.Text;
                        insertCommand.Parameters.Add("@pass", OleDbType.VarChar).Value = парольTextBox.Text;

                        // Получаем выбранную роль из comboBox2
                        string selectedRole = comboBox1.SelectedItem.ToString();
                        insertCommand.Parameters.Add("@role", OleDbType.VarChar).Value = selectedRole;

                        int count = insertCommand.ExecuteNonQuery();
                        MessageBox.Show("Регистрация успешна!");

                    }

                }
            }
            catch (OleDbException ex)
            {
                // Обработка ошибки базы данных, если она возникнет
                MessageBox.Show(ex.Message);
            }
            finally
            {
                empCon.Close();
                FillDataGridView();
                FillComboBox2();
            }
        }
        private void FillDataGridView()
        {
            con.Open();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT * FROM Регистрация", con);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;
        }

        private void FillComboBox2()
        {
            con.Open();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT Логин FROM Регистрация", con);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            con.Close();

            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "Логин";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            string selectedLogin = comboBox2.Text;
            if (!string.IsNullOrEmpty(selectedLogin))
            {
                con.Open();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT Пароль, Роль FROM Регистрация WHERE Логин = '" + selectedLogin + "'", con);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                con.Close();

                if (dt.Rows.Count > 0)
                {
                    textBox4.Text = dt.Rows[0]["Пароль"].ToString();
                    textBox6.Text = dt.Rows[0]["Роль"].ToString();
                }
                else
                {
                    textBox4.Text = "";
                    textBox6.Text = "";
                }
            }
            else
            {
                textBox4.Text = "";
                textBox6.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newLogin = textBox3.Text;

            // Проверка на специальные символы
            string loginPattern = @"[!@#$%^&*()_+{}\[\]:;<>,.?~\\]";
            Regex loginRegex = new Regex(loginPattern);

            if (loginRegex.IsMatch(newLogin))
            {
                // Если в логине найдены специальные символы, выдаем ошибку
                MessageBox.Show("Нельзя использовать специальные символы в логине!");
                return;
            }

            // Проверяем, существует ли логин уже в базе данных
            string checkLoginQuery = "SELECT COUNT(*) FROM Регистрация WHERE Логин = @login";
            OleDbCommand checkLoginCommand = new OleDbCommand(checkLoginQuery, con);
            checkLoginCommand.Parameters.Add("@login", OleDbType.VarChar).Value = newLogin;

            try
            {
                string selectedLogin = comboBox2.Text;
                if (string.IsNullOrEmpty(newLogin))
                {
                    MessageBox.Show("Пожалуйста, заполните поле новый логин.");
                    return;
                }
                con.Open();
                int existingCount = (int)checkLoginCommand.ExecuteScalar();
                if (existingCount > 0)
                {
                    // Если логин уже существует, выдаем ошибку
                    MessageBox.Show("Пользователь с таким логином уже существует!");
                }
                else
                {
                    // Обновляем логин в базе данных
                    string updateQuery = "UPDATE Регистрация SET Логин = @newLogin WHERE Логин = @selectedLogin";
                    OleDbCommand updateCommand = new OleDbCommand(updateQuery, con);
                    updateCommand.Parameters.Add("@newLogin", OleDbType.VarChar).Value = newLogin;
                    updateCommand.Parameters.Add("@selectedLogin", OleDbType.VarChar).Value = selectedLogin;
                    updateCommand.ExecuteNonQuery();

                    MessageBox.Show("Логин успешно обновлен.");
                }
            }
            finally
            {
                con.Close();
                FillDataGridView();
                FillComboBox2();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string newPassword = textBox5.Text;
            string selectedLogin = comboBox2.Text;

            try
            {
                if (string.IsNullOrEmpty(newPassword))
                {
                    MessageBox.Show("Пожалуйста, заполните поле новый пароль.");
                    return;
                }
                con.Open();

                // Обновляем пароль в базе данных
                string updatePasswordQuery = "UPDATE Регистрация SET Пароль = @newPassword WHERE Логин = @selectedLogin";
                OleDbCommand updatePasswordCommand = new OleDbCommand(updatePasswordQuery, con);
                updatePasswordCommand.Parameters.Add("@newPassword", OleDbType.VarChar).Value = newPassword;
                updatePasswordCommand.Parameters.Add("@selectedLogin", OleDbType.VarChar).Value = selectedLogin;
                updatePasswordCommand.ExecuteNonQuery();

                MessageBox.Show("Пароль успешно обновлен.");

            }
            finally
            {
                con.Close();
                FillDataGridView();
                FillComboBox2();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string newRole = comboBox3.Text;
            string selectedLogin = comboBox2.Text;

            try
            {
                if (string.IsNullOrEmpty(newRole))
                {
                    MessageBox.Show("Пожалуйста, выберите новую Роль.");
                    return;
                }
                con.Open();

                // Обновляем роль в базе данных
                string updateRoleQuery = "UPDATE Регистрация SET Роль = @newRole WHERE Логин = @selectedLogin";
                OleDbCommand updateRoleCommand = new OleDbCommand(updateRoleQuery, con);
                updateRoleCommand.Parameters.Add("@newRole", OleDbType.VarChar).Value = newRole;
                updateRoleCommand.Parameters.Add("@selectedLogin", OleDbType.VarChar).Value = selectedLogin;
                updateRoleCommand.ExecuteNonQuery();

                MessageBox.Show("Роль успешно обновлена.");
            }
            finally
            {
                con.Close();
                FillDataGridView();
                FillComboBox2();
            }
        }

        private void водитеоиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form6>(this);
        }

        private void организацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form7>(this);
        }

        private void складыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form8>(this);
        }

        private void машиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form9>(this);
        }

        private void отделыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form10>(this);
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form11>(this);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form2>(this);
        }

        private void сотрудникиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm<Form12>(this);
        }

    }
}
