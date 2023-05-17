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
using ДЗ_09._05._2023_Меню.View;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace ДЗ_09._05._2023_Меню
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Text editor";

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Height = 700;
            this.Width = 800;
        }

        #region IView
        public System.Windows.Forms.TextBox TextInTextBox
        {
            get => textBox1Editor;
            set => textBox1Editor = value;
        }
        
        // события
        public event EventHandler OpenFile;
        public event EventHandler CreateNew;
        public event EventHandler Save;
        public event EventHandler Copy;
        public event EventHandler Paste;
        public event EventHandler Cut;
        public event EventHandler SelectAll;
        public event EventHandler BackgrColor;
        #endregion

        #region Проброс события
        private void toolStripButton1Open_Click(object sender, EventArgs e)    // кнопка Открыть
        {
            OpenFile?.Invoke(this, EventArgs.Empty);
        }
        private void toolStripButton1Create_Click(object sender, EventArgs e)  // кнопка Создать
        {
            CreateNew?.Invoke(this, EventArgs.Empty);
        }
        private void toolStripButton1Save_Click(object sender, EventArgs e)    // кнопка Сохранить
        {
           Save?.Invoke(this, EventArgs.Empty);
        }
        private void toolStripButton1Copy_Click(object sender, EventArgs e)     // кнопка Копировать
        {
            Copy?.Invoke(this, EventArgs.Empty);
        }
        private void toolStripButton1Paste_Click(object sender, EventArgs e)    // кнопка Вставить
        {
            Paste?.Invoke(this, EventArgs.Empty);
        }
        private void toolStripButton1Cut_Click(object sender, EventArgs e)      // кнопка Вырезать
        {
            Cut?.Invoke(this, EventArgs.Empty);
        }
        private void toolStripButton1SelectAll_Click(object sender, EventArgs e)// кнопка Выделить всё
        {
            SelectAll?.Invoke(this, EventArgs.Empty);
        }

        private void backgroundColorToolStripMenuItem1_Click(object sender, EventArgs e) // кнопка Цвет фона
        {
            BackgrColor?.Invoke(this, EventArgs.Empty);
        }
        #endregion

        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////
  
        private void fontColorToolStripMenuItem1_Click(object sender, EventArgs e)       // кнопка Цвет шрифта
        {
            colorDialog1.FullOpen = false;
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // установка цвета шрифта - меняется цвет шрифта по всей форме!!!(надо бы еще сделать только для выделенного текста)
            textBox1Editor.ForeColor = colorDialog1.Color;
        }
        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)            // кнопка Шрифт
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // установка шрифта
            textBox1Editor.Font = fontDialog1.Font; 
        }    
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)     // сохранение документа при закрытии
        {
                DialogResult res = MessageBox.Show("Сохранить изменения?", "Text editor", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    toolStripButton1Save.PerformClick();
                }
        }
    }
    // Оставшиеся вопросы:
    // как применить цвет шрифта, сам шрифт, только для ВЫДЕЛЕННОГО текста?
    // нужен способ определить в textbox какой текст выделен и только к нему применить
    // textBox1Editor.SelectedText - вот и ответ. Свойство устанавливает выделенный текст и возвращает,
    // если таковой есть в нашем текстовом поле

}
