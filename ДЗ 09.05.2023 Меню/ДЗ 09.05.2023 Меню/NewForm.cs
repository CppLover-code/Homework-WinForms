using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДЗ_09._05._2023_Меню
{
    internal class NewForm:Form1
    {
        Form form1 {get;set; }

        public NewForm(Form1 form)
        {
            this.form1 = form;
        }
    }
}
