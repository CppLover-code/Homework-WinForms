using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Написать функцию, которая «угадывает» задуманное пользова-
//телем число от 1 до 2000. Для запроса к пользователю использовать
//MessageBox. После того, как число отгадано, необходимо вывести
//количество запросов, потребовавшихся для этого, и предоставить
//пользователю возможность сыграть еще раз, не выходя из программы
//(MessageBox’ы оформляются кнопками и значками соответственно
//ситуации).
namespace Ex._2
{
    public partial class GuessNumber : Form
    {
        public object number;
        public GuessNumber()
        {
            InitializeComponent();
            Game();                  
        }
        private void Game()
        {
            MessageBox.Show("Введите число от 1 до 2000", "Уведомление");
            int number;
            while (true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    if (number < 1 || number > 10)//2000)
                    {
                        throw new Exception(" Неверный ввод!");
                    }
                    break;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Неверный ввод!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Random random = new Random();
            int guess;
            int attempt = 0;
            while (true)
            {
                guess = random.Next(1, 11);// 2001);

                attempt++;
               // MessageBox.Show($" Number {number}, guess {guess}, attempt {attempt}");
                if (guess == number)
                {
                    MessageBox.Show($"Компьтер угадал число за {attempt} попыток", "Победа!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    break;
                }
            }

            DialogResult result = MessageBox.Show("Желаете загадать число еще раз?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Game();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("До новых встреч!", "");
                Application.Exit();
            }
        }

        private void GuessNumber_KeyDown(object sender, KeyEventArgs e)
        {
            string text = e.KeyValue.ToString();//???????????????????????????
        }
    }
}
