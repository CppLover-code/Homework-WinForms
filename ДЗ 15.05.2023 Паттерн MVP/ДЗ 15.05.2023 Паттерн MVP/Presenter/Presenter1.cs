using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ДЗ_09._05._2023_Меню.Models;
using ДЗ_09._05._2023_Меню.View;

namespace ДЗ_09._05._2023_Меню.Presenter
{
    internal class Presenter1
    {
        IView formView; // переменная типа интерфейса для передачи из формы

        public Presenter1(IView view)
        {
            formView = view;

            formView.OpenFile += new EventHandler(formView_OpenFile); // подписка на событие
            formView.CreateNew += new EventHandler(formView_CreateNew); // подписка на событие
            formView.Save += new EventHandler(formView_Save); // подписка на событие
            formView.Copy += new EventHandler(formView_Copy);
        }
        private void formView_OpenFile(object sender, EventArgs e)
        {
            Model model = new Model();

            // передача из вида в модель
            model.Content = formView.TextInTextBox;

            // передача из модели в вид
            formView.TextInTextBox = model.OpenFile();

        }
        private void formView_CreateNew(object sender, EventArgs e)
        {
            Model model = new Model();

            // передача из вида в модель
            model.Content = formView.TextInTextBox;

            // передача из модели в вид
            formView.TextInTextBox = model.CreateNew();
        }
        private void formView_Save(object sender, EventArgs e) // ???????? надо ли что-то сюда?
        {
            Model model = new Model();

            // передача из вида в модель
            model.Content = formView.TextInTextBox;

            // передача из модели в вид
            formView.TextInTextBox = model.Save();
        }
        private void formView_Copy(object sender, EventArgs e) // 
        {
            Model model = new Model();

            // передача из вида в модель
            model.Content = formView.TextInTextBox;

            // передача из модели в вид
            formView.TextInTextBox = model.Copy();
        }
    }
}
