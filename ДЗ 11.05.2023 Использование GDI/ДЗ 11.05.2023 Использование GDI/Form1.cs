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

        int x0;    
        int y0;

        int pixel;
        int size;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Function Graph";
            this.Width = 400;
            this.Height = 480;

            comboBox1.Items.Add("y = x - 3");
            comboBox1.Items.Add("y = x * x");
            comboBox1.Items.Add("y = x * x * x");

            pictureBox1.Width = 360;
            pictureBox1.Height = 320;

            x0 = pictureBox1.Width / 2;    // начало коорд 
            y0 = pictureBox1.Height / 2;   // плоскости

            pixel = 1;
            size = 20;                     // размер одной стороны квадратика на плоскости

            Bitmap screenPicture = new Bitmap(pictureBox1.Width, pictureBox1.Height); 
            pictureBox1.Image = screenPicture;

            pen = new Pen(Color.Black, 2.0f);
            pen1 = new Pen(Color.Black, 1.0f);
            pen2 = new Pen(Color.Red, 5.0f);
            pen3 = new Pen(Color.Red, 3.0f);

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
                        Linear(); 
                        break;

                    case "y = x * x":
                        Quadratic();
                        break;

                    case "y = x * x * x":
                        Cubic();
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
        private void Linear()
        {          
            for (int i = 0; i < 3 * size - 1; i++, pixel++)
            {
                int x = pixel + x0;
                int y = 3 * size - pixel + y0;

                int x1 = x0 + pixel + 1;
                int y1 = 3*size - (pixel+1) + y0;

                g.DrawLine(pen3, x, y, x1, y1);
            }
        }
        private void Quadratic()
        {
            for (pixel = -3 * size; pixel < 3 * size; pixel++)
            {
                int x = x0 + pixel;
                int y = y0 - (pixel * pixel / size);

                int x1 = x0 + pixel + 1;
                int y1 = y0 - (int)(Math.Pow(pixel + 1, 2) / size);

                g.DrawLine(pen3, x, y, x1, y1);
            }
        }
        private void Cubic()
        {
            for (pixel = -2 * size; pixel < 2 * size; pixel++)
            {
                int x = x0 + pixel;
                int y = y0 - (int)(Math.Pow(pixel,3)/Math.Pow(size, 2));

                int x1 = x0 + pixel + 1;
                int y1 = y0 - (int)(Math.Pow(pixel+1, 3) / Math.Pow(size, 2));

                g.DrawLine(pen3, x, y, x1, y1);
            }
        }
    }
}
