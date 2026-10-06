using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BudgetCategory
    {
        public string Name_;
        public decimal Limit_;
        public decimal Spent_;

        public BudgetCategory(string name, decimal limit, decimal spent)
        {
            Name_ = name;
            Limit_ = limit;
            Spent_ = spent;
        }

        public decimal Remaining => Limit_ - Spent_;

        public void ApplyExpense(decimal amount)
        {
            Spent_ += amount;
        }
    }
}
