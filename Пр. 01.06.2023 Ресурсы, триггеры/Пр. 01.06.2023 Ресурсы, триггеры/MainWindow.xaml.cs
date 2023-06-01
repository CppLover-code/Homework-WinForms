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

namespace Пр._01._06._2023_Ресурсы__триггеры
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // определение объекта-ресурса
            LinearGradientBrush gradientBrush = new LinearGradientBrush();
            gradientBrush.GradientStops.Add(new GradientStop(Colors.GreenYellow, 0));
            gradientBrush.GradientStops.Add(new GradientStop(Colors.White, 1));

            LinearGradientBrush gradientBrush_2 = new LinearGradientBrush();
            gradientBrush_2.GradientStops.Add(new GradientStop(Colors.Violet, 0));
            gradientBrush_2.GradientStops.Add(new GradientStop(Colors.White, 1));

            // добавление ресурса в словарь ресурсов окна
            this.Resources.Add("buttonGradientBrush", gradientBrush);
            this.Resources.Add("GridGradientBrush", gradientBrush_2);

            // установка ресурса у кнопки
            button1.Background = (Brush)this.Resources["buttonGradientBrush"];
            MyGrid.Background = (Brush)this.Resources["GridGradientBrush"];
        }
    }
}
/*
С помощью свойства Add() объект кисти и его произвольный ключ добавляются в словарь. Далее с помощью метода TryFindResource() мы пытаемся найти ресурс в словаре и установить его в качестве фона. Причем, так как этот метод возвращает object, необходимо выполнить приведение типов.

Всего у ResourceDictionary можно выделить следующие методы и свойства:

Метод Add(string key, object resource) добавляет объект с ключом key в словарь, причем в словарь можно добавить любой объект, главное ему сопоставить ключ

Метод Remove(string key) удаляет из словаря ресурс с ключом key

Свойство Uri устанавливает источник словаря

Свойство Keys возвращает все имеющиеся в словаре ключи

Свойство Values возвращает все имеющиеся в словаре объекты
*/
