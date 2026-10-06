using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class BudgetManager
    {
        public static List<BudgetCategory> CreateDefaultCategories()
        {
            return new List<BudgetCategory>
            {
                new BudgetCategory("продукты",     20000m, 6500m),
                new BudgetCategory("транспорт",     8000m, 3200m),
                new BudgetCategory("жильё",        40000m, 25000m),
                new BudgetCategory("развлечения",  12000m, 4000m),
                new BudgetCategory("одежда",       15000m, 9500m)
            };
        }

        public static void PrintCategories(List<BudgetCategory> categories)
        {
            Console.WriteLine("Категории бюджета:");
            for (int i = 0; i < categories.Count; i++)
            {
                var c = categories[i];
                Console.WriteLine(
                    $"{i + 1}. {c.Name_} — остаток лимита {c.Remaining} руб., лимит {c.Limit_} руб.");
            }
        }

        public static Dictionary<int, decimal> ReadPlan(List<BudgetCategory> categories)
        {
            var plan = new Dictionary<int, decimal>();

            while (true)
            {
                int number = InputHelper.ReadCategoryNumber(
                    "Введите номер категории (0 — конец плана): ",
                    1, categories.Count);

                if (number == 0)
                    break;

                decimal sum = InputHelper.ReadNonNegativeDecimal("Введите сумму: ");
                int index = number - 1;

                if (plan.ContainsKey(index))
                    plan[index] += sum;
                else
                    plan[index] = sum;
            }

            return plan;
        }

        public static bool TryApplyPlan(List<BudgetCategory> categories, Dictionary<int, decimal> plan)
        {
            foreach (var pair in plan)
            {
                var category = categories[pair.Key];
                if (pair.Value > category.Remaining)
                {
                    Console.WriteLine(
                        $"Недостаточно лимита по категории «{category.Name_}»: " +
                        $"остаток {category.Remaining} руб., запланировано {pair.Value} руб.");
                    return false;
                }
            }

            foreach (var pair in plan)
            {
                categories[pair.Key].ApplyExpense(pair.Value);
            }

            return true;
        }

        public static void PrintTotalExpenses(Dictionary<int, decimal> plan)
        {
            decimal total = 0m;
            foreach (var value in plan.Values)
                total += value;

            Console.WriteLine($"Общая сумма расходов: {total} руб.");
        }

        public static void PrintRemaining(List<BudgetCategory> categories)
        {
            Console.Write("Остаток лимита: ");
            for (int i = 0; i < categories.Count; i++)
            {
                Console.Write($"{categories[i].Name_} {categories[i].Remaining}");
                if (i < categories.Count - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
