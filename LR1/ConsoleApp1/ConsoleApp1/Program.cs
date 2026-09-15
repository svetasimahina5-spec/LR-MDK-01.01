using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = Class1.ReadPositiveDouble("Введите длину комнаты (м): ");
            double width = Class1.ReadPositiveDouble("Введите ширину комнаты (м): ");
            double height = Class1.ReadPositiveDouble("Введите высоту комнаты (м): ");
            double rollWidth = Class1.ReadPositiveDouble("Введите ширину рулона (м): ");
            double rollLength = Class1.ReadPositiveDouble("Введите длину рулона (м): ");

            int totalStrips = Class1.CalculateStrips(length, width, rollWidth);
            int stripsPerRoll = Class1.CalculateStripsPerRoll(rollLength, height);
            int rolls = Class1.CalculateRolls(totalStrips, stripsPerRoll);

            Console.WriteLine("Количество полос: " + totalStrips);
            Console.WriteLine("Количество рулонов: " + rolls);
        }
    }
}
