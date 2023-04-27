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
            double toPayment = 0;

            if(rbCountGas.Checked)
            {
                toPayment = double.Parse(tbCountGas.Text) * double.Parse(tbPriceGas.Text);
            }
            else if(rbSumGas.Checked)
            {
                toPayment = double.Parse(tbSumGas.Text);
                /// изменение кол-ва литров, если пользователь выбрал сумму
                tbCountGas.Text = (toPayment / double.Parse(tbPriceGas.Text)).ToString("N2");
            }
            return toPayment;
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
                textBox1HotDogCount.ReadOnly = false;

            if (checkBox2Hamburger.Checked)
                textBox2HamburgerCount.ReadOnly = false;

            if (checkBox3Fries.Checked)
                textBox3FriesCount.ReadOnly = false;

            if (checkBox4Cola.Checked)
                textBox4ColaCount.ReadOnly = false;
        }


        
    }
}
