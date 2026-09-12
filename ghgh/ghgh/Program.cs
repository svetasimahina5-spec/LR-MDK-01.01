using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ghgh
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = NaturalNumber();

            int sum = SlozSum(number);

            Console.WriteLine($"Сумма цифр числа:{number} равна:{sum}");
        }
        static int NaturalNumber()
        {
            int number;
            while (true)
            {
                Console.Write("Введите натуральное число: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out number)&& number >0 )
                {
                    return number;
                }

                Console.WriteLine("Ошибка. Введите корректное натуральное число (больше 0)");
            }
           
        }
        static int SlozSum(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int last = n % 10;
                sum += last;
                n /= 10;
            }
            return sum;
        }
    }
}
