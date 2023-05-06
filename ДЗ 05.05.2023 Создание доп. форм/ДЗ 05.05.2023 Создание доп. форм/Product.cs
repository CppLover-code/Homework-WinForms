using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_05._05._2023_Создание_доп.форм
{
    public class Product
    {
        string title;       // название товара
        string detail;      // характеристика
        string description; // описание
        double price;       //цена

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Detail
        {
            get { return detail; }
            set { detail = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (price < 0)
                    throw new System.Exception("Цена не может быть меньше нуля");
                price = value;
            }
        }
        public Product()
        {
            Title = "unknown";
            Detail = "unknown";
            Description = "unknown";
            Price = 0;          
        }
        public Product(string t, string det, string descr, double price)
        {
            Title = t;
            Detail = det;
            Description = descr;
            Price = price;
        }
        public override string ToString()
        {
            return Title + "\nХарактеристика: " + Detail +"\nОписание: " + Description; //+ "\nЦена: " + Price
        }
    }
}
