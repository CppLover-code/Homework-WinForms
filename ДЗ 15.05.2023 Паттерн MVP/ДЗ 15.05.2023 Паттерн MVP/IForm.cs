using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_09._05._2023_Меню
{
    internal interface IForm
    {
        string TextInTextBox { get; set; }

        event EventHandler OpenFile; // события
        event EventHandler CreateNew; 
        event EventHandler Save;

    }
}
