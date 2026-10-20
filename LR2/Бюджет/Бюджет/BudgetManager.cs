using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Бюджет
{
    public static class BudgetManager
    {
        public static void ProcessUserInput()
        {
            BudgetData.PlannedExpenses.Clear();

            while (true)
            {
                int category = ConsoleUI.GetValidCategoryNumber();

                if (category == 0)
                    break;

                int amount = ConsoleUI.GetValidAmount();

                int index = category - 1;

                if (BudgetData.PlannedExpenses.ContainsKey(index))
                {
                    BudgetData.PlannedExpenses[index] += amount;
                }
                else
                {
                    BudgetData.PlannedExpenses[index] = amount;
                }
            }
        }

        public static void CalculateAndShowFinalPlan()
        {
            bool isOverLimit = false;
            string errorCategoryName = "";
            int totalSum = 0;

            foreach (var expense in BudgetData.PlannedExpenses)
            {
                int index = expense.Key;
                int amount = expense.Value;
                totalSum += amount;

                if (amount > BudgetData.CurrentBalances[index])
                {
                    isOverLimit = true;
                    errorCategoryName = BudgetData.CategoryNames[index];
                    break;
                }
            }

            if (!isOverLimit)
            {
                foreach (var expense in BudgetData.PlannedExpenses)
                {
                    BudgetData.CurrentBalances[expense.Key] -= expense.Value;
                }
                ConsoleUI.PrintResult(true, totalSum, "");
            }
            else
            {
                ConsoleUI.PrintResult(false, 0, $"лимита не хватает по категории '{errorCategoryName}'");
            }
        }
    }
}
