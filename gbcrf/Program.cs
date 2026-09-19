using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gbcrf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            int even = 0;
            int odd = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите число: ");
                numbers[i] = int.Parse(Console.ReadLine());

                if (numbers[i] % 2 == 0)
                    even++;
                else
                    odd++;
            }

            Console.WriteLine("Количество четных элементов: " + even);
            Console.WriteLine("Количество нечетных элементов: " + odd);
        }
    }
}
    

