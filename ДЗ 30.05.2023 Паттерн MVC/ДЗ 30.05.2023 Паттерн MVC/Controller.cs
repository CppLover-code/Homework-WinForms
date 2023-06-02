using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ДЗ_30._05._2023_Паттерн_MVC.Model;

namespace ДЗ_30._05._2023_Паттерн_MVC
{
    public class Controller
    {
        DataBase dB = new DataBase(); // наша база данных людей
        public void AddPerson(string n, int a) // добавляем человека в базу данных
        {
            dB.Add(new Person(n, a));
        }
        public List<Person> GetAllPerson()  // получает весь список из базы данных
        {
            return dB.GetPeople();
        }
        public void Delete(Person a)
        {
            dB.DeletePerson(a);
        }
        public List<Person> SearchP(string n)
        {
            return dB.Search(n);
        }
    }
}
