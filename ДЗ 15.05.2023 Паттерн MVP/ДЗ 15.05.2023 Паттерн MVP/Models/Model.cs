using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДЗ_09._05._2023_Меню
{
    public class Model
    {
        public TextBox TextInTextBox { get; set; }
        public OpenFileDialog openFileDialog { get; set; }
        public SaveFileDialog saveFileDialog { get; set; }
        public TextBox OpenFile()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader r = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                TextInTextBox.Text = r.ReadToEnd();                                  
                r.Close();
            }

            return TextInTextBox;
        }

        public TextBox CreateNew()
        {
            TextInTextBox.Text = string.Empty;
            return TextInTextBox;
        }
        public TextBox Save()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName, true);         // сохраняем новый док
                    sw.Write(TextInTextBox);
                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return TextInTextBox;
        }
        public string Copy()
        {
            TextInTextBox.Copy();
            return TextInTextBox.Text;
        }
    }
}
