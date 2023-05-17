    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace ДЗ_16._05._2023_Введение_в_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            // убираем лишние пробелы между словами
            textBoxInput.Text = System.Text.RegularExpressions.Regex.Replace(textBoxInput.Text, @"\s+", " "); 
            listBoxNames.Items.Add(textBoxInput.Text);
            textBoxInput.Clear();
            buttonClearAll.IsEnabled = true;
        }

        private void buttonClearAll_Click(object sender, RoutedEventArgs e)
        {
            listBoxNames.Items.Clear();
            buttonClearAll.IsEnabled = false;
        }

        private void textBoxInput_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if ((String.IsNullOrEmpty(textBoxInput.Text) ||   
                String.IsNullOrWhiteSpace(textBoxInput.Text)))
            {
                buttonAdd.IsEnabled = false;          
            }
            else buttonAdd.IsEnabled = true;
        }
    }
}
