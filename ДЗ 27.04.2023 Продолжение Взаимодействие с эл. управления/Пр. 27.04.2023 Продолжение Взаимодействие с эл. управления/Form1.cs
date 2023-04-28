using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пр._27._04._2023_Продолжение_Взаимодействие_с_эл.управления
{
    public partial class Form1 : Form
    {
        private double a98 = 43;
        private double a95 = 45;
        public Form1()
        {
            InitializeComponent();
            this.Text = "BestOil";
            this.Height = 523;
            this.Width = 523;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboGas.SelectedIndex = 0;
            rbCountGas.Checked = true;
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
            if(rbCountGas.Checked)
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

            if(rbCountGas.Checked)
            {
                toPaymentGas = double.Parse(tbCountGas.Text) * double.Parse(tbPriceGas.Text);
            }
            else if(rbSumGas.Checked)
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
            if(checkBox1HotDog.Checked)
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
            else if(gasPayment > 0 && cafePayment < 1)
            {
                totalPayment = gasPayment;
            }          

            return totalPayment;
        }     
        private void buttonCalculateTotal_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                labelTotalPayment.Text = TotalPayment().ToString("N2");
            }
        }
    }
}
