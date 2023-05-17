using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДЗ_09._05._2023_Меню.Models
{
    public class Model
    {
        public TextBox Content { get; set; }
       
        public TextBox OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader r = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                Content.Text = r.ReadToEnd();
                r.Close();
            }

            return Content;
        }
        public TextBox CreateNew()
        {
            Content.Text = string.Empty;
            return Content;
        }
        public TextBox Save()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName, true);         // сохраняем новый док
                    sw.Write(Content.Text);
                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return Content;
        }
        public TextBox Copy()
        {
            Content.Copy();
            return Content;
        }
        public TextBox Paste()
        {
            Content.Paste();
            return Content;
        }
        public TextBox Cut()
        {
            Content.Cut();
            return Content;
        }

    }
}
