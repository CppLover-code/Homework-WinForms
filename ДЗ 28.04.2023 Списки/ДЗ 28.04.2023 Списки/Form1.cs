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
        List<Person> list = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var p1 = new Person("Алексей", "Петров", "alex_petrov94@gmail.com","+380938754265" );
            var p2 = new Person("Алёна", "Степанова", "al97_stepanova@gmail.com", "+380689845366");
            var p3 = new Person("Владимир", "Фёдоров", "fedorov-vova1988@gmail.com", "+380689845366");
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
            return $"Имя: {Name}\nФамилия: {Surname}\n" +
                $"E-mail: {Email}\nТелефон: {Phone}";
        }
    }
}
