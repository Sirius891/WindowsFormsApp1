using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        public static string FIO1;
        public static string KOD1;
        public static string FIO2;
        public static string KOD2;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class FormHelper
    {
        public static void OpenForm<T>(Form currentForm) where T : Form, new()
        {
            T form = new T();
            form.FormClosed += (sender, e) => currentForm.Hide();
            currentForm.Hide();
            form.Show();
        }
    }
    
}
