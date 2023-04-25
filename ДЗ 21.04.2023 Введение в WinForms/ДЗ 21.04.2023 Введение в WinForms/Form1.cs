using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Вывести на экран свое (краткое!!!) резюме с помощью последова-
//тельности MessageBox’ов (числом не менее трех). Причем на заголовке
//последнего должно отобразиться среднее число символов на странице
//(общее количество символов в резюме / количество MessageBox’ов).
namespace ДЗ_21._04._2023_Введение_в_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<string> resume = new List<string>()
            {
                "Бойко Анна Борисовна",
                "Дата рождения: 03.02.1995",
                "Место рождения: Украина, г.Одесса",
                "Образование: ЮНПУ имени К.Д. Ушинского",
                "Профессия: учитель украинского языка и литературы"
            };

            int symb = 0;
            int box = resume.Count;

            foreach (string item in resume)
            {
                symb += item.Length;
                
            }
            MessageBox.Show(resume.Count.ToString());
            MessageBox.Show(symb.ToString());
            MessageBox.Show("Hello", " Message window");
        }
    }
}
