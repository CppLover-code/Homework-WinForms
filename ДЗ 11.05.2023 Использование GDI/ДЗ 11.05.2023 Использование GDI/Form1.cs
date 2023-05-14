using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДЗ_11._05._2023_Использование_GDI
{
    public partial class Form1 : Form
    {
        Graphics g;

        Pen pen;
        Pen pen1;
        Pen pen2;
        Pen pen3;
        Pen pen4;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Function Graph";
            this.Width = 400;
            this.Height = 480;

            comboBox1.Items.Add("y = x - 3");
            comboBox1.Items.Add("y = x * x");

            pictureBox1.Width = 360;
            pictureBox1.Height = 320;
            
            Bitmap screenPicture = new Bitmap(pictureBox1.Width, pictureBox1.Height); 
            pictureBox1.Image = screenPicture;

            pen = new Pen(Color.Black, 2.0f);
            pen1 = new Pen(Color.Black, 1.0f);
            pen2 = new Pen(Color.Red, 5.0f);
            pen3 = new Pen(Color.Red, 3.0f);
            pen4 = new Pen(Color.Black, 5.0f);

            g = Graphics.FromImage(pictureBox1.Image);
            

            for (int h = 0; h < pictureBox1.Size.Height; h++)
            {
                for (int w = 0; w < pictureBox1.Size.Width; w++)
                {
                    if (h % 20 == 0) // полосы по Height
                    {
                        g.DrawLine(pen1, 0, h, pictureBox1.Size.Width, h);
                    }
                    if (w % 20 == 0) // полосы по Width
                    {
                        g.DrawLine(pen1, w, 0, w, pictureBox1.Size.Height);
                    }
                    if (h == pictureBox1.Size.Height/2 && w == pictureBox1.Size.Width / 2) // красная точка и оси
                    {
                        g.DrawEllipse(pen2, new Rectangle(w-1, h-1, 1, 1));// красная точка
                        g.DrawLine(pen, 0, h, pictureBox1.Size.Width, h);  // ось Y
                        g.DrawLine(pen, w, 0, w, pictureBox1.Size.Height); // ось X
                    }

                }                
            }
            //pictureBox1.Invalidate(); 
        }

        private void button1Graph_Click(object sender, EventArgs e)
        {
            try
            {
                object obj = comboBox1.SelectedItem; 
                string func = obj.ToString();        // лучше по строкам, тк по индексам не вариант,
                                                     // что если поменяется местоположение функции в коллекции
                switch (func)
                {
                    case "y = x - 3":
                        Linear1(); 
                        break;

                    case "y = x * x":
                        Quadratic();
                        break; 
                }
                pictureBox1.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            pen.Dispose();
            pen1.Dispose();
            pen2.Dispose();
            pen3.Dispose();
            g.Dispose();
        }
        private void Linear1()
        {
            int pixel = 1;
            int size = 20;
            int range = 3 * size;

            for (int i = 0; i <= range; i++, pixel++)
            {
                int x = pixel + 180;
                int y = 3 * size - pixel + 160;
                g.DrawEllipse(pen3, new Rectangle(x, y, 1, 1));
            }
        }
        private void Quadratic()
        {
            int pixel = 1;
            int size = 20;
            int range = 3 * size;

            for (int i = 0; i <= range; i++, pixel++)
            {
                int x = 180 + pixel;
                int y = x * x / 100 - 160 - pixel;

                g.DrawEllipse(pen3, new Rectangle(x, y, 1, 1));
                //g.DrawEllipse(pen3, new Rectangle(360 - x, y, 1, 1));
            }
        }

    }
}
