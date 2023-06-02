using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_30._05._2023_Паттерн_MVC.Model
{
    public class DataBase
    {
        List<Person> people;

        public DataBase()
        {
            people = new List<Person>();
        }
        public void Add(Person obj)
        {
            people.Add(obj);
        }
        public List<Person> GetPeople()
        {
            return people;
        }
        public void DeletePerson(Person a)
        {
            people.Remove(a);
        }
        public List<Person> Search(string name)
        {
            var res = from person in people
                      where person.Name == name
                      select person;

            List<Person> result = new List<Person>();
            foreach (var a in res)
            {
                result.Add(a);
            }

            return result;
        }
    }
}
