using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДЗ_28._04._2023_Списки
{
    public partial class Form1 : Form
    {
        List<Person> persons = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var p1 = new Person("Алексей", "Петров", "alex_petrov94@gmail.com","+380938754265" );
            var p2 = new Person("Алёна", "Степанова", "al97_stepanova@gmail.com", "+380689845366");
            var p3 = new Person("Владимир", "Фёдоров", "fedorov-vova1988@gmail.com", "+380689845366");

            persons.Add(p1);
            persons.Add(p2);
            persons.Add(p3);

            foreach(var item in persons)
                listBox1.Items.Add(item);
        }
        private void buttonAdd_Click(object sender, EventArgs e) // добавление в список
        {           
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

        private void textBox1Name_TextChanged(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(textBox1Name.Text) ||                        // (если поле Имя или Фамилия пустые) ИЛИ 
                String.IsNullOrEmpty(textBox2Surname.Text)) || buttonEdit.Focused) // фокус управления находится на кнопке Редактировать
            {
                buttonAdd.Enabled = false;                                         // кнопка Добавить не активна

            }
            else { buttonAdd.Enabled = true; }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
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
        //public override string ToString()
        //{
        //    return $"Имя: {Name}\nФамилия: {Surname}\n" +
        //        $"E-mail: {Email}\nТелефон: {Phone}";
        //}
    }
}
