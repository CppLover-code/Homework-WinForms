using System;
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
        private void Form2_Load(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 5000;       // Установка задержек для объекта ToolTip.
            toolTip1.InitialDelay = 300;
            toolTip1.ReshowDelay = 200;

            toolTip1.ShowAlways = true;         // отображение подсказки в зависимости от активности формы

            toolTip1.SetToolTip(this.panel1AddEdit, "Панель ввода информации о новом товаре и редактирования товара из списка.\nДля добавления нового товара начните вводить данные в поля.\nДля редактирования - выберите товар из списка.");          
            toolTip1.SetToolTip(this.panel1Edit, "Панель кнопок для работы с товарами.\nЧтобы активировать панель, выберите товар из списка выше");
            toolTip1.SetToolTip(this.listBox1GoodsInfo, "Выберите товар, который желаете изменить/удалить");
            toolTip1.SetToolTip(this.button1Edit, "Редактирование информации о товаре");
            toolTip1.SetToolTip(this.button4Delete, "Удаление товара");
            toolTip1.SetToolTip(this.button2Refresh, "Обновление информации после редактирования");
            toolTip1.SetToolTip(this.button3Cancel, "Отмена редактирования и обновления информации");
            toolTip1.SetToolTip(this.button1AddProd, "Добавление нового товара в список");


            //toolTip1.SetToolTip(this.textBox3Mail, "Формат: ИмяПользователя@почтовый сервис.com");
            //toolTip1.SetToolTip(this.textBox4Tel, "Формат: +380 XX XXX XX XX");
        }
        private void listBox1GoodsInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1GoodsInfo.SelectedIndex != -1)
            {
                button1Edit.Enabled = true;
                button4Delete.Enabled = true;
                button1AddProd.Enabled = false;
            }
        }

        private void button1Edit_Click(object sender, EventArgs e)  // кнопка Редактировать
        {
            int index = listBox1GoodsInfo.SelectedIndex;
            var product = (Product)listBox1GoodsInfo.Items[index];

            textBox1Title.Text = product.Title;
            textBox2Detail.Text = product.Detail;
            textBox3Description.Text = product.Description;
            textBox4Price.Text = product.Price.ToString();

            button2Refresh.Enabled = true;
            button3Cancel.Enabled = true;
            button4Delete.Enabled = false;
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
                MessageBox.Show("Цена указана неверно!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            products[index] = product;
            listBox1GoodsInfo.Items[index] = product;

            MessageBox.Show("Информация о товаре обновлена!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);           

            button1Edit.Enabled = false;
            button2Refresh.Enabled = false;
            button3Cancel.Enabled = false;
            button4Delete.Enabled = false;
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
                MessageBox.Show("Заполните все поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Цена указана неверно!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            products.Add(newProduct);
            listBox1GoodsInfo.Items.Add(newProduct);

            textBox1Title.Text = string.Empty;
            textBox2Detail.Text = string.Empty;
            textBox3Description.Text = string.Empty;
            textBox4Price.Text = string.Empty;

            button1AddProd.Enabled = false;

            MessageBox.Show("Новый товар добавлен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4Delete_Click(object sender, EventArgs e)  // кнопка Удалить
        {
            int index = listBox1GoodsInfo.SelectedIndex;            
            listBox1GoodsInfo.Items.RemoveAt(index);
            products.RemoveAt(index);

            MessageBox.Show("Товар удалён!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

            button1Edit.Enabled = false;
            button4Delete.Enabled = false;
        }

        
    }
}
