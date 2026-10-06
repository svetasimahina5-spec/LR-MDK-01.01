using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class InputHelper
    {
        public static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int value))
                    return value;

                Console.WriteLine("Ошибка: введите целое число.");
            }
        }

        public static int ReadCategoryNumber(string prompt, int min, int max)
        {
            while (true)
            {
                int value = ReadInt(prompt);
                if (value == 0)
                    return 0; // 0 — сигнал окончания ввода

                if (value >= min && value <= max)
                    return value;

                Console.WriteLine($"Ошибка: номер категории должен быть от {min} до {max} или 0.");
            }
        }

        public static decimal ReadNonNegativeDecimal(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (decimal.TryParse(input, out decimal value) && value >= 0)
                    return value;

                Console.WriteLine("Ошибка: введите неотрицательное число.");
            }
        }
    }
}
