using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДЗ_25._04._2023_Взаимодействие_с_эл.управления
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Заполнение информации"; // название окна
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100); // где будет появляться окно
            this.Width = 400;   // ширина окна
            this.Height = 480;

        }

        
    }
}
