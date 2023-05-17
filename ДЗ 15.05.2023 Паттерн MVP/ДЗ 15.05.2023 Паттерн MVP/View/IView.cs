using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДЗ_09._05._2023_Меню.View
{
    internal interface IView
    {
        TextBox TextInTextBox { get; set; }

        event EventHandler OpenFile; // события
        event EventHandler CreateNew;
        event EventHandler Save;
        event EventHandler Copy;
    }
}
