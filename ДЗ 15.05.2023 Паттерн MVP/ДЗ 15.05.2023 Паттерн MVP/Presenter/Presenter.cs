using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_09._05._2023_Меню
{
    internal class Presenter
    {
        IForm formView; // переменная типа интерфейса для передачи из формы

        public Presenter(IForm view)
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
            formView.TextInTextBox = model.OpenFile().ToString();
        }
        private void formView_CreateNew(object sender, EventArgs e)
        {
            Model model = new Model();
            formView.TextInTextBox = model.CreateNew().ToString();
        }
        private void formView_Save(object sender, EventArgs e) // ???????? надо ли что-то сюда?
        {
            Model model = new Model();
            //formView.TextInTextBox = model.CreateNew().ToString();
        }
        private void formView_Copy(object sender, EventArgs e) // 
        {
            Model model = new Model();
            formView.TextInTextBox = model.Copy().ToString();
        }

    }
}
