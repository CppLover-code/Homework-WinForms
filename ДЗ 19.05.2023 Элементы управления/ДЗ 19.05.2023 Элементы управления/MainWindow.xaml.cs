using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ДЗ_19._05._2023_Элементы_управления
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer? timer = null;
        int flag = 0;
        public MainWindow()
        {
            InitializeComponent();
            timerStart();
        }
        private void timerStart()  // запуск таймера
        {
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
            timer.Start();
        }
        private void timerTick(object sender, EventArgs e)  // событие таймера
        {
            flag += 10;
            if (flag % 30 == 0)
            {
                tblStrDT.Text = "Дата:";
                tblDateTime.Text = DateTime.Now.ToLongDateString();
            }
            else
            {
                tblStrDT.Text = "Время:";
                tblDateTime.Text = DateTime.Now.ToLongTimeString();
            }
            tblDayOfWeek.Text = CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek).ToString();
        }


    }
}
