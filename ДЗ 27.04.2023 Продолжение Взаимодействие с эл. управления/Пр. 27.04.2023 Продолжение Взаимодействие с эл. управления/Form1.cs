using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Пр._27._04._2023_Продолжение_Взаимодействие_с_эл.управления
{
    public partial class Form1 : Form
    {
        private double a98 = 43;
        private double a95 = 45;
        private double dayTotal = 0;

        int flag = 0;
        public Form1()
        {
            InitializeComponent();
            this.Text = "BestOil";
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(300, 200);
            this.Height = 523;
            this.Width = 523;

            timer2.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboGas.SelectedIndex = 0;
            rbCountGas.Checked = true;
            labelCafePayment.Text = PaymentCafe().ToString("N2");

            toolTip1.AutoPopDelay = 3000;       // Установка задержек для объекта ToolTip.
            toolTip1.InitialDelay = 300;
            toolTip1.ReshowDelay = 200;

            toolTip1.ShowAlways = true;         // отображение подсказки в зависимости от активности формы  
        }

        ///////////Автозаправка//////////////
        private void comboGas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboGas.SelectedIndex == 0)
            {
                tbPriceGas.Text = a98.ToString();
            }
            else if (comboGas.SelectedIndex == 1)
            {
                tbPriceGas.Text = a95.ToString();
            }
            label4PaymentGas.Text = PaymentGas().ToString("N2");
        }

        private void rbCountGas_Click(object sender, EventArgs e)
        {

        }

        private void rbCountGas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCountGas.Checked)
            {
                tbCountGas.ReadOnly = false;
                tbSumGas.ReadOnly = true;
                tbCountGas.Text = 10.ToString("N2");
                tbSumGas.Text = string.Empty;
            }
            else if (rbSumGas.Checked)
            {
                tbCountGas.ReadOnly = true;
                tbSumGas.ReadOnly = false;
                tbSumGas.Text = 100.ToString("N2");
                tbCountGas.Text = string.Empty;
            }
        }
        private double PaymentGas()
        {
            double toPaymentGas = 0;

            if (rbCountGas.Checked)
            {
                toPaymentGas = double.Parse(tbCountGas.Text) * double.Parse(tbPriceGas.Text);
            }
            else if (rbSumGas.Checked)
            {
                toPaymentGas = double.Parse(tbSumGas.Text);
                /// изменение кол-ва литров, если пользователь выбрал сумму
                tbCountGas.Text = (toPaymentGas / double.Parse(tbPriceGas.Text)).ToString("N2");
            }
            return toPaymentGas;
        }

        // постоянный перерасчет К Оплате
        // как только мы меняем кол-во литров или тип бензина, то происходит перерасчет сразу же
        private void tbCountGas_TextChanged(object sender, EventArgs e)
        {
            label4PaymentGas.Text = PaymentGas().ToString("N2");
        }

        ///////////Мини-кафе//////////////
        private void checkBoxFood_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1HotDog.Checked)
            {
                textBox1HotDogCount.ReadOnly = false;
            }
            else
            {
                textBox1HotDogCount.Text = "0";
                textBox1HotDogCount.ReadOnly = true;
            }

            if (checkBox2Hamburger.Checked)
            {
                textBox2HamburgerCount.ReadOnly = false;
            }
            else
            {
                textBox2HamburgerCount.Text = "0";
                textBox2HamburgerCount.ReadOnly = true;
            }

            if (checkBox3Fries.Checked)
            {
                textBox3FriesCount.ReadOnly = false;
            }
            else
            {
                textBox3FriesCount.Text = "0";
                textBox3FriesCount.ReadOnly = true;
            }

            if (checkBox4Cola.Checked)
            {
                textBox4ColaCount.ReadOnly = false;
            }
            else
            {
                textBox4ColaCount.Text = "0";
                textBox4ColaCount.ReadOnly = true;
            }

        }

        private double PaymentCafe()
        {
            double toPaymentCafe = 0;

            if (checkBox1HotDog.Checked)
                //if (String.IsNullOrEmpty(textBox1HotDogCount.Text)) textBox1HotDogCount.Text = "0"; // не очень удобно потом вводить количество!
                toPaymentCafe += (int.Parse(textBox1HotDogCount.Text) * double.Parse(textBox1HotDogPrice.Text));

            if (checkBox2Hamburger.Checked)
                toPaymentCafe += (int.Parse(textBox2HamburgerCount.Text) * double.Parse(textBox2HamburgerPrice.Text));

            if (checkBox3Fries.Checked)
                toPaymentCafe += (int.Parse(textBox3FriesCount.Text) * double.Parse(textBox3FriesPrice.Text));

            if (checkBox4Cola.Checked)
                toPaymentCafe += (int.Parse(textBox4ColaCount.Text) * double.Parse(textBox4ColaPrice.Text));

            return toPaymentCafe;
        }

        private void textBoxFoodCount_TextChanged(object sender, EventArgs e)
        {
            labelCafePayment.Text = PaymentCafe().ToString("N2");
        }

        private double TotalPayment()
        {
            double totalPayment = 0;
            double gasPayment = PaymentGas();
            double cafePayment = PaymentCafe();

            if (gasPayment > 0 && cafePayment > 0)
            {
                totalPayment = gasPayment + cafePayment;
            }
            else if (gasPayment > 0 && cafePayment < 1)
            {
                totalPayment = gasPayment;
            }

            return totalPayment;
        }
        private void buttonCalculateTotal_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                labelTotalPayment.Text = TotalPayment().ToString("N2");
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            DialogResult result = MessageBox.Show("Завершить покупку?", "Внимание!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                dayTotal += TotalPayment();
                //while (Controls.Count > 0)    // проблема - используя данный способ, закрытие происходит
                //{                             // несколько раз (вывод mes.box)
                //    Controls[0].Dispose();
                //}
                //InitializeComponent();
                //comboGas.SelectedIndex = 0;
                //rbCountGas.Checked = true;
                //labelCafePayment.Text = PaymentCafe().ToString("N2");

                // Вопрос: как использовать код ниже, не копируя. Ведь он взят из событий выше!
                comboGas.SelectedIndex = 0;
                rbCountGas.Checked = true;

                if (comboGas.SelectedIndex == 0)
                {
                    tbPriceGas.Text = a98.ToString();
                }
                else if (comboGas.SelectedIndex == 1)
                {
                    tbPriceGas.Text = a95.ToString();
                }
                label4PaymentGas.Text = PaymentGas().ToString("N2");

                if (rbCountGas.Checked)
                {
                    tbCountGas.ReadOnly = false;
                    tbSumGas.ReadOnly = true;
                    tbCountGas.Text = 10.ToString("N2");
                    tbSumGas.Text = string.Empty;
                }
                else if (rbSumGas.Checked)
                {
                    tbCountGas.ReadOnly = true;
                    tbSumGas.ReadOnly = false;
                    tbSumGas.Text = 100.ToString("N2");
                    tbCountGas.Text = string.Empty;
                }

                checkBox1HotDog.Checked = false;
                textBox1HotDogCount.Text = "0";
                textBox1HotDogCount.ReadOnly = true;

                checkBox2Hamburger.Checked = false;
                textBox2HamburgerCount.Text = "0";
                textBox2HamburgerCount.ReadOnly = true;


                checkBox3Fries.Checked = false;
                textBox3FriesCount.Text = "0";
                textBox3FriesCount.ReadOnly = true;


                checkBox4Cola.Checked = false;
                textBox4ColaCount.Text = "0";
                textBox4ColaCount.ReadOnly = true;

                labelCafePayment.Text = PaymentCafe().ToString("N2");
                labelTotalPayment.Text = string.Empty;
            }
            else
            {
                timer1.Enabled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show($"Сумма {dayTotal} грн.", "Выручка за день", MessageBoxButtons.OK, MessageBoxIcon.Information);
            e.Cancel = false;
            MessageBox.Show("До свидания!");
        }

        private void timer2_Tick(object sender, EventArgs e) // работа со строкой состояния и таймером
        {
            flag += 10;
            if (flag % 20 == 0)
            {  
                toolStripStatusLabel1.Text = "Дата:";
                toolStripStatusLabel2.Text = DateTime.Now.ToLongDateString();
            }
            else
            {
                toolStripStatusLabel1.Text = "Время:";
                toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
            }
            toolStripDropDownButton1.Text = CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek).ToString();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show(); // показываем форму
            WindowState = FormWindowState.Normal; // переводим форму в нормальный вид из свёрнутого
            this.notifyIcon1.Visible = false; // прячем иконку
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide(); // прячем форму
                this.notifyIcon1.Visible = true; // появляется иконка
                this.notifyIcon1.ShowBalloonTip(3); //
            }
        }
    }
}
