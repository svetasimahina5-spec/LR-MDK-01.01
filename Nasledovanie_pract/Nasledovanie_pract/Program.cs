using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie_pract
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Csv-файл\файл.csv";

            List<Product> products = CsvLoader.LoadProducts(filePath);

            Console.WriteLine("Данные успешно загружены из файла");

            foreach (Product item in products)
            {
                string name = item.GetName();
                int price = item.GetPrice();
                int count = item.GetCount();
                double discount = item.CalculateDiscont();

                double totalCost = price * count;

                double finalSum = totalCost - (totalCost * discount / 100);

                Console.WriteLine($"Товар:{item.GetName()},Цена:{price},Кол-во:{item.GetCount()},Стоимость:{totalCost},Скидка{item.CalculateDiscont()}%, Сумма со скидкой: {finalSum}");
            }
        }
    }
}
