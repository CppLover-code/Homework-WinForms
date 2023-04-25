using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex._3
{
    public partial class Form1 : Form
    {
        bool ctrl;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Mouse Events"; // название окна
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100); // где будет появляться окно
            this.Width = 500;   // ширина окна
            this.Height = 500;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {    
            Form frm = (Form)sender;
            if(e.Button == MouseButtons.Left)
            {
                if (e.X < frm.Width - 100 && e.Y < frm.Height - 100 &&
                    e.X > 100 && e.Y > 100)
                {
                    MessageBox.Show("Точка внутри прямоугольника", "Сообщение");
                }
                else if (e.X == frm.Width - 100 && e.Y == frm.Height - 100 &&
                    e.X == 100 && e.Y == 100)
                {
                    MessageBox.Show("Точка на границе прямоугольника", "Сообщение");
                }               
                else
                {
                    MessageBox.Show("Точка снаружи прямоугольника", "Сообщение");
                }               
            }

            if(e.Button == MouseButtons.Left && ctrl)
            {
                Application.Exit();
            }

            if(e.Button == MouseButtons.Right)
            {
                frm.Text = $"Ширина - {e.X}, Высота - {e.Y}";
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey) ctrl = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey) ctrl = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Form form = (Form)sender;
            form.Text = $"Ширина - {e.X}, Высота - {e.Y}";
        }
    }
}
