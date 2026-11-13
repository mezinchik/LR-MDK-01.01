using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\Csv-файл\файл.csv";

            List<Product> products = CSVLoader.LoadProducts(filePath);

            Console.WriteLine("Данные успешно загружены из файла");



            foreach (Product item in products)
            {
                string name = item.GetName();
                int price = item.GetPrice();
                int count = item.GetCount();
                double discount = item.CalculateDiscount();

                double totalCost = price * count;

                double finalSum = totalCost - (totalCost * discount / 100);

                Console.WriteLine($"Товар:{item.GetName()},Цена:{price},Кол-во:{item.GetCount()},Стоимость:{totalCost},Скидка{item.CalculateDiscount()}%, Сумма со скидкой: {finalSum}");
            }
        }
    }
}
