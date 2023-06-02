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

namespace ДЗ_30._05._2023_Паттерн_MVC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller controller;
        public MainWindow()
        {
            InitializeComponent();
            controller = new Controller();           
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)                // обработка кнопка Сохранить
        {
            controller.AddPerson(tbName.Text, int.Parse(tbAge.Text)); // передаем контроллеру данные из вида
            btnShow.IsEnabled = true;   
            tbName.Text = string.Empty;
            tbAge.Text = string.Empty;
        }
        void Print()  // для показа обновленного списка людей из базы данных
        {
            lbPersons.Items.Clear();
            foreach (var a in controller.GetAllPerson())
            {
                lbPersons.Items.Add(a);
            }
        }
        private void btnShow_Click(object sender, RoutedEventArgs e)                // обработка кнопка Показать
        {
            Print();
        }
        private void ShowMenuItem_Click(object sender, RoutedEventArgs e)           // обработка Показать выбранный элемент
        {
            try
            {
                var a = lbPersons.SelectedItem;
                MessageBox.Show(a.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Объект не выбран!");
            }
        }
        private void ClearAllMenuItem_Click(object sender, RoutedEventArgs e)       // очистка списка (НЕ УДАЛЕНИЕ!!!!)
        {
            lbPersons.Items.Clear();
        }
        private void DeleteSelectedMenuItem_Click(object sender, RoutedEventArgs e) // удаление выделенного элемента
        {
            try
            {
                var a = lbPersons.SelectedItem;
                controller.Delete((Model.Person)a);
                Print();
            }
            catch (Exception)
            {
                MessageBox.Show("Объект не выбран!");
            }

            if(lbPersons.Items.Count == 0) { btnShow.IsEnabled = false; }
        }       
        private void btnSearch_Click(object sender, RoutedEventArgs e)              // обработка нажатия на кнопку Поиск
        {
            try
            {
                lbPersons.Items.Clear(); // очистка списка

                foreach (var a in controller.SearchP(tbSearch.Text))
                {
                    lbPersons.Items.Add(a);
                }

                if(lbPersons.Items.Count == 0)
                {
                    MessageBox.Show("Данных не найдено!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Данных не найдено!");
            }

            tbSearch.Text = string.Empty;
        }
        private void txtBox_TextChanged(object sender, TextChangedEventArgs e)      // обработка изменения текста в текст боксах Имя и Возраст
        {
            if(tbAge.Text != string.Empty && tbName.Text != string.Empty)
            {
                btnSave.IsEnabled = true;
            }    
            else btnSave.IsEnabled = false;
        }
    }
}
