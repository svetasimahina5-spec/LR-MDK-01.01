using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        public static double ReadPositiveDouble(string prompt)
        {
            double value;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (double.TryParse(input, out value) && value > 0)
                    return value;

                Console.WriteLine("Ошибка: введите положительное число. Повторите ввод.");
            }
        }

        public static int CalculateStrips(double length, double width, double rollWidth)
        {
            double perimeter = 2 * (length + width);
            return (int)Math.Ceiling(perimeter / rollWidth);
        }

        public static int CalculateStripsPerRoll(double rollLength, double height)
        {
            double stripLength = height + 0.1;
            return (int)(rollLength / stripLength);
        }

        public static int CalculateRolls(int totalStrips, int stripsPerRoll)
        {
            return (int)Math.Ceiling((double)totalStrips / stripsPerRoll);
        }
    }
}
