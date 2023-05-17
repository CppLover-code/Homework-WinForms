using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДЗ_09._05._2023_Меню.Models
{
    // в модели выполняются все необходимые действия для VIEW
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
        public TextBox SelectAll()
        {
            Content.SelectAll();
            return Content;
        }
        public TextBox BackgrColor()
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;

            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return Content;
            // установка цвета формы
            Content.BackColor = colorDialog.Color;

            return Content;
        }
        public TextBox FontColor()
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = false;
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return Content;

            // установка цвета шрифта - меняется цвет шрифта по всей форме!!!(надо бы еще сделать только для выделенного текста)
            Content.ForeColor = colorDialog.Color;

            return Content;
        }
        public TextBox FontSettings()
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.Cancel)
                return Content;
            // установка шрифта
            Content.Font = fontDialog.Font;

            return Content;
        }
        public TextBox FormClose()
        {
            DialogResult res = MessageBox.Show("Сохранить изменения?", "Text editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Save();
                Thread.Sleep(500);
            }
            return Content;
        }
    }
}
