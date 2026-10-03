using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Period
    {
        public static void ShowPeriod(List<Check> checks)
        {
            DateTime startDate = DateTime.Now.AddDays(-7);
            DateTime endDate = DateTime.Now;

            int count = 0;
            double cost = 0;

            foreach (Check check in checks)
            {
                if (check.Date_ >= startDate && check.Date_ <= endDate)
                {
                    foreach (Sale sale  in check.sales_)
                    {
                        count += sale.Count_;
                        cost += sale.Count_ * sale.Price_;
                    }
                }
            }
            Console.WriteLine("Отчет о продажах за период");
            Console.WriteLine($"Начало периода: {startDate:dd.MM.yyyy}");
            Console.WriteLine($"Конец периода: {endDate:dd.MM.yyyy}");
            Console.WriteLine($"Количество проданных товаров: {count}");
            Console.WriteLine($"Стоимость продаж: {cost}");
        }
    }
}
