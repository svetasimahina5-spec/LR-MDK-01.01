using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Program
    {
        static void Main(string[] args)
        {
            List<BudgetCategory> categories = BudgetManager.CreateDefaultCategories();

            BudgetManager.PrintCategories(categories);

            Dictionary<int, decimal> plan = BudgetManager.ReadPlan(categories);

            bool accepted = BudgetManager.TryApplyPlan(categories, plan);

            if (accepted)
                BudgetManager.PrintTotalExpenses(plan);

            BudgetManager.PrintRemaining(categories);
        }
    }
}
