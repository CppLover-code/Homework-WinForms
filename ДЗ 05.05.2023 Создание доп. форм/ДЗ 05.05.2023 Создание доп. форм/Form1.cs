using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДЗ_05._05._2023_Создание_доп.форм
{
    public partial class Form1 : Form
    {
        List<Product> goods = new List<Product>();
        double total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var p1 = new Product("Процессор Intel Core i7-13700K", "Разъём: Socket 1700; Поколение: 13 поколение (Raptor Lake); Ядро: 16", "Процессор Intel Core 13-го поколения для настольных ПК с разблокированным множителем.", 18599);
            var p2 = new Product("Оперативная память Kingston Fury DDR4", "Объем памяти: 32 ГБ; Тип: DDR4 SDRAM; Частота: 3200 МГц", "Геймерская оперативная память", 3399);
            var p3 = new Product("Жесткий диск Transcend StoreJet 25M3C", "Емкость: 4 ТБ; Совместимость: Для MAC OS и Windows", "Портативный жесткий диск имеет прочный и надежный корпус.", 5109);
            var p4 = new Product("Корпус QUBE Neptune Black", "Форм-фактор материнской платы: ATX, Mini-ITX, microATX; Тип корпуса: Miditower", "Качественный и функциональный корпус.", 2139);
            var p5 = new Product("Название", "Характеристика", "Описание", 564);

            goods.Add(p1);
            goods.Add(p2);
            goods.Add(p3);
            goods.Add(p4);
            goods.Add(p5);

            foreach (var item in goods)
                comboBox1Goods.Items.Add(item);

        }

        private void comboBox1Goods_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1Goods.SelectedIndex;
            var product = (Product)comboBox1Goods.Items[index];
            textBox1PriceOfProd.Text = product.Price.ToString();
            button1AddToListSales.Enabled = true;
        }

        private void button1AddToListSales_Click(object sender, EventArgs e)
        { 
            int index = comboBox1Goods.SelectedIndex;
            var product = (Product)comboBox1Goods.Items[index];
            listBox1Sales.Items.Add(product);

            total += product.Price;
            textBox1TotalCost.Text = total.ToString();

            // опционально, можно и убрать, но с очисткой удобнее
            comboBox1Goods.SelectedIndex = default;          
            textBox1PriceOfProd.Text = string.Empty;
            button1AddToListSales.Enabled = false;
        }

        private void button2ChangeListGoods_Click(object sender, EventArgs e)
        {
            comboBox1Goods.Text = string.Empty;
            //comboBox1Goods.ResetText();
            textBox1PriceOfProd.Text = string.Empty;

            Form2 changeform = new Form2(goods);
            changeform.ShowDialog();

            comboBox1Goods.Items.Clear();

            foreach (var item in goods)
                comboBox1Goods.Items.Add(item);
        }
    }
}
