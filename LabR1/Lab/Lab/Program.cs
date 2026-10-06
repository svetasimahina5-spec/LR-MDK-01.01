using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = Functions.ReadPositiveDouble("Введите длину комнаты (м): ");
            double length = Functions.ReadPositiveDouble("Введите длину комнаты (м): ");
            double length = Functions.ReadPositiveDouble("Введите длину комнаты (м): ");
            double length = Functions.ReadPositiveDouble("Введите длину комнаты (м): ");
            double length = Functions.ReadPositiveDouble("Введите длину комнаты (м): ");
            double length = Functions.ReadPositiveDouble("Введите длину комнаты (м): ");
            double length = Functions.ReadPositiveDouble("Введите длину комнаты (м): ");
            double length = Functions.ReadPositiveDouble("Введите длину комнаты (м): ");
            double length = Functions.ReadPositiveDouble("Введите длину комнаты (м): ");
            double width = Functions.ReadPositiveDouble("Введите ширину комнаты (м): ");
            double height = Functions.ReadPositiveDouble("Введите высоту комнаты (м): ");
            double rollWidth = Functions.ReadPositiveDouble("Введите ширину рулона (м): ");
            double rollLength = Functions.ReadPositiveDouble("Введите длину рулона (м): ");

            int totalStrips = Functions.CalculateStrips(length, width, rollWidth);
            int stripsPerRoll = Functions.CalculateStripsPerRoll(rollLength, height);
            int rolls = Functions.CalculateRolls(totalStrips, stripsPerRoll);

            Console.WriteLine("Количество полос: " + totalStrips);
            Console.WriteLine("Количество рулонов: " + rolls);
        }
    }
}
