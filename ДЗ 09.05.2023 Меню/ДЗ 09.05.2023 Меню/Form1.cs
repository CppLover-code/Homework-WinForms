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
                    case 0://открыть
                        openFileDialog1 = new OpenFileDialog();
                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            StreamReader r = new StreamReader(openFileDialog1.FileName, Encoding.UTF8);
                            textBox1Editor.Text = r.ReadToEnd();
                            r.Close();
                        }
                        this.Text = openFileDialog1.FileName;
                        break;
                    case 1://новый док
                        textBox1Editor.Text = string.Empty;
                        break;

                    case 2://сохранить
                        
                        break;

                    case 3://сохранить как
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
                        break;

                    case 4:
                        
                        break;

                    case 5:
                        break;

                    case 6:

                        break;
                    case 7:

                        break;
                    case 8:

                        break;

                    case 9:

                        break;
                }
            }
            catch (Exception)
            {

            }
        }       
    }
}
