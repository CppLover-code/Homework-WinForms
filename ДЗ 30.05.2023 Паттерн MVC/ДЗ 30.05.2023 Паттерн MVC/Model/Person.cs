using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_30._05._2023_Паттерн_MVC.Model
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; } = 18;

        public Person(string n, int a)
        {
            Name = n;
            Age = a;
        }
        public override string ToString()
        {
            return $"Имя: {Name} Возраст: {Age} ";
        }
    }
}
