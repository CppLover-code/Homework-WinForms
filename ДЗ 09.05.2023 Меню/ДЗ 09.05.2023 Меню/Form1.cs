using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace ДЗ_09._05._2023_Меню
{
    public partial class Form1 : Form
    {
        bool flag; // файл был открыт или создан новый
        public Form1()
        {
            InitializeComponent();
            this.Text = "Text editor";  
        }
        private void toolStripButton1Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader r = new StreamReader(openFileDialog1.FileName, Encoding.UTF8);
                textBox1Editor.Text = r.ReadToEnd();
                flag = true;
                r.Close();
            }
            this.Text = openFileDialog1.FileName;
        }
        private void toolStripButton1Create_Click(object sender, EventArgs e)
        {
            //Application.Restart();
            //  делать вторую форму
            textBox1Editor.Text = string.Empty;
            flag = false;
        }
        private void toolStripButton1Save_Click(object sender, EventArgs e)
        {
            string filename = openFileDialog1.FileName;

            if (flag == true)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(filename, false, Encoding.UTF8);

                    sw.Write(textBox1Editor.Text);
                    sw.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {

            }
        }
        private void toolStripButton1SaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog1.FileName, "Сохранение файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, true);

                    sw.Write(textBox1Editor.Text);
                    sw.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private void toolStripButton1Copy_Click(object sender, EventArgs e)
        {
            textBox1Editor.Copy();
        }
        private void toolStripButton1Paste_Click(object sender, EventArgs e)
        {
            textBox1Editor.Paste();
        }
        private void toolStripButton1Cut_Click(object sender, EventArgs e)
        {
            textBox1Editor.Cut();

        }
        private void toolStripButton1SelectAll_Click(object sender, EventArgs e)
        {
            textBox1Editor.SelectAll();
        }
        private void backgroundColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;

            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // установка цвета формы
            textBox1Editor.BackColor = colorDialog1.Color;
        }
        private void fontColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // установка цвета шрифта
            textBox1Editor.ForeColor = fontDialog1.Color;
        }
        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // установка шрифта
            textBox1Editor.Font = fontDialog1.Font;
        }   
    }
}
