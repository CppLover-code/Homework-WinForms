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
    public partial class Resume : Form
    {
        public Resume()
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

            int symb = 0;            // счётчик кол-ва символов
            int box = resume.Count;  // кол-во mes.box
            int count = 1;
            foreach (string item in resume)
            {
                symb += item.Length;

                if(count == resume.Count)
                    MessageBox.Show(item, $"Резюме, символов - {symb}, MessageBox’ов - {box}");
                else
                    MessageBox.Show(item, "Резюме");

                count++;
            }
        }
    }
}
