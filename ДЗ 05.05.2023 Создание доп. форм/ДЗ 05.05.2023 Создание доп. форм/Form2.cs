﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        private void listBox1GoodsInfo_SelectedIndexChanged(object sender, EventArgs e)
        {                    
            button1Edit.Enabled = true;
            button1AddProd.Enabled = false;
        }

        private void button1Edit_Click(object sender, EventArgs e)  // кнопка Редактировать
        {
            int index = listBox1GoodsInfo.SelectedIndex;
            

            if(index == -1)
            {
                MessageBox.Show("Выберите товар для редактирования!");
                return;
            }

            var product = (Product)listBox1GoodsInfo.Items[index];

            textBox1Title.Text = product.Title;
            textBox2Detail.Text = product.Detail;
            textBox3Description.Text = product.Description;
            textBox4Price.Text = product.Price.ToString();

            button2Refresh.Enabled = true;
            button3Cancel.Enabled = true;
            button1Edit.Enabled = false;
            button1AddProd.Enabled = false;
        }

        private void button2Refresh_Click(object sender, EventArgs e)  // кнопка Обновить
        {

            if (textBox1Title.Text == "" ||                            // проверка заполнения полей
                textBox2Detail.Text == "" || 
                textBox3Description.Text == "" ||
                textBox4Price.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            int ind = listBox1GoodsInfo.SelectedIndex;
            var product = (Product)listBox1GoodsInfo.Items[ind];            

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

            products[ind] = product;
            listBox1GoodsInfo.Items[ind] = product;

            MessageBox.Show("Информация о товаре обновлена!");           

            button1Edit.Enabled = false;
            button2Refresh.Enabled = false;
            button3Cancel.Enabled = false;
            button1AddProd.Enabled = false;

            textBox1Title.Text = string.Empty;
            textBox2Detail.Text = string.Empty;
            textBox3Description.Text = string.Empty;
            textBox4Price.Text = string.Empty;

            listBox1GoodsInfo.ClearSelected();
        }

        private void button3Cancel_Click(object sender, EventArgs e)  // кнопка Отменить
        {
            textBox1Title.Text = string.Empty;
            textBox2Detail.Text = string.Empty;
            textBox3Description.Text = string.Empty;
            textBox4Price.Text = string.Empty;

            listBox1GoodsInfo.ClearSelected();

            button1Edit.Enabled = false;
            button2Refresh.Enabled = false;
            button3Cancel.Enabled = false;

            return;
        }

        private void textBoxForm2_TextChanged(object sender, EventArgs e)
        {
            if(button1Edit.Focused || button2Refresh.Enabled == true)
            {
                button1AddProd.Enabled = false;
            }
            else
            {
                button1AddProd.Enabled = true;
                button1Edit.Enabled = false;
                listBox1GoodsInfo.ClearSelected();
            }
        }

        private void button1AddProd_Click(object sender, EventArgs e)
        {
            if (textBox1Title.Text == "" ||                            // проверка заполнения полей
                textBox2Detail.Text == "" ||
                textBox3Description.Text == "" ||
                textBox4Price.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            var newProduct = new Product();

            newProduct.Title = textBox1Title.Text;
            newProduct.Detail = textBox2Detail.Text;
            newProduct.Description = textBox3Description.Text;

            try
            {
                newProduct.Price = Convert.ToDouble(textBox4Price.Text);
            }
            catch
            {
                MessageBox.Show("Цена указана неверно!");
                return;
            }

            products.Add(newProduct);
            listBox1GoodsInfo.Items.Add(newProduct);

            textBox1Title.Text = string.Empty;
            textBox2Detail.Text = string.Empty;
            textBox3Description.Text = string.Empty;
            textBox4Price.Text = string.Empty;

            button1AddProd.Enabled = false;

            MessageBox.Show("Новый товар добавлен!");
        }
    }
}
