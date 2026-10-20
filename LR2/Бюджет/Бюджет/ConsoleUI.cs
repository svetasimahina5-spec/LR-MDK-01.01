using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Бюджет
{
    public static class ConsoleUI
    {
        public static void PrintInitialCategories()
        {
            Console.WriteLine("Категории бюджета:");
            for (int i = 0; i < BudgetData.CategoryNames.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {BudgetData.CategoryNames[i]} – остаток лимита {BudgetData.CurrentBalances[i]} руб., лимит {BudgetData.InitialLimits[i]} руб.");
            }
        }

        public static int GetValidCategoryNumber()
        {
            while (true)
            {
                Console.Write("Введите номер категории (0 - конец плана): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int category))
                {
                    if (category >= 0 && category <= 5)
                    {
                        return category;
                    }
                }
                Console.WriteLine("Ошибка: введено не число или номер категории вне диапазона 1-5 (или 0 для выхода).");
            }
        }

        public static int GetValidAmount()
        {
            while (true)
            {
                Console.Write("Введите сумму: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int amount) && amount >= 0)
                {
                    return amount;
                }
                Console.WriteLine("Ошибка: введено не число или сумма меньше нуля.");
            }
        }

        public static void PrintResult(bool isSuccess, int totalSum, string errorMessage)
        {
            if (isSuccess)
            {
                Console.WriteLine($"Общая сумма расходов: {totalSum} руб.");
                Console.Write("Остаток лимита: ");
                for (int i = 0; i < BudgetData.CategoryNames.Count; i++)
                {
                    Console.Write($"{BudgetData.CategoryNames[i]} {BudgetData.CurrentBalances[i]}");
                    if (i < BudgetData.CategoryNames.Count - 1) Console.Write(", ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Ошибка: {errorMessage}");
                Console.WriteLine("Остатки лимита не изменены, общая сумма не выводится.");
            }
        }
    }
}