using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ДЗ_09._05._2023_Меню.Presenter;

namespace ДЗ_09._05._2023_Меню
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form = new Form1();
            Presenter1 presenter = new Presenter1(form);
            Application.Run(form);
        }
    }
}
