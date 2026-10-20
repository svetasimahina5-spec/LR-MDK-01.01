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
                int value;
                if (int.TryParse(input, out value))
                    return value;

                Console.WriteLine("Ошибка: введите целое число.");
            }
        }
        public static int ReadCategoryNumber(string prompt, int max)
        {
            while (true)
            {
                int value = ReadInt(prompt);
                if (value == 0)
                    return 0;
                if (value >= 1 && value <= max)
                    return value;

                Console.WriteLine("Ошибка: номер категории должен быть от 1 до " + max + " или 0.");
            }
        }
    }
}
