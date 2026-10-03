using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            List<Sale> sales = new List<Sale>();
            List<Check> checks = new List<Check>();
            InputSales(sales);
            Period.ShowPeriod(checks);
        }
             static void InputSales( List<Sale> sales)
             {
                Console.WriteLine("Введите количество продаж:");
                int n = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    Sale sale = new Sale();
                    Console.WriteLine($"Продажа {i + 1}: ");

                    Console.Write("Название товара:");
                    sale.Name_ = Console.ReadLine();

                    Console.Write("Количество:");
                    sale.Count_ = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Цена:");
                    sale.Price_ = Convert.ToDouble(Console.ReadLine());

                    sale.Date_ = DateTime.Now;
                    sales.Add(sale);
                }
             }
        public static void PrintCheck(List<Sale> sales)
        {
            Console.WriteLine("Чек");
            double sum = 0;
            foreach (Sale sale in sales)
            {
                double cost = sale.Count_ * sale.Price_;
                Console.WriteLine($"{sale.Name_}, {sale.Count_} штуки, {sale.Price_} рублей, {cost} рублей");
                sum += cost;
            }
            Console.WriteLine($"ВСЕГО:{sum} рублей");
        }
        public static SaleReport ShowReport(List<Sale> sales)
        {
            SaleReport report = new SaleReport();
            int totalCount = 0;
            double totalCost = 0;

            foreach (Sale sale in sales)
            {
                totalCount += sale.Count_;
                totalCost += sale.Count_ * sale.Price_;
            }
            return report;
        }
    }
    }

