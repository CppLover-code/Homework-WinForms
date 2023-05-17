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

        // события
        event EventHandler OpenFile;
        event EventHandler CreateNew;
        event EventHandler Save;
        event EventHandler Copy;
        event EventHandler Paste;
        event EventHandler Cut;
        event EventHandler SelectAll;
        event EventHandler BackgrColor;
        event EventHandler FontColor;
        event EventHandler FontSettings;
        event EventHandler FormClose;
    }
}
