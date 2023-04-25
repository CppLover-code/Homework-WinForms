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
        public GuessNumber()
        {
            InitializeComponent();
            MessageBox.Show("Игра \"Угадай число\"");
            Game();                  
        }
        private void Game()
        {
            Random random = new Random();
            int number = random.Next(1, 21);
            MessageBox.Show($"Загаданное число {number}", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int guess;
            int attempt = 0;
            while (true)
            {
                guess = random.Next(1, 21);

                attempt++;
               // MessageBox.Show($" Number {number}, guess {guess}, attempt {attempt}");
                if (guess == number)
                {
                    MessageBox.Show($"Компьтер угадал число за {attempt} попыток", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }

            DialogResult result = MessageBox.Show("Желаете продолжить?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
    }
}
