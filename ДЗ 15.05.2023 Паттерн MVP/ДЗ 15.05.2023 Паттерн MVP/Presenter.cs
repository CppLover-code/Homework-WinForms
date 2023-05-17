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
        }
        private void formView_OpenFile(object sender, EventArgs e) // 
        {
            Model model = new Model();
            formView.TextInTextBox = model.OpenFile().ToString();
        }

    }
}
