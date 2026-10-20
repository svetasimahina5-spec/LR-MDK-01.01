using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class BudgetManager
    {
        public static void PrintCategories()
        {
            Console.WriteLine("Категории бюджета:");
            for (int i = 0; i < BudgetData.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + BudgetData.names_[i] + " — остаток лимита " + BudgetData.Remaining(i)
                    + " руб., лимит " + BudgetData.limits_[i] + " руб.");
            }
        }
        public static decimal[] ReadPlan()
        {
            decimal[] plan = new decimal[BudgetData.Count];

            while (true)
            {
                int number = InputHelper.ReadCategoryNumber("Введите номер категории (0 — конец плана): ", BudgetData.Count);

                if (number == 0)
                    break;

                decimal sum = InputHelper.ReadNonNegativeDecimal("Введите сумму: ");
                plan[number - 1] += sum;
            }

            return plan;
        }

    }
}
