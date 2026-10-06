using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Functions
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
    }
}
