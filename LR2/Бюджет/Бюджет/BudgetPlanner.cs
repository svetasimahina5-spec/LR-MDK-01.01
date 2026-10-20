using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Бюджет
{
    public static class BudgetData
    {
        public static List<string> CategoryNames = new List<string> { "продукты", "транспорт", "жилье", "развлечения", "одежда" };
        public static List<int> InitialLimits = new List<int> { 20000, 8000, 40000, 12000, 15000 };
        public static List<int> CurrentBalances = new List<int> { 13500, 4800, 15000, 8000, 5500 };

        public static Dictionary<int, int> PlannedExpenses = new Dictionary<int, int>();
    }
}
