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
        public Form1()
        {
            InitializeComponent();
            this.Text = "Function Graph";
            this.Width = 400;
            this.Height = 480;

            comboBox1.Items.Add("y = x - b");
            comboBox1.Items.Add("y = x^2");
            comboBox1.Items.Add("y = \u221Ax");
            comboBox1.Items.Add("y = (x - b)^2");

            pictureBox1.Width = 360;
            pictureBox1.Height = 320;
            
            Bitmap screenPicture = new Bitmap(pictureBox1.Width, pictureBox1.Height); 
            pictureBox1.Image = screenPicture;

            Pen pen = new Pen(Color.Black, 2.0f);
            Pen pen1 = new Pen(Color.Black, 1.0f);
            Pen pen2 = new Pen(Color.Red, 10.0f);
            Pen pen3 = new Pen(Color.Red, 1.0f);

            Graphics g = Graphics.FromImage(pictureBox1.Image);
            
            // здесь нарисовать сетку через цикл

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
                        //g.DrawEllipse(pen2, new Rectangle(w, h, 1, 1));    // красная точка
                        g.DrawLine(pen, 0, h, pictureBox1.Size.Width, h);  // ось Y
                        g.DrawLine(pen, w, 0, w, pictureBox1.Size.Height); // ось X
                    }

                }                
            }


            //for (int x = 80; x <= 260; x++) // первая
            //{
            //    int y = x - 35;

            //    g.DrawEllipse(pen3, new Rectangle(x, y, 1, 1));
            //}

            //for (int x = 180; x <= 300; x++) // вторая
            //{
            //    int y = x * x / 100 / 2;

            //    g.DrawEllipse(pen3, new Rectangle(x, y, 1, 1));
            //}
            //for (int x = 180; x <= 320; x++) // третья
            //{
            //    int y = (int)Math.Sqrt(x) + 150; // корень квадратный из X 

            //    g.DrawEllipse(pen3, new Rectangle(x, y, 1, 1));
            //}

            //for (int x = 60; x <= 240; x++) // четвертая
            //{
            //    int y = (x / 5 - 20) * (x / 5 - 20) + 160; //  pow((X -b),2)  * X

            //    g.DrawEllipse(pen3, new Rectangle(x, y, 1, 1));
            //}
            
            pictureBox1.Invalidate(); // отвечает за перерисовку изображения 


            pen.Dispose();
            pen1.Dispose();
            pen2.Dispose();
            pen3.Dispose();
            g.Dispose();
        }



    }
}
