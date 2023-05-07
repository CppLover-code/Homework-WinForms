using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ДЗ_05._05._2023_Создание_доп.форм
{
    public partial class Form2 : Form
    {
        List<Product> products;
        public Form2(List<Product> goods)
        {
            InitializeComponent();
            this.products = goods;

            foreach(var item in products)
                listBox1GoodsInfo.Items.Add(item);
        }

        private void listBox1GoodsInfo_Leave(object sender, EventArgs e) // не нужное событие ПОДУМАТЬ!!!!
        {
            //когда листбокс теряет фокус, то убираем выделение с объекта
            //listBox1GoodsInfo.ClearSelected();
            //button1Edit.Enabled = false;
            //button2Refresh.Enabled = false;
            //button3Cancel.Enabled = false;
        }

        private void listBox1GoodsInfo_SelectedIndexChanged(object sender, EventArgs e)
        {                    
            button1Edit.Enabled = true;
            button2Refresh.Enabled = true;
            button3Cancel.Enabled = true;
        }

        private void button1Edit_Click(object sender, EventArgs e)
        {
            int index = listBox1GoodsInfo.SelectedIndex;
            var product = (Product)listBox1GoodsInfo.Items[index];

            textBox1Title.Text = product.Title;
            textBox2Detail.Text = product.Detail;
            textBox3Description.Text = product.Description;
            textBox4Price.Text = product.Price.ToString();
        }

        private void button2Refresh_Click(object sender, EventArgs e)
        {

            if (textBox1Title.Text == "" || 
                textBox2Detail.Text == "" || 
                textBox3Description.Text == "" ||
                textBox4Price.Text == "")
            {//Проверка заполнения полей
                MessageBox.Show("Заполните все поля");
                return;
            }

            int index = listBox1GoodsInfo.SelectedIndex;
            var product = (Product)listBox1GoodsInfo.Items[index];

            product.Title = textBox1Title.Text;
            product.Detail = textBox2Detail.Text;
            product.Description = textBox3Description.Text;

            try
            {
                product.Price = Convert.ToDouble(textBox4Price.Text);
            }
            catch
            {
                MessageBox.Show("Цена указана неверно");
                return;
            }
        }

        private void button3Cancel_Click(object sender, EventArgs e)
        {
            textBox1Title.Text = string.Empty;
            textBox2Detail.Text = string.Empty;
            textBox3Description.Text = string.Empty;
            textBox4Price.Text = string.Empty;
            listBox1GoodsInfo.ClearSelected();
            return;
        }
    }
}
