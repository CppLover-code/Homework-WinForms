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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) // панель инструментов
        {
            try
            {               
                switch (toolStrip1.Items.IndexOf(e.ClickedItem))
                {
                    case 0:
                        Open();
                        break;

                    case 1:
                        NewDoc();
                        break;

                    case 2:
                        Save();
                        break;

                    case 3:
                        SaveAs();
                        break;

                    case 5:
                        Copy();
                        break;

                    case 6:
                        Paste();
                        break;

                    case 7:
                        Cut();
                        break;

                    case 8:
                        SelectAll();    
                        break;
                    case 10:

                        break;

                    case 9:

                        break;
                }
            }
            catch (Exception)
            {

            }
        }
        private void Open()
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
        private void NewDoc()
        {
            //Application.Restart();
            textBox1Editor.Text = string.Empty;
            flag = false;
        }
        private void Save()
        {
            string filename = openFileDialog1.FileName;

            if (flag)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(filename, false);

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
        private void SaveAs()
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
        private void Copy()
        {
            textBox1Editor.Copy();
        }
        private void Paste()
        {
            textBox1Editor.Paste();
        }
        private void Cut()
        {
            textBox1Editor.Cut();
        }
        private void SelectAll()
        {
            textBox1Editor.SelectAll();
        }
    }
}
