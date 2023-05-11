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

                        //FontDialog fontDialog = new FontDialog();
                        //ColorDialog colorDialog = new ColorDialog();

                        //switch (toolStripDropDownButton1EditorSettings.DropDownItemClicked)
                        //{
                        //    case 0:

                        //        if (fontDialog.ShowDialog() == DialogResult.Cancel)
                        //            return;

                        //        // установка цвета шрифта
                        //        textBox1Editor.ForeColor = fontDialog.Color;
                        //        break;

                        //    case 1:
                        //        // расширенное окно для выбора цвета
                        //        colorDialog.FullOpen = true;

                        //        if (colorDialog.ShowDialog() == DialogResult.Cancel)
                        //            return;
                        //        // установка цвета формы
                        //        textBox1Editor.BackColor = colorDialog.Color;
                        //        break;

                        //    case 2:
                        //        if (fontDialog.ShowDialog() == DialogResult.Cancel)
                        //            return;

                        //        // установка шрифта
                        //        textBox1Editor.Font = fontDialog.Font;
                        //        break;
                        //}
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
            //  делать вторую форму
            textBox1Editor.Text = string.Empty;
            flag = false;
        }
        private void Save()
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
        private void S()
        {
            textBox1Editor.SelectAll();
        }

        private void backgroundColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;

            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // установка цвета формы
            textBox1Editor.BackColor = colorDialog.Color;
        }

        private void fontColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.Cancel)
                return;

            // установка цвета шрифта
            textBox1Editor.ForeColor = fontDialog.Color;
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // установка шрифта
            textBox1Editor.Font = fontDialog1.Font;
        }
    }
}
