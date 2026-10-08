using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static bool IsValidDate(int day, int month)
        {
            if (month < 1 || month > 12)
                return false;

            int maxDays;
            switch (month)
            {
                case 2: maxDays = 28; break; // февраль (без високосных)
                case 4:
                case 6:
                case 9:
                case 11: maxDays = 30; break; // апрель, июнь, сентябрь, ноябрь
                default: maxDays = 31; break; // остальные
            }

            return day >= 1 && day <= maxDays;
        }

        static Season GetSeason(int month)
        {
            if (month == 12 || month <= 2) return Season.Winter;
            else if (month >= 3 && month <= 5) return Season.Spring;
            else if (month >= 6 && month <= 8) return Season.Summer;
            else return Season.Autumn;
        }

        static string GetActivity(Season season)
        {
            switch (season)
            {
                case Season.Winter: return "кататься на лыжах ";
                case Season.Spring: return "сажать цветы ";
                case Season.Summer: return "купаться ";
                case Season.Autumn: return "собирать грибы ";
                default: return "неизвестно";
            }
        }

        static void Main()
        {
            Console.Write("Введите день: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Введите месяц (1-12): ");
            int month = int.Parse(Console.ReadLine());

            if (!IsValidDate(day, month))
            {
                Console.WriteLine("\nОшибка: некорректная дата!");
                Console.ReadKey();
                return;
            }

            Season season = GetSeason(month);

            Console.WriteLine($"\nДата: {day:D2}.{month:D2}");
            Console.WriteLine($"Время года: {season}");
            Console.WriteLine($"Занятие: {GetActivity(season)}");

            Console.ReadKey();
        }
    }
}