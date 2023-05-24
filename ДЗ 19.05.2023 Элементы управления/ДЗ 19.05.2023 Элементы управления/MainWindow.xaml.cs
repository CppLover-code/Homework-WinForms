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
        private double a98 = 43;
        private double a95 = 45;
        private double dayTotal = 0;

        private DispatcherTimer? timer = null;
        int flag = 0;
        public MainWindow()
        {
            InitializeComponent();
            timerStart();
            cbGas.SelectedIndex = 0;
            rbCountGas.IsChecked = true;
            //tblCafePayment.Text = PaymentCafe().ToString("N2");
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
  
        private void cbGas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbGas.SelectedIndex == 0)
            {
                tbPriceGas.Text = a98.ToString();
            }
            else if (cbGas.SelectedIndex == 1)
            {
                tbPriceGas.Text = a95.ToString();
            }
            tbPaymentGas.Text = PaymentGas().ToString("N2");
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton rbCountGas)
            {
                tbCountGas.IsReadOnly = false;
                tbSumGas.IsReadOnly = true;
                tbCountGas.Text = 10.ToString("N2");
                tbSumGas.Text = string.Empty;
            }
            else if (sender is RadioButton rbSumGas)
            {
                tbCountGas.IsReadOnly = true;
                tbSumGas.IsReadOnly = false;
                tbSumGas.Text = 100.ToString("N2");
                tbCountGas.Text = string.Empty;
            }
        }

        private double PaymentGas()
        {
            double toPaymentGas = 0;

            if (rbCountGas.IsChecked == true)
            {
                toPaymentGas = double.Parse(tbCountGas.Text) * double.Parse(tbPriceGas.Text);
            }
            else if (rbSumGas.IsChecked == true)
            {
                toPaymentGas = double.Parse(tbSumGas.Text);
                /// изменение кол-ва литров, если пользователь выбрал сумму
                tbCountGas.Text = (toPaymentGas / double.Parse(tbPriceGas.Text)).ToString("N2");
            }
            return toPaymentGas;
        }

        
    }
}
