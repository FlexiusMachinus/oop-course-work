using System;
using System.Windows.Forms;

namespace OOP_CourseWork
{
    // Главный класс программы
    public static class Program
    {
        // Входная точка программы
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm()); // Запуск формы
        }
    }
}
