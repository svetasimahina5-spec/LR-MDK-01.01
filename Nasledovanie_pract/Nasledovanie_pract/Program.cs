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
            List<Product> products = new List<Product>();

            Product baseProd = new Product();
            baseProd.SetName("Базовый товар");
            baseProd.SetPrice(100);
            baseProd.SetCount(15);
            products.Add(baseProd);

            Food food1 = new Food();
            food1.SetName("Чипсы (скидка 15%)");
            food1.SetPrice(50);
            food1.SetCount(7);
            products.Add(food1);

            Food food2 = new Food();
            food2.SetName("Сухарики (скидка 25%)");
            food2.SetPrice(50);
            food2.SetCount(12);
            products.Add(food2);

            Drinks drink1 = new Drinks();
            drink1.SetName("Газировка (скидка 10%)");
            drink1.SetPrice(80);
            drink1.SetCount(50);
            products.Add(drink1);

            Drinks drink2 = new Drinks();
            drink2.SetName("Сок (скидка 30%)");
            drink2.SetPrice(80);
            drink2.SetCount(200);
            products.Add(drink2);

            Drinks drink3 = new Drinks();
            drink3.SetName("Вино (скидка 50%)");
            drink3.SetPrice(80);
            drink3.SetCount(350);
            products.Add(drink3);

            Console.WriteLine("Список товаров и их скидки");
            foreach (var item in products)
            {
                Console.WriteLine($"Товар:{item.GetName()},Кол-во:{item.GetCount()},Скидка{item.CalculateDiscont()}%");
            }
            
        }
    }
}
