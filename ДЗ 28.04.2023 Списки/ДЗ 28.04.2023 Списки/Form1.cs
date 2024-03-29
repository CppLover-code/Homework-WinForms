﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ДЗ_28._04._2023_Списки
{
    public partial class Form1 : Form
    {
        List<Person> persons = new List<Person>();
        FileStream stream = null;
        XmlSerializer serializer = null;
        string info = "Анкета.xml";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Список анкет";
            StartPosition = FormStartPosition.Manual;
            Width = 436;
            Height = 374;   

            var p1 = new Person("Алексей", "Петров", "alex_petrov94@gmail.com","+380938754265" );
            var p2 = new Person("Алёна", "Степанова", "al97_stepanova@gmail.com", "+380689845366");
            var p3 = new Person("Владимир", "Фёдоров", "fedorov-vova1988@gmail.com", "+380689845366");

            persons.Add(p1);
            persons.Add(p2);
            persons.Add(p3);

            foreach(var item in persons)
                listBox1.Items.Add(item);

            ToolTip toolTip1 = new ToolTip();   // всплывающая подсказка
         
            toolTip1.AutoPopDelay = 5000;       // Установка задержек для объекта ToolTip.
            toolTip1.InitialDelay = 300;
            toolTip1.ReshowDelay = 200;
            
            toolTip1.ShowAlways = true;         // отображение подсказки в зависимости от активности формы

            toolTip1.SetToolTip(this.textBox1Name, "Имя должно начинаться с большой буквы");
            toolTip1.SetToolTip(this.textBox2Surname, "Фамилия должна начинаться с большой буквы");
            toolTip1.SetToolTip(this.textBox3Mail, "Формат: ИмяПользователя@почтовый сервис.com");
            toolTip1.SetToolTip(this.textBox4Tel, "Формат: +380 XX XXX XX XX");
        }
        private void buttonAdd_Click(object sender, EventArgs e) // добавление в список
        {
            //CheckName(textBox1Name.Text);
            //CheckSurname(textBox2Surname.Text);
            //CheckEmail(textBox3Mail.Text);
            //CheckPhone(textBox4Tel.Text);

            string txtName = textBox1Name.Text;
            string txtSurname = textBox2Surname.Text;
            string txtEmail = textBox3Mail.Text;
            string txtPhone = textBox4Tel.Text;

            var person = new Person(txtName, txtSurname, txtEmail, txtPhone);
            listBox1.Items.Add(person);

            textBox1Name.Text = string.Empty;
            textBox2Surname.Text = string.Empty;
            textBox3Mail.Text = string.Empty;
            textBox4Tel.Text = string.Empty;
        }

        private void buttonDelete_Click(object sender, EventArgs e) // удаление из списка одного человека
        {
            int index = listBox1.SelectedIndex;
            if(index != -1)
            {
                listBox1.Items.RemoveAt(index);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                buttonAdd.Enabled = false;
                buttonDelete.Enabled = false;
                buttonSave.Enabled = true;
                var person = (Person)listBox1.Items[index];

                textBox1Name.Text = person.Name;
                textBox2Surname.Text = person.Surname;
                textBox3Mail.Text = person.Email;
                textBox4Tel.Text = person.Phone;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                string txtName = textBox1Name.Text;
                string txtSurname = textBox2Surname.Text;
                string txtEmail = textBox3Mail.Text;
                string txtPhone = textBox4Tel.Text;

                var person = new Person(txtName, txtSurname, txtEmail, txtPhone);
                listBox1.Items[index] = person;

                textBox1Name.Text = string.Empty;
                textBox2Surname.Text = string.Empty;
                textBox3Mail.Text = string.Empty;
                textBox4Tel.Text = string.Empty;
            }
            buttonDelete.Enabled = true;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(textBox1Name.Text) ||                        // (если поле Имя или Фамилия пустые) ИЛИ 
                String.IsNullOrEmpty(textBox2Surname.Text)) || buttonEdit.Focused) // фокус управления находится на кнопке Редактировать
            {
                buttonAdd.Enabled = false;                                         // кнопка Добавить не активна
            }
            else { buttonAdd.Enabled = true; }
           
        }

        private void buttonShowInfo_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                var prsn = (Person)listBox1.Items[index];
                //MessageBox.Show(prsn.Name + " " + h.Age.ToString());
                //MessageBox.Show($"Имя: {prsn.Name}\nФамилия: {prsn.Surname}\n E-mail: {prsn.Email}\nТелефон: {prsn.Phone}");
                MessageBox.Show(prsn.ShowInfo(),"Анкета");
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            persons.Clear();
            foreach (Person person in listBox1.Items)
            {               
                persons.Add(person);
            }
            stream = new FileStream(info, FileMode.Create);
            serializer = new XmlSerializer(typeof(List<Person>));
            serializer.Serialize(stream, persons);
            stream.Close();
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            persons.Clear();
            stream = new FileStream(info, FileMode.Open);
            serializer = new XmlSerializer(typeof(List<Person>));
            persons = (List<Person>)serializer.Deserialize(stream);           
            stream.Close();

            foreach (var item in persons)
                listBox1.Items.Add(item);   
        }

        private void CheckName(string name)
        {
            string pattern = "^([А-Я]{1}[а-яё]{1,10}$)";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(name))
                 MessageBox.Show("Ошибка в имени!");
        }
        private void CheckSurname(string surname)
        {
            string pattern = "^([А-Я]{1}[а-яё]{1,12}$)";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(surname))
                MessageBox.Show("Ошибка в фамилии!");
        }
        private void CheckEmail(string email)
        {
            string pattern = @"(\W|^)[\w.\-]{0,25}@[a-z]{0,8}\.com(\W|$)";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(email))
                MessageBox.Show("Ошибка в почте!");
        }
        private void CheckPhone(string email)// доделать
        {
            string pattern = @"надо дописать";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(email))
                MessageBox.Show("Ошибка в почте!");
        }
    }

    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Person() { }
        public Person(string name,string surname,string email, string phone)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
        }
        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
        public string ShowInfo()
        {
            return $"Имя: {Name}\nФамилия: {Surname}\n" +
                $"E-mail: {Email}\nТелефон: {Phone}";
        }
    }
}
