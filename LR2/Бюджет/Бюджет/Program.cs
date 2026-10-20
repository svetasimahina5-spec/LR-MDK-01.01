using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Бюджет
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUI.PrintInitialCategories();
            BudgetManager.ProcessUserInput();
            BudgetManager.CalculateAndShowFinalPlan();

            Console.ReadLine();
        }
    }
}
