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
        bool flag;              // файл новый или уже был сохранен
        bool checksave;         // сохранены ли изменения на момент закрытия формы
        public string filename; // строка будет хранить путь к файлу
        public Form1()
        {
            InitializeComponent();
            this.Text = "Text editor";

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Height = 700;
            this.Width = 800;

            toolStripStatusLabel1.Text = "Состояние:";
            toolStripStatusLabel2.Text = "";   
            
            flag = false; // значит это новый текстовый документ (ни разу не сохранен нигде)
        }

        #region IForm
        public string TextInTextBox
        {
            get => textBox1Editor.Text;
            set => textBox1Editor.Text = value;
        }
        // добавить события public event EventHandler CalculateArea; // событие
        #endregion

        #region Проброс события



        #endregion

        private void toolStripButton1Open_Click(object sender, EventArgs e)     // кнопка Открыть
        {
            NewForm form1 = new NewForm(this);                                              // создаем новую форму

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader r = new StreamReader(openFileDialog1.FileName, Encoding.UTF8);
                form1.textBox1Editor.Text = r.ReadToEnd();                                  // считываем с документа все в новую форму
                r.Close();
            }

            form1.Text = openFileDialog1.FileName;
            form1.filename = openFileDialog1.FileName;
            form1.Show();           
        }
        private void toolStripButton1Create_Click(object sender, EventArgs e)   // кнопка Создать
        {           
            NewForm form1 = new NewForm(this);
            form1.Show();
        }
        private void toolStripButton1Save_Click(object sender, EventArgs e)     // кнопка Сохранить
        {
            if(this.Text == "Text editor") flag = false;  // благодаря этой !плохой! проверке мы знаем как нужно сохранять документ,
            else flag = true;                             // если док Открытый, Созданный или Новый док при первом открытии формы
            
            if (flag == false)    // если док новый
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filename = saveFileDialog1.FileName;
                    try
                    {
                        StreamWriter sw = new StreamWriter(filename, true);         // сохраняем новый док
                        sw.Write(textBox1Editor.Text);
                        checksave = true;
                        sw.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    } 
                }

                try
                {
                    StreamReader r = new StreamReader(filename, Encoding.UTF8);     // и в этой же форме открываем его
                    textBox1Editor.Text = r.ReadToEnd();
                    flag = true; // значит, что документ уже был сохранен и далее при нажатии на Сохранить - 
                                 // изменения будут просто сохраняться в уже существующем файле (смотреть ELSE)
                    r.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }  

                this.Text = saveFileDialog1.FileName;
            }
            else                 // если документ уже был сохранён,
            {                    // тогда просто перезаписываем его
                try
                {
                    StreamWriter sw = new StreamWriter(filename, false, Encoding.UTF8);
                    sw.Write(textBox1Editor.Text);
                    checksave = true;
                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            toolStripStatusLabel2.Text = "сохранено";
        }
        private void toolStripButton1SaveAs_Click(object sender, EventArgs e)   // кнопка Сохранить как
        {
            // Происходит сохранение нового документа, но открытым остается всё тот же
            // но можно сделать иначе - закрыть старый полностью и открыть новосохранённый документ
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, true);

                    sw.Write(textBox1Editor.Text);
                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            toolStripStatusLabel2.Text = "сохранено";
        }
        private void toolStripButton1Copy_Click(object sender, EventArgs e)     // кнопка Копировать
        {
            textBox1Editor.Copy();
        }
        private void toolStripButton1Paste_Click(object sender, EventArgs e)    // кнопка Вставить
        {
            textBox1Editor.Paste();
        }
        private void toolStripButton1Cut_Click(object sender, EventArgs e)      // кнопка Вырезать
        {
            textBox1Editor.Cut();

        }
        private void toolStripButton1SelectAll_Click(object sender, EventArgs e)// кнопка Выделить всё
        {
            textBox1Editor.SelectAll();
        }
        private void backgroundColorToolStripMenuItem1_Click(object sender, EventArgs e) // кнопка Цвет фона
        {
            colorDialog1.FullOpen = true;

            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // установка цвета формы
            textBox1Editor.BackColor = colorDialog1.Color;
        }
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
        private void textBox1Editor_TextChanged(object sender, EventArgs e)     // измененмие текста влияет на строку состояния
        {
            toolStripStatusLabel2.Text = "редактирование";
            checksave = false;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)     // сохранение документа при закрытии
        {
            if (!checksave)
            {
                DialogResult res = MessageBox.Show("Сохранить изменения?", "Text editor", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    toolStripButton1Save.PerformClick();
                }
            }
        }
    }
    // Оставшиеся вопросы:
    // как применить цвет шрифта, сам шрифт, только для ВЫДЕЛЕННОГО текста?
    // нужен способ определить в textbox какой текст выделен и только к нему применить
    // textBox1Editor.SelectedText - вот и ответ. Свойство устанавливает выделенный текст и возвращает,
    // если таковой есть в нашем текстовом поле

}
