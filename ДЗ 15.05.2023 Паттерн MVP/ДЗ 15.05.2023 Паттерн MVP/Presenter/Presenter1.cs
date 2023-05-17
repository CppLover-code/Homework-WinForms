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

            // подписки на события
            formView.OpenFile += new EventHandler(formView_OpenFile);
            formView.CreateNew += new EventHandler(formView_CreateNew);
            formView.Save += new EventHandler(formView_Save);
            formView.Copy += new EventHandler(formView_Copy);
            formView.Paste += new EventHandler(formView_Paste);
            formView.Cut += new EventHandler(formView_Cut);
            formView.SelectAll += new EventHandler(formView_SelectAll);
            formView.BackgrColor += new EventHandler(formView_BackgrColor);
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
        private void formView_Save(object sender, EventArgs e)
        {
            Model model = new Model();

            // передача из вида в модель
            model.Content = formView.TextInTextBox;

            // передача из модели в вид
            formView.TextInTextBox = model.Save();
        }
        private void formView_Copy(object sender, EventArgs e)
        {
            Model model = new Model();
            model.Content = formView.TextInTextBox;
            formView.TextInTextBox = model.Copy();
        }
        private void formView_Paste(object sender, EventArgs e)
        {
            Model model = new Model();
            model.Content = formView.TextInTextBox;
            formView.TextInTextBox = model.Paste();
        }
        private void formView_Cut(object sender, EventArgs e)
        {
            Model model = new Model();
            model.Content = formView.TextInTextBox;
            formView.TextInTextBox = model.Cut();
        }
        private void formView_SelectAll(object sender, EventArgs e)
        {
            Model model = new Model();
            model.Content = formView.TextInTextBox;
            formView.TextInTextBox = model.SelectAll();
        }
        private void formView_BackgrColor(object sender, EventArgs e)
        {
            Model model = new Model();
            model.Content = formView.TextInTextBox;
            formView.TextInTextBox = model.BackgrColor();
        }


    }
}
